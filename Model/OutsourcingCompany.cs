using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Model
{
    internal class OutsourcingCompany : Company
    {
        public new List<string> getEmployees()
        {
            List<string> employees = new List<string>();

            Employees.Programmer programmer = new Employees.Programmer();
            Employees.Tester tester = new Employees.Tester();

            employees.Add(programmer.doWork());
            employees.Add(tester.doWork());

            return employees;
        }

        public new void CreateSoftware()
        { 
            throw new NotImplementedException(); 
        }
    }
}
