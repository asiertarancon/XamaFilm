using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : TabbedPage
    {
        public HomeView ()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }
    }
}