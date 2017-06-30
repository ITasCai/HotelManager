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
    public partial class frmRoom : Form
    {
        public frmRoom()
        {
            InitializeComponent();
        }

        private void frmRoom_Load(object sender, EventArgs e)
        {
            //不能自动创建列
            dgvroom.AutoGenerateColumns = false;
            getRoom();
            RoomtyoeName();
        }

        //根据房间编号查询所有信息
        private void getRoom() {
            IList<Room> list = RoomManager.GetRoomListByID(txtroomid.Text,"");
            dgvroom.DataSource = list;
        }

        private void btnroomid_Click(object sender, EventArgs e)
        {
            getRoom();
        }


        public void RoomtyoeName() {
            //创建数据集
            DataSet ds = new DataSet();
            ds = RoomTypeManager.GetAllRoomTypeList();

            DataRow row = ds.Tables[0].NewRow();
            row[0] = -1;
            row[1] = "--请选择--";
            //向第一回添加请选择
            ds.Tables[0].Rows.InsertAt(row,0);
            //指定数据源
            cmbTypeName.DataSource = ds.Tables[0];

            //显示的值
            cmbTypeName.DisplayMember = "TypeName";
            //实际值
            cmbTypeName.ValueMember = "TypeID";
        }

        //加验证

        private void Check() {
            if (txtBedNum.Text.Trim()=="")
            {
                MessageBox.Show("请输入床位数！");
                txtBedNum.Focus();
                return;
            }
            if (txtshow.Text.Trim() == "")
            {
                MessageBox.Show("请输入描述内容！");
                txtBedNum.Focus();
                return;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Check();
            Room rm = new Room();
            rm.BedNum =Convert.ToInt32( txtBedNum.Text.Trim());
            rm.RoomTypeID =Convert.ToInt32(cmbTypeName.SelectedValue);
            rm.Description = txtshow.Text.Trim();
            RoomManager.InserRoom(rm);
            MessageBox.Show("添加成功");
            getRoom();

        }

        private void dgvroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        //修改
        private void btnxg_Click(object sender, EventArgs e)
        {
            Check();
            int index = dgvroom.CurrentCell.RowIndex;
            Room rm = new Room();
            rm.RoomID = Convert.ToInt32( dgvroom.Rows[index].Cells[0].Value.ToString());
            rm.BedNum = Convert.ToInt32(txtBedNum.Text.Trim());
            rm.RoomTypeID = Convert.ToInt32(cmbTypeName.SelectedValue);
            rm.Description = txtshow.Text.Trim();
            RoomManager.UpdateRoom(rm);
            MessageBox.Show("修改成功");
            getRoom();

        }

        private void dgvroom_Click(object sender, EventArgs e)
        {
            int index = dgvroom.CurrentCell.RowIndex;
            txtBedNum.Text = dgvroom.Rows[index].Cells[1].Value.ToString();
            cmbTypeName.Text = dgvroom.Rows[index].Cells[5].Value.ToString();
            txtshow.Text = dgvroom.Rows[index].Cells[2].Value.ToString();
        }
    }
}
