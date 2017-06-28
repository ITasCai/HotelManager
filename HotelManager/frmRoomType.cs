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
using System.Data.SqlClient;
using HotelManagerCommon;
using HotelManagerModel;

namespace HotelManager
{
    public partial class frmRoomType : Form
    {
        public frmRoomType()
        {
            InitializeComponent();
            getAllRoomTyoe();
            
        }

        private void lblname_Click(object sender, EventArgs e)
        {
        }

        private void grpRoomTypeName_Enter(object sender, EventArgs e)
        {

        }

        //显示所有房间类型信息

        private void getAllRoomTyoe() {
            //定义数据集
            DataSet ds = new DataSet();

            ds = RoomTypeManager.GetAllRoomTypeList();
            //绑定数据源
            dgvshow.DataSource = ds.Tables[0];
        }

        private void btnTypeName_Click(object sender, EventArgs e)
        {
            getRoomTypeName();
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        public void getRoomTypeName() {
            //接收输入的类型
            string typename = txtTypeName.Text.Trim();
            dgvshow.DataSource = RoomTypeManager.GetRoomTypeListByName(typename);
            
        }

        public void Check()
        {
            string typename = txtname.Text;
            string price = txtprice.Text;
            if (string.IsNullOrEmpty(typename))
            {
                MessageBox.Show("房间类型名称不能为空", "提示");
                //获取鼠标焦点
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("房间价格不能为空", "提示");
                //获取鼠标焦点
                txtname.Focus();
             
            }

            if (!HotelManagerCommon.Check.IsNumber(price))
            {
                MessageBox.Show("输入的价格必须为数字","提示");
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                Check();
                //实例化实体对象
                RoomType rt = new RoomType();
                rt.TypeName = txtname.Text.Trim();
                rt.TypePrice = Convert.ToDecimal(txtprice.Text.Trim());
                //调用添加方法
                RoomTypeManager.AddRoomType(rt);
                getAllRoomTyoe();
                MessageBox.Show("添加成功");
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            try
            {
                Check();
                //实例化实体对象
                RoomType rt = new RoomType();
                //把dgvshow行中列名TypeID的值赋给TypeID
                rt.TypeID =Convert.ToInt32( dgvshow.CurrentRow.Cells["TypeID"].Value);
                
                rt.TypeName = txtname.Text.Trim();
                rt.TypePrice = Convert.ToDecimal(txtprice.Text.Trim());
                //调用添加方法
                RoomTypeManager.UpdateRoomType(rt);
                getAllRoomTyoe();
                MessageBox.Show("修改成功");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgvshow.SelectedCells.Count==0)
            {
                return;
            }
            if (DialogResult.Yes==MessageBox.Show("你确定要删除吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning))
            {
                int roomTypeid = Convert.ToInt32(dgvshow.CurrentRow.Cells["TypeID"].Value);
                if (RoomTypeManager.DeleteRoomType(roomTypeid)>0)
                {
                    MessageBox.Show("删除成功");
                    getAllRoomTyoe();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnqx_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtprice.Text ="";
            txtTypeName.Text = "";
        }

        private void dgvshow_Click(object sender, EventArgs e)
        {
            //取下标
            int index = dgvshow.CurrentCell.RowIndex;
            txtname.Text = dgvshow.Rows[index].Cells[1].Value.ToString();
            txtprice.Text = dgvshow.Rows[index].Cells[2].Value.ToString();
        }
    }
}
