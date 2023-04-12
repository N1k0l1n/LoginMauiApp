using LoginApp.Models;

namespace LoginApp;

public partial class App : Application
{
	public static UserInfo UserInfo;
	public static string Token;
	public App()
	{
		InitializeComponent();
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTY4MTE5MEAzMjMxMmUzMTJlMzMzNUg2cHlwTXBlSE5Hd3VqWi9xUmpuK1dnZUNFekNyRk9tWXNYWlU3dGtibjA9");
		MainPage = new AppShell();
	}
}
