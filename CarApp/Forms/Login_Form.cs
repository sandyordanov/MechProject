using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using DataLibrary;
using LogicLibrary;

namespace CarApp.Forms
{
    public partial class Login_Form : Form
    {
        PasswordValidatior passwordValidator = new PasswordValidatior();
        public Login_Form()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbUsername.Text;
            string password = tbPassword.Text;

            var userOrNull = passwordValidator.ValidateCredentials(email, password);
            if (userOrNull != null)
            {
                switch (userOrNull.position)
                {
                    case UserType.ServicePoint:
                        var adminForm = new ServicePoint_Form(userOrNull);
                        adminForm.Closed += (s, args) => this.Close();
                        adminForm.Show();
                        break;
                    case UserType.Mechanic:
                        var hrForm = new Mechanic_Form(userOrNull);
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
    }
}
