using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo.MVVM.Model.MainModels;

public partial class BaseContentModel : ObservableObject {

    [ObservableProperty]
    string userName = "";

    [ObservableProperty]
    string userDefenition = "";

    [ObservableProperty]
    Image userIcon;

    DateTime releaseDate;
    public string time {
        get { return FormatDateTime(); }
        set { }
    }

    public BaseContentModel(string username, string userdefenition, DateTime releasedate, string userIconPath) {
        UserName = username;
        UserDefenition = userdefenition;
        releaseDate = releasedate;
        userIcon = new Image { Source = userIconPath };
    }

    /// <summary>
    /// Converts releaseDate to a readable string to see how many days, hours, minutes ago the content was published
    /// </summary>
    /// <returns>Readable string</returns>
    private string FormatDateTime() {
        TimeSpan timeDifference = DateTime.Now - releaseDate;

        if (timeDifference.TotalMinutes < 1) {
            return "Now";
        } else if (timeDifference.TotalHours < 1) {
            return $"{timeDifference.Minutes} min";
        } else if (timeDifference.TotalDays < 1) {
            return $"{timeDifference.Hours} hour";
        } else if (timeDifference.TotalDays < 2) {
            return "Dün";
        } else if (timeDifference.TotalDays < 7) {
            return $"{timeDifference.Days} day";
        } else if (timeDifference.TotalDays > 365) {
            return $"{timeDifference.TotalDays / 365} year";
        }
        return "";

    }

}
