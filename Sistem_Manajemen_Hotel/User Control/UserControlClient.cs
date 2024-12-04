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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Sistem_Manajemen_Hotel.User_Control
{
    public partial class UserControlClient : UserControl
    {
        DbConnector db;
        private string ID = " "; 
        public UserControlClient()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            txtFirstNameTambahClient.Clear();
            txtLastnameTambahClient.Clear();
            txtPhoneNoTambahClient.Clear();
            txtAddressTambahClient.Clear();
            tabControlClient.SelectedTab = tabPageTambahClient;
        }

        private void Clear1()
        {
            txtFirstNameUpdateDelete.Clear();
            txtLastNameUpdateDelete.Clear();
            txtPhoneUpdateDelete.Clear();
            txtAddressUpdateDelete.Clear();
            ID = "";
        }

        private void btnTambahClient_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtFirstNameTambahClient.Text.Trim() == string.Empty ||
                txtLastnameTambahClient.Text.Trim() == string.Empty ||
                txtPhoneNoTambahClient.Text.Trim() == string.Empty ||
                txtAddressTambahClient.Text.Trim() == string.Empty)
                MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddClient(txtFirstNameTambahClient.Text.Trim(), txtLastnameTambahClient.Text.Trim(), txtPhoneNoTambahClient.Text.Trim(), txtAddressTambahClient.Text.Trim());
                if (check)
                    Clear();
            }
        }

        private void tabPageTambahClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table", dataGridViewCariClient);
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            txtPhoneCariClient.Clear();
        }

        private void txtPhoneCariClient_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SEARCH * FROM User_Table WHERE Client_Phone LIKE '%" + txtPhoneCariClient.Text + "%'", dataGridViewCariClient);
        }

        private void btnUpdateDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != " ")
            {
                if (txtFirstNameUpdateDelete.Text.Trim() == string.Empty ||
                txtLastNameUpdateDelete.Text.Trim() == string.Empty ||
                txtPhoneUpdateDelete.Text.Trim() == string.Empty ||
                txtAddressUpdateDelete.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                 check = db.UpdateClient(ID, txtFirstNameUpdateDelete.Text.Trim(), txtLastNameUpdateDelete.Text.Trim(), txtPhoneUpdateDelete.Text.Trim(), txtAddressUpdateDelete.Text.Trim());
                 if (check)
                     Clear1();
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != " ")
            {
                if (txtFirstNameUpdateDelete.Text.Trim() == string.Empty ||
                txtLastNameUpdateDelete.Text.Trim() == string.Empty ||
                txtPhoneUpdateDelete.Text.Trim() == string.Empty ||
                txtAddressUpdateDelete.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Apakah anda ingin menghapus client ini?", "Client telah dihapus!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteClient(ID);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPageUpdateDeleteClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewCariClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewCariClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtFirstNameUpdateDelete.Text = row.Cells[1].Value.ToString();
                txtLastNameUpdateDelete.Text = row.Cells[2].Value.ToString();
                txtPhoneUpdateDelete.Text = row.Cells[3].Value.ToString();
                txtAddressUpdateDelete.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
