using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleMinecraftLauncher
{
    public partial class AddGamePathForm : Form
    {
        public AddGamePathForm()
        {
            InitializeComponent();
        }

        private void BrowseGamePathButton_Click(object sender, EventArgs e)
        {
            DialogResult rc = folderBrowserDialog.ShowDialog();
            if (rc == DialogResult.OK)
            {
                AddGamePathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (AddGamePathTextBox.Text == "") { Label4.Visible = true; }
            else { Label4.Visible = false; }
            if (GamePathNameTextBox.Text == "") { Label3.Visible = true; }
            else { Label3.Visible = false; }
            if (GamePathNameTextBox.Text != "")
            {
                if (AddGamePathTextBox.Text != "") 
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
