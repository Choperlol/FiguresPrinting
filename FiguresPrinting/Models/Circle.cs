namespace FiguresPrinting.Models
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get => _radius;
            set 
            {
                SetProperty(ref _radius, value);
                Height = Width = _radius * 2;
            } 
        }

        public Circle()
        {
            Radius = 50;
            IsVisible = true;
        }
    }
}
