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

namespace Sistem_Manajemen_Hotel.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        public void Clear()
        {
            txtUsernameTambahUser.Clear();
            txtPasswordTambahUser.Clear();
            tabControlSetting.SelectedTab = tabPageCariUser;
        }
        public void Clear1()
        {
            txtUsernameUpdateDelete.Clear();
            txtPasswordUpdateDelete.Clear();
            ID = " ";
        }

        private void tabPageTambahUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageCariUser_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewCariUser);
        }

        private void tabPageCariUser_Leave(object sender, EventArgs e)
        {
            txtUsernameCariUser.Clear();
        }

        private void tabPageUpdateDelete_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnTambahUser_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtUsernameTambahUser.Text.Trim() == string.Empty || txtPasswordTambahUser.Text.Trim() == string.Empty)
            MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddUser(txtUsernameTambahUser.Text.Trim(), txtPasswordTambahUser.Text.Trim());
                if (check)
                    Clear();
            }
        }

        private void btnUpdateDeleteUser_Click(object sender, EventArgs e)
        {
            bool check;
            if(ID != " ")
            {
                if (txtUsernameUpdateDelete.Text.Trim() == string.Empty || txtPasswordUpdateDelete.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Apakah anda ingin menghapus user ini?", "User telah dihapus!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.UpdateUser(ID, txtUsernameUpdateDelete.Text.Trim(), txtPasswordUpdateDelete.Text.Trim());
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewCariUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!= -1)
            {
                DataGridViewRow row = dataGridViewCariUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtUsernameTambahUser.Text = row.Cells[1].Value.ToString();
                txtPasswordTambahUser.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnDeleteUpdateUser_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != " ")
            {
                if (txtUsernameUpdateDelete.Text.Trim() == string.Empty || txtPasswordUpdateDelete.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.DeleteUser(ID);
                    if (check)
                        Clear1();
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPageTambahUser_Enter(object sender, EventArgs e)
        {

        }

        private void txtUsernameCariUser_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SEARCH * FROM User_Table WHERE User_Name LIKE '%" + txtUsernameCariUser.Text + "%'", dataGridViewCariUser);
        }
    }
}
