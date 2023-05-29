using Classes;
using DataLibrary;
using LogicLibrary;

namespace CarApp.Forms
{
    public partial class Login_Form : Form
    {
        string userType = "";

        private readonly IUserDbController userDbCon = new UserDbController();
        UserManagement manager;
        public Login_Form()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
            manager = new UserManagement(userDbCon);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var userOrNull = manager.ValidateUser(username, password, userType);
            if (userOrNull != 0)
            {
                
                switch (userType)
                {
                    case "admin":
                        var adminForm = new ServicePoint_Form(userOrNull);
                        adminForm.Closed += (s, args) => this.Close();
                        adminForm.Show();
                        break;
                    case "mechanic":
                        var hrForm = new Mechanic_Form();
                        hrForm.Closed += (s, args) => this.Close();
                        hrForm.Show();
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnService_Click(object sender, EventArgs e)
        {
            btnService.Visible = false;
            btnMech.Visible = false;
            userType = "admin";
        }

        private void btnMech_Click(object sender, EventArgs e)
        {
            btnService.Visible = false;
            btnMech.Visible = false;
            userType = "mechanic";
        }
    }
}
