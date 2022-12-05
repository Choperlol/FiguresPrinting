using FiguresPrinting.Models;
using FiguresPrinting.Services;
using FiguresPrinting.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;

namespace FiguresPrinting
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<Circle>();
            containerRegistry.RegisterSingleton<Square>();
            containerRegistry.RegisterSingleton<Triangle>();
            containerRegistry.RegisterSingleton<Rectangle>();
            containerRegistry.RegisterSingleton<IRandomizeService, RandomizeService>();
        }
    }
}
