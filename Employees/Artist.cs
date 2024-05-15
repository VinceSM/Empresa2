using Empresa2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Employees
{
    public class Artist : IEmployee
    {
        public string doWork()
        {
            string desc = "Artista: El artista crea arte conceptual y diseña gráficos.";
            return desc.ToString();
        }
    }
}
