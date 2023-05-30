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
        }

        private void SP_ViewRequests_Load(object sender, EventArgs e)
        {

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            int requestId = Convert.ToInt32(lbRequests.SelectedItem);
            requestManager.SetRequestAsAcceptedOrDenied(false, requestId);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int requestId = Convert.ToInt32(lbRequests.SelectedItem);
            RepairRequest request = requestManager.GetRepairRequest(requestId);

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
