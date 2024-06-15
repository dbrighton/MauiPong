using Fluxor.Blazor.Web.ReduxDevTools;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using MauiPong.Components.Pages.Pong.Store;

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


            // Load the appsettings.json file
            // var config = new ConfigurationBuilder()
            //     .SetBasePath(Directory.GetCurrentDirectory())
            //     .AddJsonFile("appsetting.json")
            //     .Build();

           // builder.Configuration.AddConfiguration(config);

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
           // builder.Services.AddSingleton(new PongState());
            // builder.Services.AddFluxor(opts =>
            //     {
            //         // opts.ScanAssemblies(typeof(PongState).Assembly);
            //         // opts.ScanAssemblies(typeof(PongGameFeature).Assembly);
            //         // opts.ScanAssemblies(typeof(MauiApp).Assembly);
            //         opts.UseReduxDevTools();
            //     }
            // );

            return builder.Build();
        }
    }
}
