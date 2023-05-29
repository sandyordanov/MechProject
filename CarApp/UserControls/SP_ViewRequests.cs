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
        int userId;
        UserManagement userManager;
        ServicePointManagement spManager;
        RepairRequestManagement repairManager;
        public SP_ViewRequests(int _userId, IRepairRequestDbController repReqDbCon, IUserDbController userDbCon)
        {
            InitializeComponent();
            _userId = userId;
            repairManager = new RepairRequestManagement(repReqDbCon);
            userManager = new UserManagement(userDbCon);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void SP_ViewRequests_Load(object sender, EventArgs e)
        {
            lbRequests.DataSource = repairManager.GetRepairRequests(userId);
            lbRequests.DisplayMember = "Id";
        }
    }
}
