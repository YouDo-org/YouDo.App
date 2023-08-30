using YouDo.MVVM.ViewModel.MainViewModels;

namespace YouDo.MVVM.View.MainViews;

public partial class CreatePage : ContentPage {
	public CreatePage(CreateViewModel viewModel) {
		InitializeComponent();
        BindingContext = viewModel;
    }
}