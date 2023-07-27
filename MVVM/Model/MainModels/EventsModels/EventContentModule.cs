using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouDo.MVVM.Model.MainModels;

namespace YouDo.MVVM.Model.MainModels;

public partial class EventContentModule : BlogContentModel {

    Location location;

    [ObservableProperty]
    string positionString;

    public EventContentModule(string username, string userdefenition, string blogcontent, DateTime releasedate, string userIconPath, string positionText, Location location) :
    base(username, userdefenition, blogcontent, releasedate, userIconPath) {
        PositionString = positionText;
        this.location = location;

    }


    [RelayCommand]
    private async Task NavigateToMap() {
        var options = new MapLaunchOptions { Name = PositionString };

        try {
            await Map.Default.OpenAsync(location, options);
        } catch (Exception ex) {
            // No map application available to open
        }
    }
}

