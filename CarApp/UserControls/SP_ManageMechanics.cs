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
        Mechanic selected = new Mechanic();
        MechanicManagement mechManager;
        public SP_ManageMechanics(int currentUser, IMechanicDbController mechCon)
        {
            InitializeComponent();
            mechManager = new MechanicManagement(mechCon, spId);
            spId = currentUser;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            string firstName = tbAddName.Text;
            string lastName = tbAddLastName.Text;
            string phoneNumber = tbAddPhone.Text;
            string password = tbPassword.Text;
            int level = Convert.ToInt32(nUpNDownLevel.Value);
            List<string> list;
            if (tbSpecialisation.Text != "")
            {
                list = tbSpecialisation.Text.Split().ToList();
            }
            else
            {
                list = new List<string>() { "" };
            }
            Mechanic mech = new Mechanic(firstName, lastName, phoneNumber, password, spId, level);

            string generatedUsername = mechManager.InsertMechanic(mech, list);
            MessageBox.Show($"Generated username - {generatedUsername}.");
            ClearForm();
        }

        private void SP_ManageMechanics_Load(object sender, EventArgs e)
        {
            lbDisplay.DataSource = mechManager.GetAllWorkersInAWorkshop(spId);
            lbDisplay.DisplayMember = "LastName";
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            selected = lbDisplay.SelectedItem as Mechanic;
            if (selected != null)
            {
                tbShowFirstName.Text = selected.FirstName;
                tbShowLastName.Text = selected.LastName;
                tbShowPhone.Text = selected.PhoneNumber;
                progressBar1.Value = selected.MechLevel;

                List<string> skills = mechManager.GetMechSpeciality(selected.Id);
                tbShowSpecialisation.Text = String.Join(", ", skills);
            }
        }

        private void btnPromote_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            mechManager.PromoteMech(selected.Id, selected.MechLevel + 1);
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            btnIamSure.Visible = true;
        }

        private void btnIamSure_Click(object sender, EventArgs e)
        {
            mechManager.DeleteMechanic(selected.Id);
            lbDisplay.DataSource = mechManager.GetAllWorkersInAWorkshop(spId);
            ClearForm();
        }

        private void ClearForm()
        {
            tbAddName.Text = string.Empty;
            tbAddLastName.Text = string.Empty;
            tbAddPhone.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbSpecialisation.Text = string.Empty;
            nUpNDownLevel.Text = string.Empty;

            tbShowFirstName.Text = string.Empty;
            tbShowLastName.Text = string.Empty;
            tbShowPhone.Text = string.Empty;
            tbShowSpecialisation.Text = string.Empty;
            progressBar1.Value = 0;
            btnIamSure.Visible = false;

            lbDisplay.DataSource = mechManager.GetAllWorkersInAWorkshop(spId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                lbDisplay.DataSource = mechManager.GetAllWorkersInAWorkshop(spId);
            }
            else
            {
                lbDisplay.DataSource = SearchEngine.SearchForMechanics(search, mechManager.GetAllWorkersInAWorkshop(spId));
            }
        }
    }
}
