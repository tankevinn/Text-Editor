namespace Assignment2
{
    partial class NewUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userNameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.reEnterPasswordTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.userTypeCombobox = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordValidationLabel = new System.Windows.Forms.Label();
            this.usernameValidationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameTextbox
            // 
            this.userNameTextbox.Location = new System.Drawing.Point(258, 52);
            this.userNameTextbox.Name = "userNameTextbox";
            this.userNameTextbox.Size = new System.Drawing.Size(144, 20);
            this.userNameTextbox.TabIndex = 1;
            this.userNameTextbox.TextChanged += new System.EventHandler(this.UserNameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(258, 91);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(144, 20);
            this.passwordTextbox.TabIndex = 2;
            // 
            // reEnterPasswordTextbox
            // 
            this.reEnterPasswordTextbox.Location = new System.Drawing.Point(258, 130);
            this.reEnterPasswordTextbox.Name = "reEnterPasswordTextbox";
            this.reEnterPasswordTextbox.Size = new System.Drawing.Size(144, 20);
            this.reEnterPasswordTextbox.TabIndex = 3;
            this.reEnterPasswordTextbox.TextChanged += new System.EventHandler(this.ReEnterPasswordTextbox_TextChanged);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(258, 168);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(144, 20);
            this.firstNameTextbox.TabIndex = 4;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Location = new System.Drawing.Point(258, 209);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(144, 20);
            this.lastNameTextbox.TabIndex = 5;
            // 
            // dateOfBirthDatePicker
            // 
            this.dateOfBirthDatePicker.CustomFormat = "dd-MM-yyyy";
            this.dateOfBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirthDatePicker.Location = new System.Drawing.Point(258, 248);
            this.dateOfBirthDatePicker.MaxDate = System.DateTime.Now.Date;
            this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            this.dateOfBirthDatePicker.Size = new System.Drawing.Size(144, 20);
            this.dateOfBirthDatePicker.TabIndex = 6;
            this.dateOfBirthDatePicker.Value = System.DateTime.Now.Date;
            // 
            // userTypeCombobox
            // 
            this.userTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeCombobox.FormattingEnabled = true;
            this.userTypeCombobox.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeCombobox.Location = new System.Drawing.Point(258, 286);
            this.userTypeCombobox.Name = "userTypeCombobox";
            this.userTypeCombobox.Size = new System.Drawing.Size(121, 21);
            this.userTypeCombobox.TabIndex = 7;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(327, 333);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(155, 333);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(152, 59);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 10;
            this.usernameLabel.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "User Type";
            // 
            // passwordValidationLabel
            // 
            this.passwordValidationLabel.AutoSize = true;
            this.passwordValidationLabel.Location = new System.Drawing.Point(255, 153);
            this.passwordValidationLabel.Name = "passwordValidationLabel";
            this.passwordValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordValidationLabel.TabIndex = 12;
            // 
            // usernameValidationLabel
            // 
            this.usernameValidationLabel.AutoSize = true;
            this.usernameValidationLabel.Location = new System.Drawing.Point(255, 75);
            this.usernameValidationLabel.Name = "usernameValidationLabel";
            this.usernameValidationLabel.Size = new System.Drawing.Size(0, 13);
            this.usernameValidationLabel.TabIndex = 13;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 435);
            this.Controls.Add(this.usernameValidationLabel);
            this.Controls.Add(this.passwordValidationLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.userTypeCombobox);
            this.Controls.Add(this.dateOfBirthDatePicker);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.reEnterPasswordTextbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.userNameTextbox);
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUserForm";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox reEnterPasswordTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
        private System.Windows.Forms.ComboBox userTypeCombobox;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label passwordValidationLabel;
        private System.Windows.Forms.Label usernameValidationLabel;
    }
}