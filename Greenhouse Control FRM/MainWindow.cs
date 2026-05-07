namespace Greenhouse_Control_FRM;

public partial class MainWindow : Form
{
    private const string BaseTitle = "Greenhouse Control FRM";
    private readonly GreenhouseClient _client = new();
    private bool _suppressOutgoing;
    private bool _pendingLightChange;
    private bool _pendingLightValue;
    private bool _pendingAutoWaterChange;
    private bool _pendingAutoWaterValue;
    private bool _pendingFrequencyChange;
    private int _pendingFrequencyValue;
    private bool _pendingDispenseChange;
    private int _pendingDispenseValue;

    public MainWindow()
    {
        InitializeComponent();
        _client.LineReceived += OnLineReceived;
        _client.Disconnected += OnDisconnected;
        FormClosing += MainWindow_FormClosing;
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        UpdateConnectionStateUI(false);
        UpdateConnectionButton();
        UpdateFrequencyLabel(waterfrequency.Value);
        UpdateDispenseLabel(dispenseamount.Value);

        ghouselightingoff.Checked = true;
        radioButton2.Checked = true;
        waterpumpoff.Checked = true;

        ghouselightingon.CheckedChanged += LightingRadio_CheckedChanged;
        ghouselightingoff.CheckedChanged += LightingRadio_CheckedChanged;
        radioButton1.CheckedChanged += AutoWaterRadio_CheckedChanged;
        radioButton2.CheckedChanged += AutoWaterRadio_CheckedChanged;
        waterpumpon.CheckedChanged += PumpRadio_CheckedChanged;
        waterpumpoff.CheckedChanged += PumpRadio_CheckedChanged;

        waterfrequency.ValueChanged += Waterfrequency_ValueChanged;
        waterfrequency.MouseUp += Waterfrequency_MouseUp;
        waterfrequency.KeyUp += Waterfrequency_KeyUp;
        waterfrequency.Leave += Waterfrequency_Leave;

        dispenseamount.ValueChanged += Dispenseamount_ValueChanged;
        dispenseamount.MouseUp += Dispenseamount_MouseUp;
        dispenseamount.KeyUp += Dispenseamount_KeyUp;
        dispenseamount.Leave += Dispenseamount_Leave;

        shutdownbutton.Click += Shutdownbutton_Click;
        restartbutton.Click += Restartbutton_Click;
    }

    private async void MainWindow_FormClosing(object? sender, FormClosingEventArgs e)
    {
        await _client.DisconnectAsync();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        if (_client.IsConnected)
        {
            await _client.DisconnectAsync();
            UpdateConnectionButton();
            UpdateConnectionStateUI(false);
            return;
        }

        var ipAddress = ipaddresstext.Text.Trim();
        if (string.IsNullOrWhiteSpace(ipAddress))
        {
            ShowError("Enter a valid IP address.");
            return;
        }

        if (!int.TryParse(greenhouseportbox.Text.Trim(), out var port) || port is <= 0 or >= 65536)
        {
            ShowError("Enter a valid port number.");
            return;
        }

        try
        {
            await _client.ConnectAsync(ipAddress, port);
            UpdateConnectionButton();
            UpdateConnectionStateUI(true);
        }
        catch (Exception ex)
        {
            ShowError($"Connection failed: {ex.Message}");
        }
    }

    private async void LightingRadio_CheckedChanged(object? sender, EventArgs e)
    {
        if (_suppressOutgoing || !_client.IsConnected)
        {
            return;
        }

        if (sender == ghouselightingon && ghouselightingon.Checked)
        {
            _pendingLightChange = true;
            _pendingLightValue = true;
            await SendCommandAsync("LIGHT ON");
        }
        else if (sender == ghouselightingoff && ghouselightingoff.Checked)
        {
            _pendingLightChange = true;
            _pendingLightValue = false;
            await SendCommandAsync("LIGHT OFF");
        }
    }

