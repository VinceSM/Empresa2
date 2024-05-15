using Empresa2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Employees
{
    public class Tester : IEmployee
    {
        public string doWork()
        {
            string desc = "Tester: El tester prueba el software para asegurar la calidad del proyecto.";
            return desc.ToString();
        }
    }
}
