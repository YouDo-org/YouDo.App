using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouDo.MVVM.Model.MainModels.BlogModels {

    public partial class BlogContentModel : ObservableObject {

        [ObservableProperty]
        public string userName = "";

        [ObservableProperty]
        public string userDefenition = "";

        [ObservableProperty]
        public string blogContent = "";

        [ObservableProperty]
        public Image userIcon;

        private DateTime releaseDate;
        public string time {
            get { return FormatDateTime(); }
            set { }
        }


        // public string time = DateTime.Now - ReleaseDate;

        public BlogContentModel(string username, string userdefenition, string blogcontent, DateTime releasedate, string userIconPath) {
            UserName = username;
            UserDefenition = userdefenition;
            BlogContent = blogcontent;
            releaseDate = releasedate;
            userIcon = new Image { Source = userIconPath };
        }

        public string FormatDateTime() {
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
                return $"{timeDifference.TotalDays/365} year";
            }
            return "";

        }

    }
}
