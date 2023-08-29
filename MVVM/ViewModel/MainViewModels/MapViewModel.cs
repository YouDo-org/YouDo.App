using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouDo.MVVM.Model.MapModels;

namespace YouDo.MVVM.ViewModel.MainViewModels;
public partial class MapViewModel : BaseViewModel {

    [ObservableProperty]
    private ObservableCollection<MapEventModels> mapEventModels = new ObservableCollection<MapEventModels>();

    public MapViewModel() {
        mapEventModels.Add(new MapEventModels());
        mapEventModels.Add(new MapEventModels());
        mapEventModels.Add(new MapEventModels());
        mapEventModels.Add(new MapEventModels());
    }
}

