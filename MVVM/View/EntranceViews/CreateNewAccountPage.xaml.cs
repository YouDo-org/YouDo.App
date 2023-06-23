using YouDo.MVVM.ViewModel;
using YouDo.MVVM.ViewModel.EntranceViewModels;

namespace YouDo.MVVM.View.EntranceView;

public partial class CreateNewAccountPage : ContentPage {

    public CreateNewAccountPage(CreateNewAccountViewModel viewModel) {
        InitializeComponent();
        BindingContext = viewModel;
    }
}