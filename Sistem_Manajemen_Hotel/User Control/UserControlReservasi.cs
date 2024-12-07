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
    
    public partial class UserControlReservasi : UserControl
    {
        DbConnector db;
        private string RID = "", No;
        public UserControlReservasi()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            cmb_Tipe_RuanganTambah.SelectedIndex = 0;
            cmb_Nomor_RuanganTambah.SelectedIndex = 0;
            txt_ID_ClientTambah.Clear();
            dateTimePicker_Tgl_MasukTambah.Value = DateTime.Now;
            dateTimePickerTgl_KeluarTambah.Value = DateTime.Now;
            tabControlReservasi.SelectedTab = tabPageTambahReservasi;
        }

        private void UserControlReservasi_Load(object sender, EventArgs e)
        {
            cmb_Tipe_RuanganTambah.SelectedIndex = 0;
            cmb_Nomor_RuanganTambah.SelectedIndex = 0;
            cmb_TipeRuangan_UpdateCancel.SelectedIndex = 0;
            cmb_NoRuang_UpdateCancel.SelectedIndex = 0;
        }

        private void tabPageTambahReservasi_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void btnTambahReservasi_Click(object sender, EventArgs e)
        {
            bool check;
            if (cmb_Tipe_RuanganTambah.SelectedIndex == 0 || cmb_Nomor_RuanganTambah.SelectedIndex == 0 || 
                txt_ID_ClientTambah.Text.Trim() == string.Empty)
                MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddReservation(cmb_Tipe_RuanganTambah.SelectedItem.ToString(), cmb_Nomor_RuanganTambah.SelectedItem.ToString(), txt_ID_ClientTambah.Text.Trim(), dateTimePicker_Tgl_MasukTambah.Text, dateTimePickerTgl_KeluarTambah.Text );
                db.UpdateReservationRoom(cmb_Nomor_RuanganTambah.SelectedItem.ToString(), "No");
                if (check)
                    Clear();
            }
        }

        private void tabPageCariReservasi_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Reservasi_Table", dataGridViewCariReservasi);
        }

        private void tabPageCariReservasi_Leave(object sender, EventArgs e)
        {
            txt_IDClient_CariReservasi.Clear();
        }

        private void txt_IDClient_CariReservasi_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SEARCH * FROM Reservasi_Table WHERE reservasi_ID_Client LIKE '%" + txt_IDClient_CariReservasi.Text + "%'", dataGridViewCariReservasi);
        }

        private void dataGridViewCariReservasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewCariReservasi.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                cmb_TipeRuangan_UpdateCancel.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                txt_IDClient_UpdateCancel.Text = row.Cells[3].Value.ToString();
                dateTimePicker_Tgl_MasukTambah.Text = row.Cells[4].Value.ToString();
                dateTimePickerTgl_KeluarTambah.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnUpdateReservasi_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != " ")
            {
                if (cmb_TipeRuangan_UpdateCancel.SelectedIndex == 0 || cmb_NoRuang_UpdateCancel.SelectedIndex == 0 || txt_IDClient_UpdateCancel.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.UpdateReservation(RID, cmb_TipeRuangan_UpdateCancel.SelectedItem.ToString(), cmb_NoRuang_UpdateCancel.SelectedItem.ToString(), txt_IDClient_UpdateCancel.Text.Trim(), dateTimePicker_IN_UpdateCancel.Text, dateTimePicker_OUT_UpdateCancel.Text);
                    db.UpdateReservationRoom(No, "Yes");
                    db.UpdateReservationRoom(cmb_Nomor_RuanganTambah.SelectedItem.ToString(), "No");
                    if (check)
                        Clear1();
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelReservasi_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != " ")
            {
                if (cmb_TipeRuangan_UpdateCancel.SelectedIndex == 0 || txt_IDClient_UpdateCancel.Text.Trim() == string.Empty)
                    MessageBox.Show("Silahkan isi semua kolom !", "Require all field !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Apakah anda ingin membatalkan client ini?", "Reservasi telah dibatalkan!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteReservation(RID);
                        db.UpdateReservationRoom(No, "Yes");
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("Silahkan pilih salah satu pada baris kolom !", "Pilih pada baris kolom !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelReservasi_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void cmb_TipeRuangan_UpdateCancel_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + cmb_TipeRuangan_UpdateCancel.SelectedItem.ToString() + "' AND Room_Free = 'YES' ORDER BY Room_Number", cmb_NoRuang_UpdateCancel);
        }

        private void cmb_Tipe_RuanganTambah_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + cmb_Tipe_RuanganTambah.SelectedItem.ToString() + "' AND Room_Free = 'YES' ORDER BY Room_Number", cmb_Nomor_RuanganTambah);
        }

        private void Clear1()
        {
            cmb_TipeRuangan_UpdateCancel.SelectedIndex = 0;
            cmb_NoRuang_UpdateCancel.SelectedIndex = 0;
            txt_IDClient_UpdateCancel.Clear();
            dateTimePicker_IN_UpdateCancel.Value = DateTime.Now;
            dateTimePicker_OUT_UpdateCancel.Value = DateTime.Now;
            RID = "";
        }
    }
}
