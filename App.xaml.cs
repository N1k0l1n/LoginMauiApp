using LoginApp.Models;

namespace LoginApp;

public partial class App : Application
{
	public static UserInfo UserInfo;
	public static string Token;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
