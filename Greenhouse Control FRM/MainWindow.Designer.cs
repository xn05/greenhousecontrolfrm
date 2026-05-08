namespace Greenhouse_Control_FRM;

partial class MainWindow
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        connection = new System.Windows.Forms.GroupBox();
        connectbutton = new System.Windows.Forms.Button();
        greenhouseport = new System.Windows.Forms.GroupBox();
        greenhouseportbox = new System.Windows.Forms.TextBox();
        greenhouseip = new System.Windows.Forms.GroupBox();
        ipaddresstext = new System.Windows.Forms.TextBox();
        configurationbox = new System.Windows.Forms.GroupBox();
        poweroptionsbox = new System.Windows.Forms.GroupBox();
        waterpumpdebugbox = new System.Windows.Forms.GroupBox();
        waterpumpon = new System.Windows.Forms.RadioButton();
        waterpumpoff = new System.Windows.Forms.RadioButton();
        restartbutton = new System.Windows.Forms.Button();
        shutdownbutton = new System.Windows.Forms.Button();
        automaticwateringbox = new System.Windows.Forms.GroupBox();
        wateringfrequencybox = new System.Windows.Forms.GroupBox();
        waterfreqlabel = new System.Windows.Forms.Label();
        waterfrequency = new System.Windows.Forms.TrackBar();
        dispenseamountbox = new System.Windows.Forms.GroupBox();
        dispenseamountlabel = new System.Windows.Forms.Label();
        dispenseamount = new System.Windows.Forms.TrackBar();
        radioButton1 = new System.Windows.Forms.RadioButton();
        radioButton2 = new System.Windows.Forms.RadioButton();
        greenhouseLighting = new System.Windows.Forms.GroupBox();
        ghouselightingon = new System.Windows.Forms.RadioButton();
        ghouselightingoff = new System.Windows.Forms.RadioButton();
        connection.SuspendLayout();
        greenhouseport.SuspendLayout();
        greenhouseip.SuspendLayout();
        configurationbox.SuspendLayout();
        poweroptionsbox.SuspendLayout();
        waterpumpdebugbox.SuspendLayout();
        automaticwateringbox.SuspendLayout();
        wateringfrequencybox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)waterfrequency).BeginInit();
        dispenseamountbox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dispenseamount).BeginInit();
        greenhouseLighting.SuspendLayout();
        SuspendLayout();
        // 
        // connection
        // 
        connection.Controls.Add(connectbutton);
        connection.Controls.Add(greenhouseport);
        connection.Controls.Add(greenhouseip);
        connection.Location = new System.Drawing.Point(12, 12);
        connection.Name = "connection";
        connection.Size = new System.Drawing.Size(417, 97);
        connection.TabIndex = 0;
        connection.TabStop = false;
        connection.Text = "Connection";
        // 
        // connectbutton
        // 
        connectbutton.Location = new System.Drawing.Point(295, 42);
        connectbutton.Name = "connectbutton";
        connectbutton.Size = new System.Drawing.Size(109, 24);
        connectbutton.TabIndex = 2;
        connectbutton.Text = "Connect";
        connectbutton.UseVisualStyleBackColor = true;
        connectbutton.Click += button1_Click;
        // 
        // greenhouseport
        // 
        greenhouseport.Controls.Add(greenhouseportbox);
        greenhouseport.Location = new System.Drawing.Point(147, 22);
        greenhouseport.Name = "greenhouseport";
        greenhouseport.Size = new System.Drawing.Size(135, 58);
        greenhouseport.TabIndex = 1;
        greenhouseport.TabStop = false;
        greenhouseport.Text = "Greenhouse Port";
        // 
        // greenhouseportbox
        // 
        greenhouseportbox.Location = new System.Drawing.Point(6, 22);
        greenhouseportbox.Name = "greenhouseportbox";
        greenhouseportbox.Size = new System.Drawing.Size(123, 23);
        greenhouseportbox.TabIndex = 0;
        // 
        // greenhouseip
        // 
        greenhouseip.Controls.Add(ipaddresstext);
        greenhouseip.Location = new System.Drawing.Point(6, 22);
        greenhouseip.Name = "greenhouseip";
        greenhouseip.Size = new System.Drawing.Size(135, 58);
        greenhouseip.TabIndex = 0;
        greenhouseip.TabStop = false;
        greenhouseip.Text = "Greenhouse IP";
        // 
        // ipaddresstext
        // 
        ipaddresstext.Location = new System.Drawing.Point(6, 22);
        ipaddresstext.Name = "ipaddresstext";
        ipaddresstext.Size = new System.Drawing.Size(123, 23);
        ipaddresstext.TabIndex = 0;
        // 
        // configurationbox
        // 
        configurationbox.Controls.Add(poweroptionsbox);
        configurationbox.Controls.Add(automaticwateringbox);
        configurationbox.Controls.Add(greenhouseLighting);
        configurationbox.Location = new System.Drawing.Point(12, 115);
        configurationbox.Name = "configurationbox";
        configurationbox.Size = new System.Drawing.Size(416, 267);
        configurationbox.TabIndex = 1;
        configurationbox.TabStop = false;
        configurationbox.Text = "Configuration";
        configurationbox.Enter += groupBox4_Enter_1;
        // 
        // poweroptionsbox
        // 
        poweroptionsbox.Controls.Add(waterpumpdebugbox);
        poweroptionsbox.Controls.Add(restartbutton);
        poweroptionsbox.Controls.Add(shutdownbutton);
        poweroptionsbox.Location = new System.Drawing.Point(6, 103);
        poweroptionsbox.Name = "poweroptionsbox";
        poweroptionsbox.Size = new System.Drawing.Size(196, 158);
        poweroptionsbox.TabIndex = 3;
        poweroptionsbox.TabStop = false;
        poweroptionsbox.Text = "Power Options";
        // 
        // waterpumpdebugbox
        // 
        waterpumpdebugbox.Controls.Add(waterpumpon);
        waterpumpdebugbox.Controls.Add(waterpumpoff);
        waterpumpdebugbox.Location = new System.Drawing.Point(6, 84);
        waterpumpdebugbox.Name = "waterpumpdebugbox";
        waterpumpdebugbox.Size = new System.Drawing.Size(184, 68);
        waterpumpdebugbox.TabIndex = 2;
        waterpumpdebugbox.TabStop = false;
        waterpumpdebugbox.Text = "Water Pump Debug";
        // 
        // waterpumpon
        // 
        waterpumpon.Location = new System.Drawing.Point(6, 37);
        waterpumpon.Name = "waterpumpon";
        waterpumpon.Size = new System.Drawing.Size(96, 25);
        waterpumpon.TabIndex = 3;
        waterpumpon.TabStop = true;
        waterpumpon.Text = "On";
        waterpumpon.UseVisualStyleBackColor = true;
        // 
        // waterpumpoff
        // 
        waterpumpoff.Location = new System.Drawing.Point(6, 18);
        waterpumpoff.Name = "waterpumpoff";
        waterpumpoff.Size = new System.Drawing.Size(96, 25);
        waterpumpoff.TabIndex = 2;
        waterpumpoff.TabStop = true;
        waterpumpoff.Text = "Off";
        waterpumpoff.UseVisualStyleBackColor = true;
        // 
        // restartbutton
        // 
        restartbutton.Location = new System.Drawing.Point(6, 53);
        restartbutton.Name = "restartbutton";
        restartbutton.Size = new System.Drawing.Size(184, 25);
        restartbutton.TabIndex = 1;
        restartbutton.Text = "Restart";
        restartbutton.UseVisualStyleBackColor = true;
        // 
        // shutdownbutton
        // 
        shutdownbutton.Location = new System.Drawing.Point(6, 22);
        shutdownbutton.Name = "shutdownbutton";
        shutdownbutton.Size = new System.Drawing.Size(184, 25);
        shutdownbutton.TabIndex = 0;
        shutdownbutton.Text = "Shutdown";
        shutdownbutton.UseVisualStyleBackColor = true;
        // 
        // automaticwateringbox
        // 
        automaticwateringbox.Controls.Add(wateringfrequencybox);
        automaticwateringbox.Controls.Add(dispenseamountbox);
        automaticwateringbox.Controls.Add(radioButton1);
        automaticwateringbox.Controls.Add(radioButton2);
        automaticwateringbox.Location = new System.Drawing.Point(208, 22);
        automaticwateringbox.Name = "automaticwateringbox";
        automaticwateringbox.Size = new System.Drawing.Size(202, 239);
        automaticwateringbox.TabIndex = 2;
        automaticwateringbox.TabStop = false;
        automaticwateringbox.Text = "Automating Watering";
        // 
        // wateringfrequencybox
        // 
        wateringfrequencybox.Controls.Add(waterfreqlabel);
        wateringfrequencybox.Controls.Add(waterfrequency);
        wateringfrequencybox.Location = new System.Drawing.Point(6, 154);
        wateringfrequencybox.Name = "wateringfrequencybox";
        wateringfrequencybox.Size = new System.Drawing.Size(190, 79);
        wateringfrequencybox.TabIndex = 3;
        wateringfrequencybox.TabStop = false;
        wateringfrequencybox.Text = "Watering Frequency";
        // 
        // waterfreqlabel
        // 
        waterfreqlabel.Location = new System.Drawing.Point(72, 19);
        waterfreqlabel.Name = "waterfreqlabel";
        waterfreqlabel.Size = new System.Drawing.Size(34, 12);
        waterfreqlabel.TabIndex = 1;
        waterfreqlabel.Text = "label";
        // 
        // waterfrequency
        // 
        waterfrequency.AllowDrop = true;
        waterfrequency.CausesValidation = false;
        waterfrequency.Dock = System.Windows.Forms.DockStyle.Bottom;
        waterfrequency.LargeChange = 1;
        waterfrequency.Location = new System.Drawing.Point(3, 31);
        waterfrequency.Maximum = 48;
        waterfrequency.Minimum = 1;
        waterfrequency.Name = "waterfrequency";
        waterfrequency.Size = new System.Drawing.Size(184, 45);
        waterfrequency.TabIndex = 0;
        waterfrequency.Value = 1;
        // 
        // dispenseamountbox
        // 
        dispenseamountbox.Controls.Add(dispenseamountlabel);
        dispenseamountbox.Controls.Add(dispenseamount);
        dispenseamountbox.Location = new System.Drawing.Point(6, 72);
        dispenseamountbox.Name = "dispenseamountbox";
        dispenseamountbox.Size = new System.Drawing.Size(190, 79);
        dispenseamountbox.TabIndex = 2;
        dispenseamountbox.TabStop = false;
        dispenseamountbox.Text = "Dispense Amount";
        // 
        // dispenseamountlabel
        // 
        dispenseamountlabel.Location = new System.Drawing.Point(72, 19);
        dispenseamountlabel.Name = "dispenseamountlabel";
        dispenseamountlabel.Size = new System.Drawing.Size(34, 12);
        dispenseamountlabel.TabIndex = 2;
        dispenseamountlabel.Text = "label2";
        // 
        // dispenseamount
        // 
        dispenseamount.AllowDrop = true;
        dispenseamount.CausesValidation = false;
        dispenseamount.Dock = System.Windows.Forms.DockStyle.Bottom;
        dispenseamount.LargeChange = 1;
        dispenseamount.Location = new System.Drawing.Point(3, 31);
        dispenseamount.Maximum = 60;
        dispenseamount.Minimum = 1;
        dispenseamount.Name = "dispenseamount";
        dispenseamount.Size = new System.Drawing.Size(184, 45);
        dispenseamount.TabIndex = 0;
        dispenseamount.Value = 1;
        // 
        // radioButton1
        // 
        radioButton1.Location = new System.Drawing.Point(6, 41);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new System.Drawing.Size(96, 25);
        radioButton1.TabIndex = 1;
        radioButton1.TabStop = true;
        radioButton1.Text = "On";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.Location = new System.Drawing.Point(6, 22);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new System.Drawing.Size(96, 25);
        radioButton2.TabIndex = 0;
        radioButton2.TabStop = true;
        radioButton2.Text = "Off";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // greenhouseLighting
        // 
        greenhouseLighting.Controls.Add(ghouselightingon);
        greenhouseLighting.Controls.Add(ghouselightingoff);
        greenhouseLighting.Location = new System.Drawing.Point(6, 22);
        greenhouseLighting.Name = "greenhouseLighting";
        greenhouseLighting.Size = new System.Drawing.Size(196, 75);
        greenhouseLighting.TabIndex = 0;
        greenhouseLighting.TabStop = false;
        greenhouseLighting.Text = "Greenhouse Lighting";
        // 
        // ghouselightingon
        // 
        ghouselightingon.Location = new System.Drawing.Point(6, 41);
        ghouselightingon.Name = "ghouselightingon";
        ghouselightingon.Size = new System.Drawing.Size(96, 25);
        ghouselightingon.TabIndex = 1;
        ghouselightingon.TabStop = true;
        ghouselightingon.Text = "On";
        ghouselightingon.UseVisualStyleBackColor = true;
        // 
        // ghouselightingoff
        // 
        ghouselightingoff.Location = new System.Drawing.Point(6, 22);
        ghouselightingoff.Name = "ghouselightingoff";
        ghouselightingoff.Size = new System.Drawing.Size(96, 25);
        ghouselightingoff.TabIndex = 0;
        ghouselightingoff.TabStop = true;
        ghouselightingoff.Text = "Off";
        ghouselightingoff.UseVisualStyleBackColor = true;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(441, 395);
        Controls.Add(configurationbox);
        Controls.Add(connection);
        ForeColor = System.Drawing.SystemColors.ControlText;
        Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "Greenhouse Control FRM - Disconnected.";
        Load += MainWindow_Load;
        connection.ResumeLayout(false);
        greenhouseport.ResumeLayout(false);
        greenhouseport.PerformLayout();
        greenhouseip.ResumeLayout(false);
        greenhouseip.PerformLayout();
        configurationbox.ResumeLayout(false);
        poweroptionsbox.ResumeLayout(false);
        waterpumpdebugbox.ResumeLayout(false);
        automaticwateringbox.ResumeLayout(false);
        wateringfrequencybox.ResumeLayout(false);
        wateringfrequencybox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)waterfrequency).EndInit();
        dispenseamountbox.ResumeLayout(false);
        dispenseamountbox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dispenseamount).EndInit();
        greenhouseLighting.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.RadioButton waterpumpon;
    private System.Windows.Forms.RadioButton waterpumpoff;

    private System.Windows.Forms.Button shutdownbutton;
    private System.Windows.Forms.Button restartbutton;
    private System.Windows.Forms.GroupBox waterpumpdebugbox;

    private System.Windows.Forms.GroupBox poweroptionsbox;

    private System.Windows.Forms.Label waterfreqlabel;
    private System.Windows.Forms.Label dispenseamountlabel;

    private System.Windows.Forms.GroupBox wateringfrequencybox;
    private System.Windows.Forms.TrackBar waterfrequency;

    private System.Windows.Forms.GroupBox automaticwateringbox;
    private System.Windows.Forms.GroupBox dispenseamountbox;
    private System.Windows.Forms.TrackBar dispenseamount;

    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.RadioButton radioButton2;

    private System.Windows.Forms.RadioButton ghouselightingoff;
    private System.Windows.Forms.RadioButton ghouselightingon;

    private System.Windows.Forms.GroupBox configurationbox;

    private System.Windows.Forms.Button connectbutton;

    private System.Windows.Forms.TextBox ipaddresstext;
    private System.Windows.Forms.TextBox greenhouseportbox;
    private System.Windows.Forms.GroupBox greenhouseport;

    private System.Windows.Forms.GroupBox greenhouseip;

    private System.Windows.Forms.GroupBox greenhouseLighting;

    private System.Windows.Forms.GroupBox connection;

    #endregion
}