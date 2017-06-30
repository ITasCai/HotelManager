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
using HotelManagerModel;

namespace HotelManager
{
    public partial class frmGuestRecode : Form
    {

        //定义变量表示房间编号是否从其他窗体传入
        public bool isTrans = false;
        //设置下拉框的房间id
        public int roomValue;

        public void SetCmdInfo(int room) {
            roomValue = room;
            isTrans = true;
            
        }

        public frmGuestRecode()
        {
            InitializeComponent();
        }

        private void frmGuestRecode_Load(object sender, EventArgs e)
        {
            IList<Room> list = RoomManager.GetLeiureList();
            //指定数据源

            this.cmbroomName.DataSource = list;
            //显示的值
            cmbroomName.DisplayMember = "Description";
            //实际值
            cmbroomName.ValueMember = "RoomID";


            if (isTrans)
            {
                cmbroomName.SelectedValue = roomValue;
            }

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            GuestRecord gu = new GuestRecord();
            gu.IdentityID = txtidentityID.Text.Trim();
            gu.GuestName = txtguestName.Text.Trim();
            gu.RoomID = Convert.ToInt32(cmbroomName.SelectedValue);
            gu.Deposit =Convert.ToDecimal( txtdeposit.Text.Trim());
            gu.ResideDate =Convert.ToDateTime( dtpResideDate.Text);
            int num= GuestRecordManager.InsertGuestRecord(gu);
            if (num>0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }


        }
    }
}
