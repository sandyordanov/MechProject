using Azure.Core;
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
        int servicePointId;
        RepairRequestManagement requestManager;
        public SP_ViewRequests(int _userId, IRepairRequestDbController repReqDbCon)
        {
            InitializeComponent();
            servicePointId = _userId;
            requestManager = new RepairRequestManagement(repReqDbCon);
            lbRequests.DataSource = requestManager.GetRepairAllRequests(servicePointId);
            lbRequests.DisplayMember = "Id";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int requestId = Convert.ToInt32(lbRequests.SelectedItem);
            requestManager.SetRequestAsAcceptedOrDenied(true, requestId);
            lbRequests.DataSource = requestManager.GetRepairAllRequests(servicePointId);
            ClearForm();
        }

        private void SP_ViewRequests_Load(object sender, EventArgs e)
        {

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            int requestId = Convert.ToInt32(lbRequests.SelectedItem);
            requestManager.SetRequestAsAcceptedOrDenied(false, requestId);
            lbRequests.DataSource = requestManager.GetRepairAllRequests(servicePointId);
            ClearForm();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int requestId = Convert.ToInt32(lbRequests.SelectedItem);
            RepairRequest request = requestManager.GetRepairRequest(requestId);
            LoadFormData(request);
        }

        private void ClearForm()
        {
            tbFullName.Text = "";
            tbEmail.Text = "";
            tbMake.Text = "";
            tbModel.Text = "";
            tbYear.Text = "";
            tbMileage.Text = "";
            tbDescription.Text = "";
            cbOil.Checked = false;
            cbFilter.Checked = false;
            cbLightBulb.Checked = false;
            cbTyres.Checked = false;
            cbCoolant.Checked = false;
        }
        private void LoadFormData(RepairRequest request)
        {
            tbFullName.Text = $"{request.User.FirstName} {request.User.LastName}";
            tbEmail.Text = request.User.Email;
            tbMake.Text = request.Car.Make;
            tbModel.Text = request.Car.Model;
            tbYear.Text = Convert.ToString(request.Car.Year);
            tbMileage.Text = Convert.ToString(request.Car.Mileage);
            tbDescription.Text = request.RepairDetails.Description;
            cbOil.Checked = request.RepairDetails.OilChange;
            cbFilter.Checked = request.RepairDetails.AirFilter;
            cbLightBulb.Checked = request.RepairDetails.LightBulb;
            cbTyres.Checked = request.RepairDetails.TyreChange;
            cbCoolant.Checked = request.RepairDetails.CoolantChange;
        }
    }
}
