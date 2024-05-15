using Empresa2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Employees
{
    public class Programmer : IEmployee
    {
        public string doWork()
        {
            string desc = "Programador: El programador escribe y mantiene el código del software.";
            return desc.ToString();
        }
    }
}
