using YouDo.MVVM.ViewModel.MainViewModels;

namespace YouDo.MVVM.View.MainViews;

public partial class BlogPage : ContentPage {
	public BlogPage(BlogViewModel viewModel) {
		InitializeComponent();
		BindingContext = viewModel;
	}
}