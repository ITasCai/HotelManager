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
    public partial class frmRppmInfo : Form
    {
        public frmRppmInfo()
        {
            InitializeComponent();
        }

        private void frmRppmInfo_Load(object sender, EventArgs e)
        {
            //添加树形菜单
            DataSet ds = new DataSet();
            //获取房间类型
            ds = RoomTypeManager.GetAllRoomTypeList();
            //创建根节点
            TreeNode root = new TreeNode();
            root.Text = "房间类型";
            tvRoom.Nodes.Add(root);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //创建子节点对象
                TreeNode tr = new TreeNode();
                //显示字节点的文本 
                tr.Text = ds.Tables[0].Rows[i]["TypeName"].ToString();
                //保存子节点对应节点的值
                tr.Tag=int.Parse(ds.Tables[0].Rows[i]["TypeID"].ToString());

                //添加子子节点
                root.Nodes.Add(tr);
              
            }
            tvRoom.Nodes.Add(root);
        }

        private void tvRoom_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //定义变量接收选定节点的值
            int roomTypeID = Convert.ToInt32(this.tvRoom.SelectedNode.Tag);
            IList<Room> rooms = RoomManager.GetRoomListByID(null,roomTypeID.ToString());
            this.lvwRooms.Items.Clear();
            foreach (Room rn in rooms)
            {

              
                ListViewItem item = new ListViewItem();
                //显示节点的文本
                item.Text = rn.RoomID.ToString();
                if (rn.RoomStateID==1)
                {
                    item.ImageIndex = 0;
                }
                else if (rn.RoomStateID == 2)
                {
                    item.ImageIndex = 1;
                }
                item.Tag = rn;
                this.lvwRooms.Items.Add(item);
            }
        }

        private void lvwRooms_DoubleClick(object sender, EventArgs e)
        {
            if (lvwRooms.SelectedItems.Count==0)
            {
                return;
            }
            //被选中的第一项值
             ListViewItem item = lvwRooms.SelectedItems[0];
            //对应节点的值
            Room rm = (Room)item.Tag;
            frmGuestRecode frm = new frmGuestRecode();
            frm.SetCmdInfo(rm.RoomID);
            frm.ShowDialog();
        }
    }
}
