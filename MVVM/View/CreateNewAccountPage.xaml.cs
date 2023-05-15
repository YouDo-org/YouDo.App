using YouDo.MVVM.ViewModel;
using Microsoft.Maui.Graphics;

namespace YouDo.MVVM.View;

public partial class CreateNewAccountPage : ContentPage {

    private EntrancePageViewModel viewModel;
	public CreateNewAccountPage(EntrancePageViewModel entrancePageViewModel) {
        InitializeComponent();
        viewModel = entrancePageViewModel;
        BindingContext = entrancePageViewModel;
    }

    public void CheckPasswordStrength(object sender, TextChangedEventArgs e) { // for register
        int score = viewModel.CheckPasswordStrength();

        if (score < 2) {
            Rect1.Fill = Colors.Red;
            Rect2.Fill = Colors.Red;
            Rect3.Fill = Colors.Red;
            Rect4.Fill = Colors.Red;
        } else if (score < 3) {
            Rect1.Fill = Colors.Orange;
            Rect2.Fill = Colors.Orange;
            Rect3.Fill = Colors.Orange;
            Rect4.Fill = Colors.Orange;
        } else if (score < 4) {
            Rect1.Fill = Colors.Yellow;
            Rect2.Fill = Colors.Yellow;
            Rect3.Fill = Colors.Yellow;
            Rect4.Fill = Colors.Yellow;
        } else if (score < 5) {
            Rect1.Fill = Colors.Green;
            Rect2.Fill = Colors.Green;
            Rect3.Fill = Colors.Green;
            Rect4.Fill = Colors.Green;
        }
    }
}