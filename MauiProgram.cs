using LoginApp.Pages;
using LoginApp.Services;
using LoginApp.ViewModels;
using Syncfusion.Maui.Core.Hosting;

namespace LoginApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
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
        builder.Services.AddSingleton<CallStatsViewModel>();
     
        return builder.Build();
	}
}
