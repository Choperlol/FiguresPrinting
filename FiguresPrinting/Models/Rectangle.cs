namespace FiguresPrinting.Models
{
    public class Rectangle : Shape
    {
        private double _cornerRadius;
        public double CornerRaduis
        {
            get => _cornerRadius;
            set => SetProperty(ref _cornerRadius, value);
        }

        public Rectangle()
        {
            Height = 100;
            Width = 200;
        }
    }
}
