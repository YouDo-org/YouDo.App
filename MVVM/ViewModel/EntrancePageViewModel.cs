using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YouDo.MVVM.Model;
using YouDo.MVVM.View;
using YouDo.Resources.Localization;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace YouDo.MVVM.ViewModel;
public partial class EntrancePageViewModel : BaseViewModel {

    [ObservableProperty]
    private EntrancePageModel model;

    public EntrancePageViewModel() { 
        
    }

    [RelayCommand]
    async Task MoveToForgotPasswordAsync() {
        await Shell.Current.GoToAsync(nameof(ForgotPasswordPage), true, new Dictionary<string, object> {
            {"viewModel", this }
        });
    }

    [RelayCommand]
    async Task MoveToEntranceAsync() {
        Debug.WriteLine("dafadsfasdfs");
        await Shell.Current.GoToAsync($"//{nameof(EntrancePage)}", true, new Dictionary<string, object> {
            {"viewModel", this }
        });
    }

    [RelayCommand]
    async Task MoveToCreateNewAccount() {
        await Shell.Current.GoToAsync($"//{nameof(CreateNewAccountPage)}", true, new Dictionary<string, object> {
            {"viewModel", this }
        });
    }


    [RelayCommand]
    async Task Login() {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        if (accessType == NetworkAccess.Internet) {
            // Login Operation Here
        } else {
            await Shell.Current.DisplayAlert(AppResource.InternetConnection, AppResource.InternetConnectionMessage, AppResource.InternetConnectionCancel);
            IsBusy = true;
        }
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
    }

    [RelayCommand]
    async Task ChangePassword() {
        NetworkAccess accessType = Connectivity.Current.NetworkAccess;

        if (accessType == NetworkAccess.Internet) {
            // Change Password Operation Here
        } else {
            await Shell.Current.DisplayAlert(AppResource.InternetConnection, AppResource.InternetConnectionMessage, AppResource.InternetConnectionCancel);
            IsBusy = true;
        }
    }

    public int CheckPasswordStrength() {
        int score = 0;

        Debug.WriteLine(Model);
        
        if (Model.Password.Length >= 8)
            score++;
        if (Model.Password.Length >= 12)
            score++;
        if (Regex.Match(Model.Password, @"/\d+/", RegexOptions.ECMAScript).Success)
            score++;
        if (Regex.Match(Model.Password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
          Regex.Match(Model.Password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
            score++;
        if (Regex.Match(Model.Password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
            score++;

        return score;
    }
}

