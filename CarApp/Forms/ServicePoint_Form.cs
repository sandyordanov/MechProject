using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarApp.UserControls;
using LogicLibrary;
using Classes;
using Microsoft.VisualBasic.Logging;
using DataLibrary;

namespace CarApp.Forms
{
    public partial class ServicePoint_Form : Form
    {
        int userId = 0;
        private readonly ICarDbController _carDbcon;
        private readonly IUserDbController _userDbcon;
        private readonly IRepairRequestDbController _repairRequestDbcon;
        private readonly IMechanicDbController _mechDbController;
        private readonly IServicePointDbController _servicePointDbcon;
        private readonly IRepairRequestDbController _repReqDbController;
        public ServicePoint_Form(int _userId)
        {
            InitializeComponent();
            _userDbcon = new UserDbController();
            _carDbcon = new CarDbController();
            _repairRequestDbcon = new RepairRequestDbController();
            _mechDbController = new MechanicDBController();
            _repReqDbController = new RepairRequestDbController();
            userId = _userId;
        }

        private void btnReviewAppointments_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_ViewRequests(userId, _repairRequestDbcon) { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnAssignJobs_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_AssignJobs(_mechDbController, _repReqDbController, userId) { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnManageMechanics_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_ManageMechanics(userId, _mechDbController) { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login_Form();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
