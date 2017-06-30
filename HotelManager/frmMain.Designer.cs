namespace HotelManager
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspfjlx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsproom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsprzdj = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuestRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.tsprzxyck = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础设置ToolStripMenuItem,
            this.tsmGuest});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础设置ToolStripMenuItem
            // 
            this.基础设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspfjlx,
            this.tsproom});
            this.基础设置ToolStripMenuItem.Name = "基础设置ToolStripMenuItem";
            this.基础设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基础设置ToolStripMenuItem.Text = "基础设置";
            // 
            // tspfjlx
            // 
            this.tspfjlx.Name = "tspfjlx";
            this.tspfjlx.Size = new System.Drawing.Size(148, 22);
            this.tspfjlx.Text = "房间类型登记";
            this.tspfjlx.Click += new System.EventHandler(this.tspfjlx_Click);
            // 
            // tsproom
            // 
            this.tsproom.Name = "tsproom";
            this.tsproom.Size = new System.Drawing.Size(148, 22);
            this.tsproom.Text = "房间信息登记";
            this.tsproom.Click += new System.EventHandler(this.tsproom_Click);
            // 
            // tsmGuest
            // 
            this.tsmGuest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsprzdj,
            this.tsmGuestRecord,
            this.tsprzxyck});
            this.tsmGuest.Name = "tsmGuest";
            this.tsmGuest.Size = new System.Drawing.Size(68, 21);
            this.tsmGuest.Text = "业务管理";
            // 
            // tsprzdj
            // 
            this.tsprzdj.Name = "tsprzdj";
            this.tsprzdj.Size = new System.Drawing.Size(152, 22);
            this.tsprzdj.Text = "入住登记";
            this.tsprzdj.Click += new System.EventHandler(this.tsprzdj_Click);
            // 
            // tsmGuestRecord
            // 
            this.tsmGuestRecord.Name = "tsmGuestRecord";
            this.tsmGuestRecord.Size = new System.Drawing.Size(152, 22);
            this.tsmGuestRecord.Text = "房间状态查看";
            this.tsmGuestRecord.Click += new System.EventHandler(this.tsmGuestRecord_Click);
            // 
            // tsprzxyck
            // 
            this.tsprzxyck.Name = "tsprzxyck";
            this.tsprzxyck.Size = new System.Drawing.Size(152, 22);
            this.tsprzxyck.Text = "入住信息查看";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspfjlx;
        private System.Windows.Forms.ToolStripMenuItem tsproom;
        private System.Windows.Forms.ToolStripMenuItem tsmGuest;
        private System.Windows.Forms.ToolStripMenuItem tsprzdj;
        private System.Windows.Forms.ToolStripMenuItem tsmGuestRecord;
        private System.Windows.Forms.ToolStripMenuItem tsprzxyck;
    }
}