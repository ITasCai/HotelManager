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
    }
}
