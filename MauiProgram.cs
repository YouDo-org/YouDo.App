using YouDo.MVVM.Model;
using YouDo.MVVM.View;
using YouDo.MVVM.ViewModel;
using Microsoft.Extensions.Logging;

namespace YouDo;

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
				fonts.AddFont("Roboto-Regular.tff", "RobotoRegular");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		
        builder.Services.AddSingleton<EntrancePage>();
        builder.Services.AddTransient<ForgotPasswordPage>();
        builder.Services.AddTransient<CreateNewAccountPage>();
        builder.Services.AddTransient<MapPage>();

        builder.Services.AddSingleton<EntrancePageViewModel>();
        builder.Services.AddTransient<ForgotPasswordViewModel>();
        builder.Services.AddTransient<CreateNewAccountViewModel>();
        builder.Services.AddTransient<MapViewmodel>();

        return builder.Build();
	}
}
