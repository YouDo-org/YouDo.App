using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Text.RegularExpressions;
using YouDo.MVVM.View.EntranceView;
using YouDo.MVVM.View.MainViews;
using YouDo.Resources.Localization;

namespace YouDo.MVVM.ViewModel.EntranceViewModels;

[QueryProperty("UserInfoModel", "UserInfoModel")]
public partial class CreateNewAccountViewModel : BaseViewModel{

    [ObservableProperty]
    private Model.EntranceModels.UserInfoModel userInfoModel;

    [RelayCommand]
    async Task MoveToEntranceAsync() {
        await Shell.Current.GoToAsync($"../../{nameof(EntrancePage)}", true);
    }

    [RelayCommand]
    async Task Register() {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;
        if (accessType == NetworkAccess.Internet) {
            // Register Operation Here
        } else {
            await Shell.Current.DisplayAlert(AppResource.InternetConnection, AppResource.InternetConnectionMessage, AppResource.InternetConnectionCancel);
            IsBusy = true;
        }

        bool navigate = await CheckPasswordStrengthAsync();

        if (navigate) {
            /*MapPage mapPage = new MapPage();
            mapPage.BindingContext = this;

            await Application.Current.MainPage.Navigation.PushAsync(mapPage);*/
            await Shell.Current.GoToAsync(nameof(MapPage), true);
        }
    }

    public async Task<bool> CheckPasswordStrengthAsync() {

        var hasNumber = new Regex(@"[0-9]+");
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasMinimum8Chars = new Regex(@".{8,}");

        Debug.WriteLine("------------------");
        Debug.WriteLine(UserInfoModel);
        Debug.WriteLine("------------------");

        if (UserInfoModel.Password != UserInfoModel.Password2) {
            await Shell.Current.DisplayAlert("Password", "Passwords Doesn't Match", "OK");
            return false;
        } else if (!hasNumber.IsMatch(UserInfoModel.Password)) {
            await Shell.Current.DisplayAlert("Password", "Password must contains a number", "OK");
            return false;
        } else if (!hasUpperChar.IsMatch(UserInfoModel.Password)) {
            await Shell.Current.DisplayAlert("Password", "Password must contains an uppercase", "OK");
            return false;
        } else if (!hasMinimum8Chars.IsMatch(UserInfoModel.Password)) {
            await Shell.Current.DisplayAlert("Password", "Password must be at least 8 characters long", "OK");
            return false;
        }

        return true;
    }

}

