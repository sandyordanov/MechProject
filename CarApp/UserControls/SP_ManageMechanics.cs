using Classes;
using DataLibrary;
using LogicLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp.UserControls
{
    public partial class SP_ManageMechanics : UserControl
    {
        MechanicManagement mechManager;
        public SP_ManageMechanics(int currentUser, IMechanicDbController mechCon)
        {
            InitializeComponent();
            mechManager = new MechanicManagement(mechCon);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Mechanic mech = new Mechanic()
            {
                Username = "George",
                FirstName =
            }
            mechManager.InsertMechanic()
        }
    }
}
