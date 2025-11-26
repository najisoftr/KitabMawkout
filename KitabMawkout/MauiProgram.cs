using KitabMawkout.Data.MyData;
using KitabMawkout.Data.MyData.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Radzen;
using System;

namespace KitabMawkout;

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
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

		builder.Services.AddRadzenComponents();
		builder.Services.AddDbContext<MyDbContext>();
		builder.Services.AddSingleton<MySettingsRepo>();

		var app= builder.Build();

        // Apply migrations at startup
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<MyDbContext>();
            db.Database.Migrate();
        }

        return app;

    }
}
