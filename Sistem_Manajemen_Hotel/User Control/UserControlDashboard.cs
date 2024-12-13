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
    public partial class UserControlDashboard : UserControl
    {
        DbConnector db;
        public UserControlDashboard()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        public void User()
        {
            lblUserCount.Text = db.Count("SELECT COUNT (*) From User_Table").ToString();
        }
        public void Client()
        {
            lblClientCount.Text = db.Count("SELECT COUNT (*) From Client_Table").ToString();
        }
        public void Room()
        {
            lblRoomCount.Text = db.Count("SELECT COUNT (*) From Room_Table").ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }
    }
}
