using FormsChat.Helpers;
using FormsChat.Model;
using FormsChat.Views;
using SendBird;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsChat.ViewModels
{
    public class UserListViewModel : ViewModelBase
    {
        #region Properties
        public ObservableCollection<FormsChat.Model.User> Users { get; set; } = new ObservableCollection<FormsChat.Model.User>();
        public INavigation Navigation;
        #endregion

        public UserListViewModel()
        {
            if (Settings.UserId == "user1@mail.com")
            {
                Users.Add(new FormsChat.Model.User { Email = "user2@mail.com", Nickname = "Thomas" });
            }
            else if ((Settings.UserId == "user2@mail.com"))
            {
                Users.Add(new FormsChat.Model.User { Email = "user1@mail.com", Nickname = "Daniel" });
            }
        }

        public async void ConnectToChannel(FormsChat.Model.User user, List<string> users) {
            GroupChannel group = null;
            IsBusy = true;
            
            GroupChannel.CreateChannelWithUserIds(users, true, (GroupChannel groupChannel, SendBirdException e) => {
                if (e != null)
                {
                    // Error.
                    return;
                }
                group = groupChannel;
            });
            await Task.Delay(3000);
            IsBusy = false;
            await Navigation.PushAsync(new ChatPage(user, group));
        }

    }
}
