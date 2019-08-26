using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    /// <summary>
    /// This is a class of text editor form.
    /// This class performs a collection of event listeners in texteditorbox
    /// </summary>
    public partial class TextEditorForm : Form
    {
        private User currentUser;
        private string openedFilePath = "";

        // This is a constructor of TextEditorForm class
        public TextEditorForm()
        {
            InitializeComponent();
        }

        // This method will initialise all components inside rich text editor form
        // and get the login user to be passed into this class
        public TextEditorForm(User user)
        {
            this.currentUser = user;
            InitializeComponent();
        }

        // This method will load all necessary information such as username, font size in combobox,
        // and enable view only for "View" usertype
        private void RichTextEditor_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = string.Format("User Name: {0}", currentUser.Username);

            for (int i = 8; i <= 20; i++)
            {
                this.textSizeCombobox.Items.Add(i);
            }
            this.textSizeCombobox.Text = "12";

            if (currentUser.UserType == Constant.USERTYPE_VIEW)
            {
                this.richTextbox.ReadOnly = true;
            }
        }

        // An event listener of bold button to change font style into bold
        private void BoldBtn_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold);
        }

        // An event listener of underline button to change font style into underline
        private void UnderlineBtn_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline);
        }

        // An event listener of italic button to change font style into italic
        private void ItalicBtn_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic);
        }
    
        // An event listener of save as button to save a new file
        private void SaveAsClickEvent(object sender, EventArgs e)
        {
            SaveTextEditor();
        }

        // An event listener of open button to open an existing file
        private void OpenFileClickEvent(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    openedFilePath = openFileDialog.FileName;
                    richTextbox.LoadFile(openedFilePath, RichTextBoxStreamType.RichText);
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    openedFilePath = "";
                }
            }
        }
    
        // An event listener of font size combobox to change font size accordingly
        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextbox.SelectionFont = new Font(richTextbox.Font.FontFamily, Convert.ToInt32(textSizeCombobox.SelectedItem), richTextbox.Font.Style);
        }

        // An event listener of logout button to logout from current user
        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentUser = null;
            ShowForm.ShowLoginForm(null, this);
        }

        // An event listener of save button to save current opened file.
        // If there is no open file, the save button will save as new file
        private void SaveFileClickEvent(object sender, EventArgs e)
        {
            if (!openedFilePath.Equals(string.Empty))
            {
                richTextbox.SaveFile(openedFilePath, RichTextBoxStreamType.RichText);
                MessageBox.Show("Save Complete!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveTextEditor();
            }
        }

        // An event listener of new button to remove current context and ask for
        // saving file before removing the text
        private void NewFileClickEvent(object sender, EventArgs e)
        {
            if (!richTextbox.Text.Equals(string.Empty))
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the current file", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SaveTextEditor();
                }
                richTextbox.Text = string.Empty;
            }
            openedFilePath = "";
        }

        // This is a method to pop up a save dialog and save a new file
        private void SaveTextEditor()
        {
            SaveFileDialog saveAsDialog = new SaveFileDialog();
            saveAsDialog.Filter = "RichTextFormat|*.rtf";

            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                richTextbox.SaveFile(saveAsDialog.FileName, RichTextBoxStreamType.RichText);
                openedFilePath = saveAsDialog.FileName;
                MessageBox.Show("Save Complete!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // This is an event listener of about button to show an about box
        private void AboutFormEventClick(object sender, EventArgs e)
        {
            ShowForm.ShowAboutBox();
        }

        // This is a method to perform copy operation
        private void CopyText(object sender, EventArgs e)
        {
            richTextbox.Copy();
        }

        // This is a method to perform paste operation
        private void PasteText(object sender, EventArgs e)
        {
            richTextbox.Paste();
        }

        // This is a method to perform cut operation
        private void CutText(object sender, EventArgs e)
        {
            richTextbox.Cut();
        }

        // This is a method to change font style depending on the fontstyle parameter
        private void ChangeFontStyle(FontStyle fontStyle)
        {
            if (richTextbox.SelectionFont.Style == FontStyle.Regular)
            {
                richTextbox.SelectionFont = new Font(richTextbox.SelectionFont.FontFamily, Convert.ToInt32(textSizeCombobox.SelectedItem), fontStyle);
            }
            else
            {
                richTextbox.SelectionFont = new Font(richTextbox.SelectionFont.FontFamily, Convert.ToInt32(textSizeCombobox.SelectedItem), FontStyle.Regular);
            }
        }
    }
}