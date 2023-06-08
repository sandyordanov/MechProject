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
        int spId;
        MechanicManagement mechManager;
        public SP_ManageMechanics(int currentUser, IMechanicDbController mechCon)
        {
            InitializeComponent();
            mechManager = new MechanicManagement(mechCon);
            spId = currentUser;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string firstName = tbAddName.Text;
            string lastName = tbAddLastName.Text;
            string phoneNumber = tbAddPhone.Text;
            string password = tbPassword.Text;
            List<string> list = tbSpecialisation.Text.Split().ToList();
            Mechanic mech = new Mechanic(firstName,lastName,phoneNumber,password, spId);
            if(list.Count > 0)
            {
                mechManager.InsertMechanic(mech, list);
            }
            else
            {

            }

        }
    }
}
