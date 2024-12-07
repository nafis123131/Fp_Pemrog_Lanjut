using AMRConnector;
using System;
using System.Windows.Forms;

namespace Sistem_Manajemen_Hotel
{
    public partial class FormDashboard : Form
    {
        public string Username;
        DbConnector db;
        public FormDashboard()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah andaa yakin untuk Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd-MM-yyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsernameDashboard.Text = Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservasi1.Hide();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
            userControlRoom1.Hide();
            userControlReservasi1.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Clear();
            userControlRoom1.Show();
            userControlReservasi1.Hide();
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservasi);
            userControlSetting1.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservasi1.Clear();
            userControlReservasi1.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MovePanel(btnSetting);
            userControlSetting1.Clear();
            userControlSetting1.Show();
            userControlSetting1.Hide();
            userControlClient1.Hide(); 
            userControlRoom1.Hide();
            userControlReservasi1.Hide();
        }
    }
}
