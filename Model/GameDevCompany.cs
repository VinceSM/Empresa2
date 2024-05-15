using Empresa2.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Model
{
    internal class GameDevCompany : Company
    {
        public new List<string> getEmployees()
        {
            List<string> employees = new List<string>();

            Employees.Artist artist = new Employees.Artist();
            Employees.Designer designer = new Employees.Designer();

            employees.Add(artist.doWork());
            employees.Add(designer.doWork());

            return employees;
        }

        public new void CreateSoftware()
        { 
            throw new NotImplementedException(); 
        }
    }
}
