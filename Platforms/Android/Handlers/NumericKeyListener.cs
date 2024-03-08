using Android.Text;
using Android.Text.Method;
using Android.Views;
using Google.Android.Material.Snackbar;

namespace MauiAndroidKeyboardIssueReproduction.Platforms.Android.Handlers;

public class NumericKeyListener : NumberKeyListener
{
    public override InputTypes InputType { get; }
    protected override char[] GetAcceptedChars() => "0123456789-,.".ToCharArray();

    public NumericKeyListener(InputTypes inputType)
    {
        InputType = inputType;
    }

    public override bool OnKeyDown(global::Android.Views.View? view, IEditable? content, Keycode keyCode, KeyEvent? e)
    {
        Application.Current.MainPage.DisplayAlert("OnKeyDown", string.Empty, "OK");
        return base.OnKeyDown(view, content, keyCode, e);
    }
}
