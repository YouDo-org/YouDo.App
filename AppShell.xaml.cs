using YouDo.MVVM.View;
using YouDo.MVVM.View.EntranceView;
using YouDo.MVVM.View.MainViews;
using YouDo.MVVM.View.MainViews.BlogViews;

namespace YouDo;

public partial class AppShell : Shell {
	public AppShell() {
		InitializeComponent();
        Routing.RegisterRoute(nameof(EntrancePage), typeof(EntrancePage));
        Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
        Routing.RegisterRoute(nameof(CreateNewAccountPage), typeof(CreateNewAccountPage));

        Routing.RegisterRoute(nameof(MapPage), typeof(MapPage));
        Routing.RegisterRoute(nameof(BlogPage), typeof(BlogPage));
        Routing.RegisterRoute(nameof(CampaignsPage), typeof(CampaignsPage));
        Routing.RegisterRoute(nameof(CreatePage), typeof(CreatePage));
        Routing.RegisterRoute(nameof(EventsPage), typeof(EventsPage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
    }
}
