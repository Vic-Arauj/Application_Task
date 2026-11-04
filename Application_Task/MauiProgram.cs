using Microsoft.Extensions.Logging;
#if ANDROID
using Android.Runtime;
#endif

namespace Application_Task
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

#if ANDROID
            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                Android.Util.Log.Error("APP", ex?.ToString());
                if (ex?.InnerException != null)
                    Android.Util.Log.Error("APP", "Inner: " + ex.InnerException.ToString());
            };

            AndroidEnvironment.UnhandledExceptionRaiser += (sender, args) =>
            {
                Android.Util.Log.Error("APP", args.Exception.ToString());
                if (args.Exception.InnerException != null)
                    Android.Util.Log.Error("APP", "Inner: " + args.Exception.InnerException.ToString());
            };
#endif
            return builder.Build();
        }
    }
}
