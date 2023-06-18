using YouDo.MVVM.ViewModel;

namespace YouDo.MVVM.View;

public partial class CreateNewAccountPage : ContentPage {

    public CreateNewAccountPage(CreateNewAccountViewModel viewModel) {
        InitializeComponent();
        BindingContext = viewModel;
    }
}