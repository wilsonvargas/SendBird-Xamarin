using FormsChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsChat.Views
{
    public partial class MainPage : ContentPage
    {

        MainViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = vm = new MainViewModel();
            vm.Navigation = Navigation;
        }
    }
}
