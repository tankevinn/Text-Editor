namespace Assignment2
{
    /// <summary>
    /// This is a class to show each form in the Rich Text Editor application.
    /// </summary>
    class ShowForm
    {
        // Shows a text editor form and hide login form
        public static void ShowTextEditorForm(User user, LoginForm loginForm)
        {
            TextEditorForm TextEditorForm = new TextEditorForm(user);

            loginForm.Hide();
            TextEditorForm.Show();
        }

        // Shows a login form and hide text editor or registration form
        public static void ShowLoginForm(NewUserForm newUserForm = null, TextEditorForm textEditorForm = null)
        {
            LoginForm loginForm = new LoginForm();
            if (newUserForm != null)
            {
                newUserForm.Hide();
            }

            if (textEditorForm != null)
            {
                textEditorForm.Hide();
            }
            loginForm.Show();
        }

        // Shows a registration form and hide login form
        public static void ShowNewUserForm(LoginForm loginForm)
        {
            NewUserForm newUserForm = new NewUserForm();

            loginForm.Hide();
            newUserForm.Show();
        }

        // Shows an about box
        public static void ShowAboutBox()
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
