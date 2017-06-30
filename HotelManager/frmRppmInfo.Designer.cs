namespace HotelManager
{
    partial class frmRppmInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRppmInfo));
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.tvRoom = new System.Windows.Forms.TreeView();
            this.lvwRooms = new System.Windows.Forms.ListView();
            this.imglist = new System.Windows.Forms.ImageList(this.components);
            this.grpRoomType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.tvRoom);
            this.grpRoomType.Location = new System.Drawing.Point(12, 12);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(142, 350);
            this.grpRoomType.TabIndex = 0;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "房间类型列表";
            // 
            // tvRoom
            // 
            this.tvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRoom.Location = new System.Drawing.Point(3, 17);
            this.tvRoom.Name = "tvRoom";
            this.tvRoom.Size = new System.Drawing.Size(136, 330);
            this.tvRoom.TabIndex = 0;
            this.tvRoom.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRoom_AfterSelect);
            // 
            // lvwRooms
            // 
            this.lvwRooms.LargeImageList = this.imglist;
            this.lvwRooms.Location = new System.Drawing.Point(190, 29);
            this.lvwRooms.Name = "lvwRooms";
            this.lvwRooms.Size = new System.Drawing.Size(292, 333);
            this.lvwRooms.TabIndex = 1;
            this.lvwRooms.UseCompatibleStateImageBehavior = false;
            this.lvwRooms.DoubleClick += new System.EventHandler(this.lvwRooms_DoubleClick);
            // 
            // imglist
            // 
            this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
            this.imglist.TransparentColor = System.Drawing.Color.Transparent;
            this.imglist.Images.SetKeyName(0, "icon_information_32x.gif");
            this.imglist.Images.SetKeyName(1, "icon_warning_32x.gif");
            // 
            // frmRppmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 374);
            this.Controls.Add(this.lvwRooms);
            this.Controls.Add(this.grpRoomType);
            this.Name = "frmRppmInfo";
            this.Text = "房间类型列表";
            this.Load += new System.EventHandler(this.frmRppmInfo_Load);
            this.grpRoomType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.TreeView tvRoom;
        private System.Windows.Forms.ListView lvwRooms;
        private System.Windows.Forms.ImageList imglist;
    }
}