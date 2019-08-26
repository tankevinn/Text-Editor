using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    /// <summary>
    /// This is a login form class.
    /// This class contains list of event listeners to login and register user.
    /// </summary>
    public partial class LoginForm : Form
    {
        // A constructor to initialise components inside login form
        public LoginForm()
        {
            InitializeComponent();
        }

        // This is an event listener of login button.
        // This method will load user data and check if username and password are valid.
        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            Users users = new Users();
            users.LoadData();
            
            user = users.IsLoginSucceed(username, password);

            if (user != null)
            {
                ShowForm.ShowTextEditorForm(user, this);
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // This is an event listener for register button.
        // This method will show registration form.
        private void newUserBtn_Click(object sender, EventArgs e)
        {
            ShowForm.ShowNewUserForm(this);
        }

        // This is an event listener for exit button.
        // This method will exit the application gracefully.
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
