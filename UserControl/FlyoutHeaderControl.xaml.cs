namespace LoginApp.UserControl;

public partial class FlyoutHeaderControl : ContentPage
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if(App.UserInfo != null)
		{
			lblUserName.Text ="Logged in as: " + App.UserInfo.UserName;
			lblUserEmail.Text = App.UserInfo.UserName; //Optionaly use Email from Email
		}
	}
}