    private async void AutoWaterRadio_CheckedChanged(object? sender, EventArgs e)
    {
        if (_suppressOutgoing || !_client.IsConnected)
        {
            return;
        }

        if (sender == radioButton1 && radioButton1.Checked)
        {
            _pendingAutoWaterChange = true;
            _pendingAutoWaterValue = true;
            await SendCommandAsync("AUTOWATER ON");
        }
        else if (sender == radioButton2 && radioButton2.Checked)
        {
            _pendingAutoWaterChange = true;
            _pendingAutoWaterValue = false;
            await SendCommandAsync("AUTOWATER OFF");
        }
    }

    private async void PumpRadio_CheckedChanged(object? sender, EventArgs e)
    {
        if (_suppressOutgoing || !_client.IsConnected)
        {
            return;
        }

        if (sender == waterpumpon && waterpumpon.Checked)
        {
            await SendCommandAsync("PUMP ON");
        }
        else if (sender == waterpumpoff && waterpumpoff.Checked)
        {
            await SendCommandAsync("PUMP OFF");
        }
    }

    private void Waterfrequency_ValueChanged(object? sender, EventArgs e)
    {
        UpdateFrequencyLabel(waterfrequency.Value);

        if (_suppressOutgoing || !_client.IsConnected)
        {
            return;
        }

        _pendingFrequencyChange = true;
        _pendingFrequencyValue = waterfrequency.Value;
    }

    private void Dispenseamount_ValueChanged(object? sender, EventArgs e)
    {
        UpdateDispenseLabel(dispenseamount.Value);

        if (_suppressOutgoing || !_client.IsConnected)
        {
            return;
        }

        _pendingDispenseChange = true;
        _pendingDispenseValue = dispenseamount.Value;
    }

    private async void Waterfrequency_MouseUp(object? sender, MouseEventArgs e)
    {
        await SendFrequencyIfPendingAsync();
    }

    private async void Waterfrequency_KeyUp(object? sender, KeyEventArgs e)
    {
        await SendFrequencyIfPendingAsync();
    }

    private async void Waterfrequency_Leave(object? sender, EventArgs e)
    {
        await SendFrequencyIfPendingAsync();
    }

    private async void Dispenseamount_MouseUp(object? sender, MouseEventArgs e)
    {
        await SendDispenseIfPendingAsync();
    }

    private async void Dispenseamount_KeyUp(object? sender, KeyEventArgs e)
    {
        await SendDispenseIfPendingAsync();
    }

    private async void Dispenseamount_Leave(object? sender, EventArgs e)
    {
        await SendDispenseIfPendingAsync();
    }

    private async void Shutdownbutton_Click(object? sender, EventArgs e)
    {
        await SendCommandAsync("SHUTDOWN");
    }

    private async void Restartbutton_Click(object? sender, EventArgs e)
    {
        await SendCommandAsync("RESTART");
    }

    private async Task SendFrequencyIfPendingAsync()
    {
        if (!_client.IsConnected || !_pendingFrequencyChange)
        {
            return;
        }

        _pendingFrequencyChange = false;
        await SendCommandAsync($"FREQUENCY {_pendingFrequencyValue}");
    }

    private async Task SendDispenseIfPendingAsync()
    {
        if (!_client.IsConnected || !_pendingDispenseChange)
        {
            return;
        }

        _pendingDispenseChange = false;
        await SendCommandAsync($"DISPENSE {_pendingDispenseValue}");
    }

