using YouDo.MVVM.ViewModel;
using System.Diagnostics;

namespace YouDo.MVVM.View;

public partial class EntrancePage : ContentPage {
	public EntrancePage(EntrancePageViewModel viewModel) {
		InitializeComponent();
		BindingContext = viewModel;
	}
}