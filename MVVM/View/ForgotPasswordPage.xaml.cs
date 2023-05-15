using YouDo.MVVM.ViewModel;
using System.Diagnostics;

namespace YouDo.MVVM.View;

public partial class ForgotPasswordPage : ContentPage {
	public ForgotPasswordPage(EntrancePageViewModel viewModel) {
		InitializeComponent();
		BindingContext = viewModel;
	}
}