namespace HotelManager
{
    partial class frmRoomType
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
            this.grpRoomTypeName = new System.Windows.Forms.GroupBox();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.btnTypeName = new System.Windows.Forms.Button();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTypeRoom = new System.Windows.Forms.GroupBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnqx = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.grpRoomTypeName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.grpTypeRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRoomTypeName
            // 
            this.grpRoomTypeName.Controls.Add(this.btnTypeName);
            this.grpRoomTypeName.Controls.Add(this.txtTypeName);
            this.grpRoomTypeName.Controls.Add(this.lblTypeName);
            this.grpRoomTypeName.Location = new System.Drawing.Point(12, 12);
            this.grpRoomTypeName.Name = "grpRoomTypeName";
            this.grpRoomTypeName.Size = new System.Drawing.Size(483, 54);
            this.grpRoomTypeName.TabIndex = 0;
            this.grpRoomTypeName.TabStop = false;
            this.grpRoomTypeName.Enter += new System.EventHandler(this.grpRoomTypeName_Enter);
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Location = new System.Drawing.Point(82, 27);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(53, 12);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "类型名称";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Location = new System.Drawing.Point(156, 17);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(100, 21);
            this.txtTypeName.TabIndex = 1;
            // 
            // btnTypeName
            // 
            this.btnTypeName.Location = new System.Drawing.Point(284, 17);
            this.btnTypeName.Name = "btnTypeName";
            this.btnTypeName.Size = new System.Drawing.Size(75, 23);
            this.btnTypeName.TabIndex = 2;
            this.btnTypeName.Text = "查询";
            this.btnTypeName.UseVisualStyleBackColor = true;
            this.btnTypeName.Click += new System.EventHandler(this.btnTypeName_Click);
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeID,
            this.TypeName,
            this.TypePrice});
            this.dgvshow.Location = new System.Drawing.Point(12, 82);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.RowTemplate.Height = 23;
            this.dgvshow.Size = new System.Drawing.Size(483, 150);
            this.dgvshow.TabIndex = 1;
            this.dgvshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvshow_CellContentClick);
            this.dgvshow.Click += new System.EventHandler(this.dgvshow_Click);
            // 
            // TypeID
            // 
            this.TypeID.DataPropertyName = "TypeID";
            this.TypeID.HeaderText = "房间编号";
            this.TypeID.Name = "TypeID";
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "房间类型";
            this.TypeName.Name = "TypeName";
            // 
            // TypePrice
            // 
            this.TypePrice.DataPropertyName = "TypePrice";
            this.TypePrice.HeaderText = "价格";
            this.TypePrice.Name = "TypePrice";
            // 
            // grpTypeRoom
            // 
            this.grpTypeRoom.Controls.Add(this.btnno);
            this.grpTypeRoom.Controls.Add(this.btnqx);
            this.grpTypeRoom.Controls.Add(this.btndelete);
            this.grpTypeRoom.Controls.Add(this.btnxg);
            this.grpTypeRoom.Controls.Add(this.btnadd);
            this.grpTypeRoom.Controls.Add(this.txtprice);
            this.grpTypeRoom.Controls.Add(this.lblprice);
            this.grpTypeRoom.Controls.Add(this.txtname);
            this.grpTypeRoom.Controls.Add(this.lblname);
            this.grpTypeRoom.Location = new System.Drawing.Point(12, 253);
            this.grpTypeRoom.Name = "grpTypeRoom";
            this.grpTypeRoom.Size = new System.Drawing.Size(483, 100);
            this.grpTypeRoom.TabIndex = 2;
            this.grpTypeRoom.TabStop = false;
            this.grpTypeRoom.Text = "房间类型信息";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(26, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(77, 12);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "房间类型名称";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(108, 23);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(214, 26);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(29, 12);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "价格";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(284, 21);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 21);
            this.txtprice.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(19, 71);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(108, 70);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 5;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(199, 71);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnqx
            // 
            this.btnqx.Location = new System.Drawing.Point(294, 70);
            this.btnqx.Name = "btnqx";
            this.btnqx.Size = new System.Drawing.Size(75, 23);
            this.btnqx.TabIndex = 7;
            this.btnqx.Text = "取消";
            this.btnqx.UseVisualStyleBackColor = true;
            this.btnqx.Click += new System.EventHandler(this.btnqx_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(391, 70);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 8;
            this.btnno.Text = "退出";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // frmRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(507, 413);
            this.Controls.Add(this.grpTypeRoom);
            this.Controls.Add(this.dgvshow);
            this.Controls.Add(this.grpRoomTypeName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRoomType";
            this.Text = "房间类型管理";
            this.grpRoomTypeName.ResumeLayout(false);
            this.grpRoomTypeName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.grpTypeRoom.ResumeLayout(false);
            this.grpTypeRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRoomTypeName;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Button btnTypeName;
        private System.Windows.Forms.DataGridView dgvshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypePrice;
        private System.Windows.Forms.GroupBox grpTypeRoom;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Button btnqx;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.Button btnadd;
    }
}