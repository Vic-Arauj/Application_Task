using Application_Task.View;
using Microsoft.Maui.Platform;

namespace Application_Task
{
    public partial class App : Application
    {
        public App()
        {
            CustomHandler();

            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
        }

        private void CustomHandler()
        {
            EntryNoBorder();
            DatePickerNoBorder();
        }

        private static void EntryNoBorder()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
#if ANDROID
                //Android
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif

#if IOS || MACCATALYST
			//Ios//Mac
			handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif

#if WINDOWS
			//Windows
			handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }
        private static void DatePickerNoBorder()
        {
            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
#if ANDROID
                //Android
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#endif

#if IOS || MACCATALYST
			//Ios//Mac
			handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
            handler.PlatformView.Layer.BorderWidth = 0;
#endif

#if WINDOWS
			//Windows
			handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }
    }
}

    