using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MauiSkia;

//STEP 1
//https://www.nuget.org/packages/SkiaSharp.Views.Maui.Controls/2.88.1?_src=template
//https://www.nuget.org/packages/CSharpMath.SkiaSharp/0.5.1?_src=template

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp()	// STEP 2
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		return builder.Build();
	}
}
