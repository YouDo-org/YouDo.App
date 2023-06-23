using YouDo.MVVM.ViewModel;
using System.Diagnostics;
using YouDo.MVVM.ViewModel.EntranceViewModels;

namespace YouDo.MVVM.View.EntranceView;

public partial class EntrancePage : ContentPage {
	public EntrancePage(EntrancePageViewModel viewModel) {
		InitializeComponent();
		BindingContext = viewModel;
	}
}