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
    public partial class UserControlRoom : UserControl
    {
        DbConnector db;
        private string No = " ", Free = " ";
        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            cmbTipe_TambahRuangan.SelectedIndex = 0;
            txtPhoneTambahRuangan.Clear();
            rdb_Yes_TambahRuangan.Checked = false;
            rdb_No_TambahRuangan.Checked = false;
            tabControlCariRuang.SelectedTab = tabPageTambahRuang;
        }

        private void btnTambahRuangan_Click(object sender, EventArgs e)
        {
            if (rdb_Yes_TambahRuangan.Checked)
                Free = "Yes";
            if (rdb_No_TambahRuangan.Checked)
                Free = "No";
            bool check;
            if (cmbTipe_TambahRuangan.SelectedIndex == 0 || txtPhoneTambahRuangan.Text.Trim() == string.Empty || Free == " ")
                MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddRoom(cmbTipe_TambahRuangan.SelectedIndex.ToString(), txtPhoneTambahRuangan.Text.Trim(), Free);
                if (check)
                    Clear();
            }
        }

        private void tabPageTambahRuang_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabControlCariRuang_Enter(object sender, EventArgs e)
        {
            //db.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewCariRuang);
        }

        private void tabPageCariRuang_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewCariRuang);
        }

        private void tabPageCariRuang_Leave(object sender, EventArgs e)
        {
            txtCariRuang.Clear();
        }

        private void txtCariRuang_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SEARCH * FROM Room_Table WHERE Room_Number LIKE '%" + txtCariRuang.Text + "%'", dataGridViewCariRuang);
        }

        private void dataGridViewCariRuang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewCariRuang.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                cmbTipe_UpdateDelete.SelectedItem = row.Cells[1].Value.ToString();
                txtPhone_UpdateDelete.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free == "Yes")
                    rdb_Yes_UpdateDelete.Checked = true;
                if (Free == "No")
                    rdb_No_UpdateDelete.Checked = true;
            }
        }

        private void btnUpdateRuangan_Click(object sender, EventArgs e)
        {
            if (rdb_Yes_UpdateDelete.Checked)
                Free = "Yes";
            if (rdb_No_UpdateDelete.Checked)
                Free = "No";
            bool check;
            if (No != " ")
            {
                if (cmbTipe_UpdateDelete.SelectedIndex == 0 || txtPhone_UpdateDelete.Text.Trim() == string.Empty || Free == " ")
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.UpdateRoom(No,cmbTipe_UpdateDelete.SelectedItem.ToString(), txtPhone_UpdateDelete.Text.Trim(),Free);
                    if (check)
                        Clear1();
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDeleteRuangan_Click(object sender, EventArgs e)
        {
            if (rdb_Yes_UpdateDelete.Checked)
                Free = "Yes";
            if (rdb_No_UpdateDelete.Checked)
                Free = "No";
            bool check;
            if (No != " ")
            {
                if (cmbTipe_UpdateDelete.SelectedIndex == 0 || txtPhone_UpdateDelete.Text.Trim() == string.Empty || Free == " ")
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Apakah anda ingin menghapus ruang ini?", "Ruang telah dihapus!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteRoom(No);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            cmbTipe_TambahRuangan.SelectedIndex = 0;
            cmbTipe_UpdateDelete.SelectedIndex = 0;
        }

        private void tabPageCariRuang_Click(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateDeleteRuang_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        public void Clear1()
        {
            cmbTipe_UpdateDelete.SelectedIndex = 0;
            txtPhone_UpdateDelete.Clear();
            rdb_Yes_UpdateDelete.Checked = false;
            rdb_No_UpdateDelete.Checked = false;
            No = " ";
        }
    }
}
