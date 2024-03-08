using MauiAndroidKeyboardIssueReproduction.Platforms.Android.Handlers;
using Microsoft.Maui.Handlers;
#if ANDROID
namespace MauiAndroidKeyboardIssueReproduction.Handlers;

public partial class DecimalEntryHandler
{
    private static void SetKeyboard(IEntryHandler handler, IEntry entry)
    {
        handler.PlatformView.KeyListener = new NumericKeyListener(handler.PlatformView.InputType);
    }
}
#endif