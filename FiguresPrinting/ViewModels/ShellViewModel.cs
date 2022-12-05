using FiguresPrinting.Models;
using FiguresPrinting.Services;
using ImTools;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;

namespace FiguresPrinting.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public Circle Circle { get; set; }
        public Rectangle Rectangle { get; set; }
        public Square Square { get; set; }
        public Triangle Triangle { get; set; }
        public DelegateCommand RandomizeCommand { get; private set; }
        public int CurrentTab { get; set; }

        private readonly IEnumerable<IRandomizeService> _services;

        public ShellViewModel(Circle circle, Rectangle rectangle, Square square, Triangle triangle, IEnumerable<IRandomizeService> services)
        {
            Circle = circle;
            Rectangle = rectangle;
            Square = square;
            Triangle = triangle;
            _services = services;

            RandomizeCommand = new(() => _services.FindFirst(service => service is RandomizeService).DoWork(CurrentTab));
        }
    }
}
