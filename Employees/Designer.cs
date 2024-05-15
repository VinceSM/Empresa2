using Empresa2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Employees
{
    public class Designer : IEmployee
    {
        public string doWork()
        { 
            string desc = "Diseñador: El diseñador crea interfaces de usuario y experiencias de usuario.";
            return desc.ToString();
        }
    }
}
