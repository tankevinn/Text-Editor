using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assignment2
{
    /// <summary>
    /// This is a registration form class.
    /// This class contains event listeners for each button.
    /// This class also contains some validation checking to validate form value.
    /// </summary>
    public partial class NewUserForm : Form
    {
        private string newUsername;
        private string newPassword;
        private string reEnterPassword;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string userType;

        // A constructor to initialise components inside registration form.
        public NewUserForm()
        {
            InitializeComponent();
        }

        // This is an event listener for submit button.
        // This method will check if username and password are valid and empty fields 
        // on the form.
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            newUsername = userNameTextbox.Text;
            newPassword = passwordTextbox.Text;
            reEnterPassword = reEnterPasswordTextbox.Text;
            firstName = firstNameTextbox.Text;
            lastName = lastNameTextbox.Text;
            dateOfBirth = dateOfBirthDatePicker.Text;
            userType = userTypeCombobox.Text;

            User newUser = new User()
            {
                Username = newUsername,
                Password = newPassword,
                FirstName = firstName,
                SurName = lastName,
                DateOfBirth = dateOfBirth,
                UserType = userType
            };

            bool isValid = CheckLoginValid(newPassword, reEnterPassword);

            if (!newUser.CheckEmptyFields())
            {
                MessageBox.Show("All fields must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!checkDobValid(dateOfBirth))
            {
                MessageBox.Show("Date of birth is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!isValid){
                MessageBox.Show("Username or password is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (CheckSamePassword(newPassword, reEnterPassword))
                {
                    Users users = new Users();
                    users.SaveNewUser(newUser);
                }
                ShowForm.ShowLoginForm(this);
            }
        }

        // This is an event listener of cancel button.
        // This method will hide registration form and go back to login form.
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            ShowForm.ShowLoginForm(this);
        }

        // This is a method to load setup combobox before loading all components
        // in registration form.
        private void NewUserForm_Load(object sender, EventArgs e)
        {
            userTypeCombobox.Text = Constant.USERTYPE_VIEW;
        }

        // This is an event listener for confirm password text change.
        // This method will show message according to whether the password is matched 
        // with confirm password.
        private void ReEnterPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (!reEnterPasswordTextbox.Text.Equals(passwordTextbox.Text))
            {
                passwordValidationLabel.Text = Constant.REPASSWORD_FIELD_DESCRIPTION;
                passwordValidationLabel.ForeColor = Color.Red;
            }
            else
            {
                passwordValidationLabel.Text = Constant.REPASSWORD_CONFIRMED_FIELD_DESCRIPTION;
                passwordValidationLabel.ForeColor = Color.Green;
            }
        }

        // This is an event listener for username text change.
        // This method will show message whether username is valid or not.
        private void UserNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CheckUsernameValid())
            {
                usernameValidationLabel.Text = Constant.USERNAME_MATCH_FIELD_DESCRIPTION;
                usernameValidationLabel.ForeColor = Color.Green;
            }
            else
            {
                usernameValidationLabel.Text = Constant.USERNAME_NOMATCH_FIELD_DESCRIPTION;
                usernameValidationLabel.ForeColor = Color.Red;
            }
        }

        // Checks if username already exists in login.txt
        private bool CheckUsernameValid()
        {
            Users users = new Users();
            users.LoadData();
            return users.CheckUsername(userNameTextbox.Text);
        }

        // Checks if confirm password is matched with password
        private bool CheckSamePassword(string password, string rePassword)
        {
            if (newPassword.Equals(reEnterPassword))
            {
                return true;
            }
            return false;
        }

        // Checks if login is valid or not by calling both checkUsername and checkPassword
        private bool CheckLoginValid(string password, string rePassword)
        {
            if (CheckUsernameValid())
            {
                if(CheckSamePassword(password, rePassword))
                {
                    return true;
                }
            }
            return false;
        }
        
        // Checks if dateOfBirth is valid or not
        private bool checkDobValid(string dateOfBirth)
        {
            if (Convert.ToDateTime(dateOfBirth) > DateTime.Today)
            {
                return false;
            }
            return true;
        }
    }
}
