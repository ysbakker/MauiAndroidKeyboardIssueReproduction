# Android keyboard issue Reproduction

This should add a key listener to the Entry view:

```cs
handler.PlatformView.KeyListener = new NumericKeyListener(handler.PlatformView.InputType);
```

This is working in MAUI 8.0.3, but no longer works in 8.0.6.

Reproduce this by changing the SDK in `global.json`.

**Working SDK:** `8.0.100`

**Broken SDK:** `8.0.201`

Expected: a dialog should show up when pressing any key with the numeric input selected.