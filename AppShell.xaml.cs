using YouDo.MVVM.View;

namespace YouDo;

public partial class AppShell : Shell {
	public AppShell() {
		InitializeComponent();

		Routing.RegisterRoute(nameof(ForgotPasswordPage), typeof(ForgotPasswordPage));
        Routing.RegisterRoute(nameof(EntrancePage), typeof(EntrancePage));
    }
}
