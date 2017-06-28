using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagerBLL;

namespace HotelManager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string pass = txtpassword.Text.Trim();
            //判断用户名不能为空
            if (string.IsNullOrEmpty(username)|| string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("请输入用户名或密码！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //设置鼠标焦点
                txtusername.Focus();
                return;
            }
            //检索输入的用户名或密码是否正确
            bool badmin=AdminManager.AdminLogtin(username,pass);
            if (!badmin)
            {
                MessageBox.Show("用户名密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                frmMain fr = new frmMain();
                fr.Show();
                this. Hide();
            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
