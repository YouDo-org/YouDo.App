using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouDo.MVVM.Model.MapModels;

namespace YouDo.MVVM.ViewModel.MainViewModels;
public partial class MapViewModel : BaseViewModel {

    [ObservableProperty]
    private ObservableCollection<MapEventModels> mapEventModels = new();

    public MapViewModel() {
        mapEventModels.Add(new MapEventModels("Event Name 1", "Type1", new DateTime(1, 1, 1, 10, 20, 0, Calendar.CurrentEra)));
        mapEventModels.Add(new MapEventModels("Event Name 2", "Type2", new DateTime(1, 1, 1, 21, 30, 0, Calendar.CurrentEra)));
        mapEventModels.Add(new MapEventModels("Event Name 3", "Type3", new DateTime(1, 1, 1, 17, 50, 0, Calendar.CurrentEra)));
        mapEventModels.Add(new MapEventModels("Event Name 4", "Type4", new DateTime(1, 1, 1, 18, 40, 0, Calendar.CurrentEra)));
    }                                                                               
}

