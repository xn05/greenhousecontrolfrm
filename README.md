# Greenhouse Control FRM

WinForms client that connects to the greenhouse controller over TCP and sends/receives settings.

## Run

- Open `Greenhouse Control FRM.slnx` in Rider or Visual Studio.
- Build and run the `Greenhouse Control FRM` project.

## Manual test harness

The UI acts as the manual test harness. Connect to a running controller, then try:

- Lighting On/Off
- Auto-watering On/Off
- Adjusting dispense seconds and frequency hours
- Pump On/Off
- Shutdown/Restart

Incoming lines of the form `SETTINGS {json}` will update the UI state.

