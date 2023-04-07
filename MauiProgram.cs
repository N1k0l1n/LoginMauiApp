using LoginApp.Pages;
using LoginApp.ViewModels;

namespace LoginApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<Dashboard>();
        builder.Services.AddSingleton<AboutPage>();


        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<AppShellViewModel>();

        return builder.Build();
	}
}
