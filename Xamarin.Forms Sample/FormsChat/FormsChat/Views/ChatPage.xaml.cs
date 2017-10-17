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
    public partial class ChatPage : ContentPage
    {
        ChatViewModel vm;
        static ChatPage instance = null;
        public static ChatPage CurrentActivity
        {
            get
            {
                return instance;
            }
        }
        public ChatPage(FormsChat.Model.User user, GroupChannel channel)
        {
            InitializeComponent();
            BindingContext = vm = new ChatViewModel();
            vm.Channel = channel;
            vm.Title = user.Nickname;
            vm.UserName = Settings.UserId;
            vm.Load();
            instance = this;
        }

        public void ScrollDown(UserMessage m)
        {
            list.ScrollTo(m, ScrollToPosition.End, true);
        }
    }
}