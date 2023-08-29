using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouDo.Resources.Localization;

namespace YouDo.MVVM.Model.MapModels {

    public partial class MapImage : ObservableObject{

        [ObservableProperty]
        private string imageUrl;
    }

    public partial class MapEventModels : ObservableObject{

        [ObservableProperty]
        private string eventName;

        [ObservableProperty]
        private string eventType;

        [ObservableProperty]
        private bool openCloseState;

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
        private ObservableCollection<MapImage> images = new();

        public MapEventModels(string _eventName, string _eventType, DateTime closingTime) {
            EventName = _eventName;
            EventType = _eventType;

            _closingTime = closingTime;
            SetProperty(ref _closingTime, closingTime);

            for (int i = 0; i < 5; i++) {
                images.Add(new MapImage { ImageUrl = "screenshot" });
            }
        }

    }
}
