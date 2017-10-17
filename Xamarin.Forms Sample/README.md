# FormsChat: [SendBird] (https://sendbird.com/) Chats Everywhere

Built with C# 6 features, you must be running VS 2015 or 2017 to compile.

The most awesome Chat app built in about 4 hours to showcase a sample of [Xamarin.Forms](https://www.xamarin.com/forms). 

In this sample Chat app we show awesome way to text to another user, including connect users to SendBird services, create a channel 1-1, all using a nice MVVM Style and nearly 100% code reuse.

This project uses [SendBird Plugin for Xamarin] (https://www.nuget.org/packages/Xam.Plugin.SendBird/)

In addition, this sample uses some components created by our community:

 - [Xam.Plugin.Settings](https://www.nuget.org/packages/Xam.Plugins.Settings/)
 - [Plugins.Forms.ButtonCircle] (https://www.nuget.org/packages/Plugins.Forms.ButtonCircle/)

Please check out our new version of SDK here. [SendBird .NET SDK](https://github.com/smilefam/SendBird-SDK-dotNET)

## Create a new SendBird application in Dashboard
The first thing you need to do is to log in to the [SendBird Dashboard](https://dashboard.sendbird.com/) and create a SendBird application. If you do not yet have an account, you can log in with Google, GitHub, or create a new account.

You should create one application per service, regardless of the platform. For example, an app released in both Android and iOS would require only one application to be created in the Dashboard.

All users within the same SendBird application are able to communicate with each other, across all platforms. This means users using iOS, Android, web clients, etc. can all chat with one another. However, users in different SendBird applications cannot talk to each other.

## Clone and Run

1. Clone FormsChat project from this repository.
2. Open the project which you want to run.
3. Add your App ID in [Resource.resx](FormsChat\FormsChat\Resources\Resource.resx) file.
4. Build and run it.


# Screenshot
![android](..\Screenshots-Xamarin.Forms\screenshot.png)