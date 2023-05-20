﻿using System;
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
        IUserDbController _userDbcon;
        ICarDbController _carDbcon;
        IRepairRequestDbController _repairRequestDbcon;
        public ServicePoint_Form(User user)
        {

            InitializeComponent();
            _userDbcon = new UserDbController();
            _carDbcon = new CarDbController();
            _repairRequestDbcon = new RepairRequestDbController();
        }

        private void btnReviewAppointments_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_ViewRequests(_userDbcon,_carDbcon,_repairRequestDbcon) { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnAssignJobs_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_AssignJobs() { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnEvaluatePrice_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_EvaluatePrice() { Dock = DockStyle.Fill };
            panel1.Controls.Add(uc);
        }

        private void btnManageMechanics_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var uc = new SP_ManageMechanics() { Dock = DockStyle.Fill };
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
