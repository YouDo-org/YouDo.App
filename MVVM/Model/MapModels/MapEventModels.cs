using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouDo.MVVM.Model.MainModels;
using YouDo.Resources.Localization;

namespace YouDo.MVVM.Model.MapModels {

    public partial class MapImage : ObservableObject{

        [ObservableProperty]
        private string imageUrl;
    }

    public partial class MapEventModels : ObservableObject{
        // TODO: ADD SHARE SYSTEM

        [ObservableProperty]
        private string eventName;

        [ObservableProperty]
        private string eventType;

        [ObservableProperty]
        private bool openCloseState;

        [ObservableProperty]
        private int likes = 0;

        public string OpenClose { 
            get {
                OpenCloseState = new DateTime(1, 1, 1, DateTime.Now.Hour, DateTime.Now.Minute, 0, 0, System.Globalization.Calendar.CurrentEra) > _closingTime;
                return OpenCloseState ?  "Open" : "Close";
            }
            set { } 
        }

        public string ClosingTime {
            get => $"{AppResource.ClosingTime} {_closingTime.Hour}:{_closingTime.Minute}";
        }

        private DateTime _closingTime;

        [ObservableProperty]
        bool commentVisibility = false;

        [ObservableProperty]
        ObservableCollection<CommentModule> comments;


        [ObservableProperty]
        private ObservableCollection<MapImage> images = new();

        public MapEventModels(string _eventName, string _eventType, DateTime closingTime) {
            EventName = _eventName;
            EventType = _eventType;

            _closingTime = closingTime;
            SetProperty(ref _closingTime, closingTime);

            for (int i = 0; i < 5; i++) {
                images.Add(new MapImage { ImageUrl = "screenshot" });
            }

            comments = new ObservableCollection<CommentModule> {
                new CommentModule("Alex", "Developer", "Nice Bro !!!", DateTime.Now, "userimage.png"),
                new CommentModule("Alice", "Writer", "O yeah", new DateTime(2023, 7, 10, 18, 5, 0), "userimage.png"),
                new CommentModule("Jim", "Editor","Thanks", new DateTime(2023, 7, 10), "userimage.png")
            };
        }

        [RelayCommand]
        private void Like() {
            // TODO: ADD LIKE
        }

        [RelayCommand]
        private void OpenProfile() {
            // TODO: ADD NAVIGATION TO PROFILE
        }

        [RelayCommand]
        void ChangeCommentVisibility() {
            CommentVisibility = !CommentVisibility;
        }

    }
}
