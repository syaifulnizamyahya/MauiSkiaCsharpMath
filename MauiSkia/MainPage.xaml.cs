using SkiaSharp;
using SkiaSharp.Views.Maui;

namespace MauiSkia;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	//STEP 4
	void OnPaintSurface(object sender, SKPaintSurfaceEventArgs args)
	{
		SKImageInfo info = args.Info;
		SKSurface surface = args.Surface;
		SKCanvas canvas = surface.Canvas;

		canvas.Clear();

		var painter = new CSharpMath.SkiaSharp.MathPainter();
		painter.FontSize = 40;
		painter.LaTeX = @"\frac\sqrt23";
		painter.Draw(canvas);

	}
}

