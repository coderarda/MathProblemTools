using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using SkiaSharp;
using SkiaSharp.Internals;
using SkiaSharp.Views.Windows;
using System;

namespace MathProblemTools
{
    public partial class GraphPage : Page {
        public GraphPage() {
            InitializeComponent();
        }

        private bool clicked = false;

        private void DrawEquation(object sender, RoutedEventArgs e) {
            clicked = true;
        }

        private void OnCanvasPaintSurface(object sender, SKPaintSurfaceEventArgs e) {
            for (int i = 0; i < 4; i++) {
                e.Surface.Draw(e.Surface.Canvas, i, i, new SKPaint {
                    Color = SKColors.Blue,
                    Style = SKPaintStyle.Stroke,
                    StrokeWidth = 20,
                });
            }
        }
    }
}
