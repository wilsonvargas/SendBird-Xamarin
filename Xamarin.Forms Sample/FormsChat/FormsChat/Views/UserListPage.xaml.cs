using FormsChat.Helpers;
using FormsChat.Model;
using FormsChat.ViewModels;
using SendBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsChat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserListPage : ContentPage
    {
        UserListViewModel vm;

        public delegate void GroupHandler(string foo);
        public UserListPage()
        {
            InitializeComponent();
            BindingContext = vm = new UserListViewModel();
            vm.Navigation = Navigation;
        }

        private void lstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var user = (FormsChat.Model.User)e.SelectedItem;
            List<string> users = new List<string>() {
                Settings.UserId,
                user.Email
            };
            vm.ConnectToChannel(user, users);
        }
    }
}