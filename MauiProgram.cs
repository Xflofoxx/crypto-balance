using Microsoft.Extensions.Logging;

namespace crypto_balance
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
                    fonts.AddFont("Font Awesome 5 Brands-Regular-400.otf", "Fontawesome-brands-regular");
                    fonts.AddFont("Font Awesome 5 Duotone-Solid-900.otf", "Fontawesome-duotone-solid");
                    fonts.AddFont("Font Awesome 5 Pro-Light-300.otf", "Fontawesome-light");
                    fonts.AddFont("Font Awesome 5 Pro-Regular-400.otf", "Fontawesome-regular");
                    fonts.AddFont("Font Awesome 5 Pro-Solid-900.otf", "Fontawesome-solid");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
