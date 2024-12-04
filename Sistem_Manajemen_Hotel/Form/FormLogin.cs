using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

namespace Sistem_Manajemen_Hotel
{
        public partial class FormLogin : Form
        {
        DbConnector db;
        public FormLogin()
        {
            InitializeComponent();
            db = new DbConnector();
            
        }
        private void pictureboxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureboxClose, "Close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            txtPasswordLogin.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            txtPasswordLogin.UseSystemPasswordChar = true;
            pictureBoxHide.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(txtUsernameLogin.Text.Trim(), txtPasswordLogin.Text.Trim());
            if (txtUsernameLogin.Text.Trim() == string.Empty || txtPasswordLogin.Text.Trim() == string.Empty)
                MessageBox.Show("Silahkan isi kolom terlebih dahulu", "Required Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (check)
                {
                    FormDashboard fd = new FormDashboard();
                    fd.Username = txtUsernameLogin.Text;
                    txtUsernameLogin.Clear();
                    txtPasswordLogin.Clear();
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah", "Username atau Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPasswordLogin_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
