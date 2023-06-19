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
    public partial class SP_AssignJobs : UserControl
    {
        int spId;
        private readonly MechanicManagement mechanicManager;
        private readonly RepairRequestManagement repairManager;
        Mechanic selectedMech = new Mechanic();
        RepairRequest selectedRepairRequest = new RepairRequest();
        public SP_AssignJobs(IMechanicDbController _mechController, IRepairRequestDbController _RRController, int id)
        {
            mechanicManager = new MechanicManagement(_mechController, spId);
            repairManager = new RepairRequestManagement(_RRController);
            spId = id;
            InitializeComponent();
        }

        private void SP_AssignJobs_Load(object sender, EventArgs e)
        {
            lbRequests.DataSource = repairManager.GetAllAcceptedRepairRequests(spId);
            lbRequests.DisplayMember = "Id";
            lbMechanics.DataSource = mechanicManager.GetAllWorkersInAWorkshop(spId);
            lbMechanics.DisplayMember.ToString();
        }

        private void lbRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = lbRequests.SelectedItem.ToString();
            selectedRepairRequest = repairManager.GetRepairRequest(Convert.ToInt32(Convert.ToInt32(textBox1.Text)));
            tbKeywordsRequest.Text =String.Join(" ,",RequestShakedown.ScrapeRequest(selectedRepairRequest.Car.Make , selectedRepairRequest.RepairDetails.Description));
        }

        private void lbMechanics_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = lbMechanics.SelectedValue.ToString();
            selectedMech = lbMechanics.SelectedItem as Mechanic;
            tbKeywordsMechanic.Text = String.Join(", ", mechanicManager.GetMechSpeciality(selectedMech.Id));
        }

        private void btnFindMatch_Click(object sender, EventArgs e)
        {
           List<string> keyWords = RequestShakedown.ScrapeRequest(selectedRepairRequest.Car.Make, selectedRepairRequest.RepairDetails.Description);
            List<Mechanic> mechanics = mechanicManager.GetAllWorkersInAWorkshop(spId);
            Dictionary<Mechanic, List<string>> result = RequestShakedown.SearchForAMatch(mechanics, keyWords);

            List<string> titles = new List<string>();
            foreach (var key in result.Keys)
            {
               titles.Add(key.LastName + $"[{String.Join("|",result[key])}]");
            }
            lbMechanics.DataSource = titles;
            tbKeywordsMechanic.ForeColor = Color.Green;
        }
    }
}
