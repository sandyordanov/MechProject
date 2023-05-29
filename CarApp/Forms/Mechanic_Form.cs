using CarApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLibrary;
using Classes;

namespace CarApp.Forms
{
    public partial class Mechanic_Form : Form
    {
        int userId;
        public Mechanic_Form()
        {
            InitializeComponent();
        }

        private void btnViewAssigned_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new Mechanic_ViewJobs() { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