    private void OnLineReceived(string line)
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke(() => ProcessIncomingLine(line));
            return;
        }

        ProcessIncomingLine(line);
    }

    private void OnDisconnected()
    {
        if (IsDisposed)
        {
            return;
        }

        if (InvokeRequired)
        {
            BeginInvoke(OnDisconnected);
            return;
        }

        ResetPendingFlags();
        UpdateConnectionButton();
        UpdateConnectionStateUI(false);
    }

    private void ProcessIncomingLine(string line)
    {
        try
        {
            if (!line.StartsWith("SETTINGS ", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var payload = line.Substring("SETTINGS ".Length);
            var settings = System.Text.Json.JsonSerializer.Deserialize<ServerSettings>(payload);
            if (settings is null)
            {
                ShowError("Received empty settings from server.");
                return;
            }

            _suppressOutgoing = true;

            if (!_pendingLightChange || settings.LightOn == _pendingLightValue)
            {
                ghouselightingon.Checked = settings.LightOn;
                ghouselightingoff.Checked = !settings.LightOn;
                _pendingLightChange = false;
            }

            if (!_pendingAutoWaterChange || settings.AutoWaterOn == _pendingAutoWaterValue)
            {
                radioButton1.Checked = settings.AutoWaterOn;
                radioButton2.Checked = !settings.AutoWaterOn;
                _pendingAutoWaterChange = false;
            }

            if (!_pendingFrequencyChange || settings.FrequencyHours == _pendingFrequencyValue)
            {
                waterfrequency.Value = Clamp(settings.FrequencyHours, waterfrequency.Minimum, waterfrequency.Maximum);
                UpdateFrequencyLabel(waterfrequency.Value);
                _pendingFrequencyChange = false;
            }

            if (!_pendingDispenseChange || settings.DispenseSeconds == _pendingDispenseValue)
            {
                dispenseamount.Value = Clamp(settings.DispenseSeconds, dispenseamount.Minimum, dispenseamount.Maximum);
                UpdateDispenseLabel(dispenseamount.Value);
                _pendingDispenseChange = false;
            }

            UpdateConnectionStateUI(true);
        }
        catch (System.Text.Json.JsonException ex)
        {
            ShowError($"Bad settings from server: {ex.Message}");
        }
        catch (Exception ex)
        {
            ShowError($"Update failed: {ex.Message}");
        }
        finally
        {
            _suppressOutgoing = false;
        }
    }

    private void ResetPendingFlags()
    {
        _pendingLightChange = false;
        _pendingAutoWaterChange = false;
        _pendingFrequencyChange = false;
        _pendingDispenseChange = false;
    }

    private async Task SendCommandAsync(string command)
    {
        if (!_client.IsConnected)
        {
            return;
        }

        try
        {
            await _client.SendLineAsync(command);
        }
        catch (Exception ex)
        {
            ShowError($"Send failed: {ex.Message}");
        }
    }

    private void UpdateConnectionButton()
    {
        connectbutton.Text = _client.IsConnected ? "Disconnect" : "Connect";
    }

    private void UpdateFrequencyLabel(int value)
    {
        waterfreqlabel.Text = $"{value}h";
    }

    private void UpdateDispenseLabel(int value)
    {
        dispenseamountlabel.Text = $"{value}s";
    }

    private void UpdateConnectionStateUI(bool isConnected)
    {
        Text = $"{BaseTitle} - {(isConnected ? "Connected" : "Disconnected")}";
        configurationbox.Enabled = isConnected;
    }

    private void ShowError(string message)
    {
        MessageBox.Show(this, message, BaseTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private static int Clamp(int value, int min, int max)
    {
        if (value < min)
        {
            return min;
        }

        if (value > max)
        {
            return max;
        }

        return value;
    }

    private void label1_Click(object sender, EventArgs e)
    {
        // No-op placeholder to keep designer wiring stable if added later.
    }

    private void toolTip1_Popup(object sender, PopupEventArgs e)
    {
        // No-op placeholder to keep designer wiring stable if added later.
    }

    private void groupBox4_Enter(object sender, EventArgs e)
    {
        // No-op placeholder to keep designer wiring stable if added later.
    }

    private void groupBox4_Enter_1(object sender, EventArgs e)
    {
        // No-op placeholder to keep designer wiring stable if added later.
    }

    private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        // No-op placeholder to keep designer wiring stable if added later.
    }
}