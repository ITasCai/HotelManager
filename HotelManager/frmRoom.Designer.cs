namespace HotelManager
{
    partial class frmRoom
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
            this.lblroomid = new System.Windows.Forms.Label();
            this.txtroomid = new System.Windows.Forms.TextBox();
            this.btnroomid = new System.Windows.Forms.Button();
            this.dgvroom = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grproom = new System.Windows.Forms.GroupBox();
            this.txtshow = new System.Windows.Forms.TextBox();
            this.cmbTypeName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBedNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnqx = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroom)).BeginInit();
            this.grproom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblroomid
            // 
            this.lblroomid.AutoSize = true;
            this.lblroomid.Location = new System.Drawing.Point(97, 27);
            this.lblroomid.Name = "lblroomid";
            this.lblroomid.Size = new System.Drawing.Size(53, 12);
            this.lblroomid.TabIndex = 0;
            this.lblroomid.Text = "房间号：";
            // 
            // txtroomid
            // 
            this.txtroomid.Location = new System.Drawing.Point(206, 24);
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.Size = new System.Drawing.Size(100, 21);
            this.txtroomid.TabIndex = 1;
            // 
            // btnroomid
            // 
            this.btnroomid.Location = new System.Drawing.Point(379, 24);
            this.btnroomid.Name = "btnroomid";
            this.btnroomid.Size = new System.Drawing.Size(75, 23);
            this.btnroomid.TabIndex = 2;
            this.btnroomid.Text = "查询";
            this.btnroomid.UseVisualStyleBackColor = true;
            this.btnroomid.Click += new System.EventHandler(this.btnroomid_Click);
            // 
            // dgvroom
            // 
            this.dgvroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.BedNum,
            this.Description,
            this.GuestNum,
            this.RoomTypeID,
            this.TypeName,
            this.RoomStateName});
            this.dgvroom.Location = new System.Drawing.Point(20, 63);
            this.dgvroom.Name = "dgvroom";
            this.dgvroom.RowTemplate.Height = 23;
            this.dgvroom.Size = new System.Drawing.Size(726, 150);
            this.dgvroom.TabIndex = 3;
            this.dgvroom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroom_CellContentClick);
            this.dgvroom.Click += new System.EventHandler(this.dgvroom_Click);
            // 
            // RoomID
            // 
            this.RoomID.DataPropertyName = "RoomID";
            this.RoomID.HeaderText = "房间号";
            this.RoomID.Name = "RoomID";
            // 
            // BedNum
            // 
            this.BedNum.DataPropertyName = "BedNum";
            this.BedNum.HeaderText = "床位数";
            this.BedNum.Name = "BedNum";
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "房间描述";
            this.Description.Name = "Description";
            // 
            // GuestNum
            // 
            this.GuestNum.DataPropertyName = "GuestNum";
            this.GuestNum.HeaderText = "客房数";
            this.GuestNum.Name = "GuestNum";
            // 
            // RoomTypeID
            // 
            this.RoomTypeID.DataPropertyName = "RoomTypeID";
            this.RoomTypeID.HeaderText = "房间类型编号";
            this.RoomTypeID.Name = "RoomTypeID";
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "房间类型";
            this.TypeName.Name = "TypeName";
            // 
            // RoomStateName
            // 
            this.RoomStateName.DataPropertyName = "RoomStateName";
            this.RoomStateName.HeaderText = "房间状态";
            this.RoomStateName.Name = "RoomStateName";
            // 
            // grproom
            // 
            this.grproom.Controls.Add(this.txtshow);
            this.grproom.Controls.Add(this.cmbTypeName);
            this.grproom.Controls.Add(this.label3);
            this.grproom.Controls.Add(this.txtBedNum);
            this.grproom.Controls.Add(this.label2);
            this.grproom.Controls.Add(this.label1);
            this.grproom.Location = new System.Drawing.Point(33, 248);
            this.grproom.Name = "grproom";
            this.grproom.Size = new System.Drawing.Size(713, 100);
            this.grproom.TabIndex = 4;
            this.grproom.TabStop = false;
            this.grproom.Text = "房间信息";
            // 
            // txtshow
            // 
            this.txtshow.Location = new System.Drawing.Point(73, 60);
            this.txtshow.Name = "txtshow";
            this.txtshow.Size = new System.Drawing.Size(394, 21);
            this.txtshow.TabIndex = 5;
            // 
            // cmbTypeName
            // 
            this.cmbTypeName.FormattingEnabled = true;
            this.cmbTypeName.Location = new System.Drawing.Point(346, 22);
            this.cmbTypeName.Name = "cmbTypeName";
            this.cmbTypeName.Size = new System.Drawing.Size(121, 20);
            this.cmbTypeName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "房间类型：";
            // 
            // txtBedNum
            // 
            this.txtBedNum.Location = new System.Drawing.Point(72, 22);
            this.txtBedNum.Name = "txtBedNum";
            this.txtBedNum.Size = new System.Drawing.Size(100, 21);
            this.txtBedNum.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "描述：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "床位数：";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(59, 352);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(206, 354);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 6;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(342, 355);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnqx
            // 
            this.btnqx.Location = new System.Drawing.Point(465, 352);
            this.btnqx.Name = "btnqx";
            this.btnqx.Size = new System.Drawing.Size(75, 23);
            this.btnqx.TabIndex = 8;
            this.btnqx.Text = "取消";
            this.btnqx.UseVisualStyleBackColor = true;
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(587, 353);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 9;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            // 
            // frmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 387);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnqx);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.grproom);
            this.Controls.Add(this.dgvroom);
            this.Controls.Add(this.btnroomid);
            this.Controls.Add(this.txtroomid);
            this.Controls.Add(this.lblroomid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoom";
            this.Text = "房间信息管理";
            this.Load += new System.EventHandler(this.frmRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvroom)).EndInit();
            this.grproom.ResumeLayout(false);
            this.grproom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblroomid;
        private System.Windows.Forms.TextBox txtroomid;
        private System.Windows.Forms.Button btnroomid;
        private System.Windows.Forms.DataGridView dgvroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomStateName;
        private System.Windows.Forms.GroupBox grproom;
        private System.Windows.Forms.TextBox txtshow;
        private System.Windows.Forms.ComboBox cmbTypeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBedNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnqx;
        private System.Windows.Forms.Button btnno;
    }
}