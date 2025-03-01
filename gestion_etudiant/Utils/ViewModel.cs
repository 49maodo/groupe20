using System;
using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace gestion_etudiant.Utils
{
    internal class ViewModel
    {
        public ISeries[] Series { get; set; } = new ISeries[]
        {
            new ColumnSeries<double>
            {
                IsHoverable = false, // disables the series from the tooltips 
                Values = new double[] { 20, 20, 20, 20, 20, 20, 20 },
                Stroke = null,
                Fill = new SolidColorPaint(new SKColor(30, 30, 30, 30)),
                IgnoresBarPosition = true
            },
            new ColumnSeries<double>
            {
                Values = new double[] { 3, 10, 5, 3, 17, 3, 8 },
                Name = "note",
                Stroke = null,
                Fill = new SolidColorPaint(SKColors.CornflowerBlue),
                IgnoresBarPosition = true
            }
        };

        public ICartesianAxis[] YAxes { get; set; } = new ICartesianAxis[]
        {
            new Axis { MinLimit = 0, MaxLimit = 20 }
        };
        public ICartesianAxis[] XAxes { get; set; } = new ICartesianAxis[]
        { 
            new Axis { 
                Labels = new string[] {"a", "b","c","d","e","f","g","m","n"} 
            }
           
        };
    }
}
