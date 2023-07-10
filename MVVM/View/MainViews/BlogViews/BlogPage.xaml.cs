using YouDo.MVVM.Model.MainModels.BlogModels;
using YouDo.MVVM.ViewModel.MainViewModels.BlogViewModels;

namespace YouDo.MVVM.View.MainViews.BlogViews;

public partial class BlogPage : ContentPage {
	public BlogPage(BlogViewModel viewModel) {
		InitializeComponent();
		BindingContext = viewModel;
	}
}