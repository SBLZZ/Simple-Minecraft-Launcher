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
    public partial class AdduserForm : Form
    {
        public AdduserForm()
        {
            InitializeComponent();
        }

        private void AddUserDoneButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "") { MessageBox.Show("用户名不能为空"); }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void AddUserCancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AdduserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
