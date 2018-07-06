using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentPage
    {
        public ListView ListView;

        public MenuView()
        {
            InitializeComponent();

            BindingContext = new MasterViewMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterViewMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterViewMenuItem> MenuItems { get; set; }
            
            public MasterViewMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterViewMenuItem>(new[]
                {
                    new MasterViewMenuItem { Id = 0, Title = "Page 1" },
                    new MasterViewMenuItem { Id = 1, Title = "Page 2" },
                    new MasterViewMenuItem { Id = 2, Title = "Page 3" },
                    new MasterViewMenuItem { Id = 3, Title = "Page 4" },
                    new MasterViewMenuItem { Id = 4, Title = "Page 5" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}