using GroupAssignment2.Code;
using Microsoft.Extensions.Logging;

namespace GroupAssignment2
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
                });

            builder.Services.AddMauiBlazorWebView();

			builder.Services.AddSingleton<Code.AirportClass>();
			builder.Services.AddSingleton<Code.FlightClass>();
            builder.Services.AddSingleton<Code.Reservation>();


#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
