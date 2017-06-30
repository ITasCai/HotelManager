using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tspfjlx_Click(object sender, EventArgs e)
        {
            frmRoomType frmRoomType = new frmRoomType();
            frmRoomType.MdiParent = this;
            frmRoomType.Show();
        }

        private void tsproom_Click(object sender, EventArgs e)
        {
            frmRoom room = new frmRoom();
            room.MdiParent = this;
            room.Show();
        }

        private void tsmGuestRecord_Click(object sender, EventArgs e)
        {
            frmRppmInfo info = new frmRppmInfo();
            info.MdiParent = this;
            info.Show();
        }

        private void tsprzdj_Click(object sender, EventArgs e)
        {
            frmGuestRecode gr = new frmGuestRecode();
            gr.MdiParent = this;
            gr.Show();
        }
    }
}
