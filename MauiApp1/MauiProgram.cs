﻿using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiApp1.Data;

namespace MauiApp1;

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
		builder.Services.AddMasaBlazor();
		return builder.Build();
	}
}
