using System;

namespace FiguresPrinting.Models
{
    public class Square : Rectangle
    {
        private double _diagonal;
        public double Diagonal 
        {
            get => _diagonal;
            set 
            { 
                SetProperty(ref _diagonal, value);
                Height = Width = _diagonal / Math.Sqrt(2);
            }
        }

        public Square()
        {
            Diagonal = 142;
        }
    }
}
