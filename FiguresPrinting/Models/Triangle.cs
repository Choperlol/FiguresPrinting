using System.Windows;
using System.Windows.Media;

namespace FiguresPrinting.Models
{
    public class Triangle : Shape
    {
        private PointCollection? _points;
        public PointCollection? Points
        {
            get => _points;
            set => SetProperty(ref _points, value);
        }

        public Triangle() 
        {
            _points = new PointCollection()
            {
                new Point(0, 90),
                new Point(90, 0),
                new Point(90, 90)
            };

            TransformAngle = 90;
            Width = Height = 150;
        }
    }
}
