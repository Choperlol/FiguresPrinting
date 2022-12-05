using FiguresPrinting.Models;
using System;

namespace FiguresPrinting.Services
{
    public class RandomizeService : IRandomizeService
    {
        private readonly Random _randomizer = new();
        private readonly Square _square;
        private readonly Triangle _triangle;
        private readonly Circle _circle;
        private readonly Rectangle _rectangle;

        public RandomizeService(Square square, Triangle triangle, Circle circle, Rectangle rectangle)
        {
            _circle = circle;
            _square = square;
            _triangle = triangle;
            _rectangle = rectangle;
        }

        public void DoWork(int tabNumber)
        {
            switch (tabNumber)
            {
                case 0:
                    RandomizeHeightAndWidth(_circle);
                    break;
                case 1:
                    RandomizeHeightAndWidth(_triangle);
                    break;
                case 2:
                    RandomizeHeightAndWidth(_square);
                    break;
                case 3:
                    RandomizeHeightAndWidth(_rectangle);
                    break;
                default:
                    break;
            }
        }

        private void RandomizeHeightAndWidth(Shape shape)
        {
            shape.Width = _randomizer.Next(200);
            shape.Height = _randomizer.Next(200);
            shape.TransformAngle = _randomizer.Next(180);

            if (shape is Square square)
                square.Diagonal = _randomizer.Next(150);
        }
    }
}
