using Fluxor.Blazor.Web.ReduxDevTools;
using Microsoft.Extensions.Logging;

namespace MauiPong
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

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddFluxor(opts =>
                {
                    opts.ScanAssemblies(typeof(MauiApp).Assembly);
                    opts.UseReduxDevTools();
                }
            );

            return builder.Build();
        }
    }
}
