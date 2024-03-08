using Microsoft.Maui.Handlers;

#if ANDROID
namespace MauiAndroidKeyboardIssueReproduction.Handlers;

public partial class DecimalEntryHandler : EntryHandler
{
    public DecimalEntryHandler()
    {
        Mapper.AppendToMapping(nameof(IEntry.Keyboard), SetKeyboard);
    }
}

#endif