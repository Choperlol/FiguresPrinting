using FiguresPrinting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresPrinting.Services
{
    public interface IRandomizeService
    {
        public void DoWork(int tabNumber);
    }
}
