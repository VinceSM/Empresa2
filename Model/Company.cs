using Empresa2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa2.Model
{
    public abstract class Company
    {
        List<IEmployee> Employees {  get; set; }

        public List<string> getEmployees()
        {
            List<string> desc = new List<string>();
            foreach (var employee in Employees)
            {
                desc.Add(employee.doWork());
            }
            return desc;
        }

        public void CreateSoftware()
        { throw new NotImplementedException(); }
    }
}
