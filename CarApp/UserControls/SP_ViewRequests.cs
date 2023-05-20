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
    public partial class SP_ViewRequests : UserControl
    {
        RepairRequestManagement requestManager;
        public SP_ViewRequests(IUserDbController userDbController, ICarDbController carDbController, IRepairRequestDbController repairRequestDbController)
        {
            InitializeComponent();
            requestManager = new RepairRequestManagement(userDbController, carDbController, repairRequestDbController);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void SP_ViewRequests_Load(object sender, EventArgs e)
        {

        }
    }
}
