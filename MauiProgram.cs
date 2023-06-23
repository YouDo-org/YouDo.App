using YouDo.MVVM.Model;
using YouDo.MVVM.View;
using YouDo.MVVM.ViewModel;
using Microsoft.Extensions.Logging;

using YouDo.MVVM.ViewModel.MainViewModels;
using YouDo.MVVM.View.MainViews;

using YouDo.MVVM.ViewModel.EntranceViewModels;
using YouDo.MVVM.View.EntranceView;

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
                fonts.AddFont("Pacifico-Regular.tff", "PacificoRegular");
				fonts.AddFont("Lobster-Regular.ttf", "LobsterRegular");
            })
            .UseMauiMaps(); ;

#if DEBUG
		builder.Logging.AddDebug();
#endif
		
        builder.Services.AddSingleton<EntrancePage>();
        builder.Services.AddTransient<ForgotPasswordPage>();
        builder.Services.AddTransient<CreateNewAccountPage>();
        
        builder.Services.AddTransient<MapPage>();
        builder.Services.AddTransient<BlogPage>();
        builder.Services.AddTransient<CampaignsPage>();
        builder.Services.AddTransient<CreatePage>();
        builder.Services.AddTransient<EventsPage>();
        builder.Services.AddTransient<ProfilePage>();

        builder.Services.AddSingleton<EntrancePageViewModel>();
        builder.Services.AddTransient<ForgotPasswordViewModel>();
        builder.Services.AddTransient<CreateNewAccountViewModel>();
        
		builder.Services.AddTransient<MapViewModel>();
        builder.Services.AddTransient<BlogViewModel>();
        builder.Services.AddTransient<CampaignsViewModel>();
        builder.Services.AddTransient<CreateViewModel>();
        builder.Services.AddTransient<EventsViewModel>();
        builder.Services.AddTransient<ProfileViewModel>();

        return builder.Build();
	}
}
