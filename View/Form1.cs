using Empresa2.Employees;
using Empresa2.Interfaces;
using Empresa2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa2
{
    public partial class Form1 : Form
    {
        private GameDevCompany gameDevCompany;
        private OutsourcingCompany outsourcingCompany;

        public Form1()
        {
            InitializeComponent();
            gameDevCompany = new GameDevCompany();
            outsourcingCompany = new OutsourcingCompany();
        }

        private void btnEmployeeGD_Click_1(object sender, EventArgs e)
        {
            List<string> employees = gameDevCompany.getEmployees();
            txtDescriptionEmployeeGD.Clear();
            foreach (string description in employees)
            {
                txtDescriptionEmployeeGD.AppendText(description + Environment.NewLine);
            }
        }

        private void btnEmployeeOS_Click_1(object sender, EventArgs e)
        {
            List<string> descriptions = outsourcingCompany.getEmployees();
            txtDescriptionEmployeeOS.Clear();
            foreach (string description in descriptions)
            {
                txtDescriptionEmployeeOS.AppendText(description + Environment.NewLine);
            }

        }
    }
}
