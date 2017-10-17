using FormsChat.Helpers;
using FormsChat.Views;
using SendBird;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FormsChat.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        #region Properties

        private string email;

        public string Email
        {
            get { return email; }
            set { SetProperty(ref email, value); }
        }

        private string nickname;

        public string Nickname
        {
            get { return nickname; }
            set { SetProperty(ref nickname, value); }
        }


        public ICommand CommandConnect { get; set; }
        public INavigation Navigation { get; set; }
        #endregion

        public MainViewModel()
        {
            MessageError = "No connected";
            CommandConnect = new Command(Connect);
        }

        async void Connect() {
            
            SendBirdClient.Connect(Email, (User user, SendBirdException e) =>
            {
                if (e != null)
                {
                    MessageError = e.Message;
                    return;
                }

                SendBirdClient.UpdateCurrentUserInfo(Nickname, "", (SendBirdException e1) =>
                {
                    if (e1 != null)
                    {
                        MessageError = e1.Message;
                        return;
                    }
                });
            });
            MessageError = "Connected";
            Settings.IsLogin = true;
            Settings.UserId = Email;
            await Navigation.PushAsync(new UserListPage());

        }

    }
}
