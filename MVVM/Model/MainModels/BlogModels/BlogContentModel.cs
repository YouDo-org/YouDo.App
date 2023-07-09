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
    }
}
