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

    [ObservableProperty]
    string position;

    [ObservableProperty]
    Location location;

    [ObservableProperty]
    string previewImage;

    public EventContentModule(string username, string userdefenition, string blogcontent, DateTime releasedate, string userIconPath, string position) :
    base(username, userdefenition, blogcontent, releasedate, userIconPath) {
        this.position = position;
    }


    [RelayCommand]
    private async Task NavigateToMap() {
        var location = new Location(47.645160, -122.1306032);
        var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

        try {
            await Map.Default.OpenAsync(location, options);
        } catch (Exception ex) {
            // No map application available to open
        }
    }
}

