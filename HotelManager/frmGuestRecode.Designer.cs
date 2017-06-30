namespace HotelManager
{
    partial class frmGuestRecode
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidentityID = new System.Windows.Forms.TextBox();
            this.txtguestName = new System.Windows.Forms.TextBox();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.cmbroomName = new System.Windows.Forms.ComboBox();
            this.dtpResideDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "押金：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "房间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "入住时间：";
            // 
            // txtidentityID
            // 
            this.txtidentityID.Location = new System.Drawing.Point(107, 35);
            this.txtidentityID.Name = "txtidentityID";
            this.txtidentityID.Size = new System.Drawing.Size(100, 21);
            this.txtidentityID.TabIndex = 5;
            // 
            // txtguestName
            // 
            this.txtguestName.Location = new System.Drawing.Point(107, 93);
            this.txtguestName.Name = "txtguestName";
            this.txtguestName.Size = new System.Drawing.Size(100, 21);
            this.txtguestName.TabIndex = 5;
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(107, 163);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(100, 21);
            this.txtdeposit.TabIndex = 5;
            // 
            // cmbroomName
            // 
            this.cmbroomName.FormattingEnabled = true;
            this.cmbroomName.Location = new System.Drawing.Point(107, 218);
            this.cmbroomName.Name = "cmbroomName";
            this.cmbroomName.Size = new System.Drawing.Size(121, 20);
            this.cmbroomName.TabIndex = 6;
            // 
            // dtpResideDate
            // 
            this.dtpResideDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpResideDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpResideDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpResideDate.Location = new System.Drawing.Point(107, 267);
            this.dtpResideDate.Name = "dtpResideDate";
            this.dtpResideDate.Size = new System.Drawing.Size(200, 21);
            this.dtpResideDate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGuestRecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpResideDate);
            this.Controls.Add(this.cmbroomName);
            this.Controls.Add(this.txtdeposit);
            this.Controls.Add(this.txtguestName);
            this.Controls.Add(this.txtidentityID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGuestRecode";
            this.Load += new System.EventHandler(this.frmGuestRecode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidentityID;
        private System.Windows.Forms.TextBox txtguestName;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.ComboBox cmbroomName;
        private System.Windows.Forms.DateTimePicker dtpResideDate;
        private System.Windows.Forms.Button button1;
    }
}