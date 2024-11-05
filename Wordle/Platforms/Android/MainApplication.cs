using Android.App;
using Android.Content.Res;
using Android.Runtime;
using Android.Views;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace Wordle
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            //Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Entry), (handler, view) =>
            //{
            //    if (view is Entry)
            //    {
            //        // Tar bort underline men omöjliggör att ändra bakgrundsfärg
            //        handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.Transparent);
            //    }
            //});
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
