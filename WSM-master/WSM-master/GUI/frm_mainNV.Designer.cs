namespace DOAN_QLBH.GUI
{
    partial class frm_mainNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_NCC = new System.Windows.Forms.Button();
            this.BTN_KH = new System.Windows.Forms.Button();
            this.BTN_LK = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_DX = new System.Windows.Forms.Button();
            this.hanghoaTableAdapter1 = new DOAN_QLBH.DataSet1TableAdapters.HANGHOATableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_PK = new System.Windows.Forms.Button();
            this.BTN_PH = new System.Windows.Forms.Button();
            this.BTN_DH = new System.Windows.Forms.Button();
            this.BTN_BH = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.BTN_NCC);
            this.groupBox1.Controls.Add(this.BTN_KH);
            this.groupBox1.Controls.Add(this.BTN_LK);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(366, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // BTN_NCC
            // 
            this.BTN_NCC.Location = new System.Drawing.Point(70, 199);
            this.BTN_NCC.Name = "BTN_NCC";
            this.BTN_NCC.Size = new System.Drawing.Size(181, 57);
            this.BTN_NCC.TabIndex = 2;
            this.BTN_NCC.Text = "Nhà Cung Cấp";
            this.BTN_NCC.UseVisualStyleBackColor = true;
            this.BTN_NCC.Click += new System.EventHandler(this.BTN_NCC_Click);
            // 
            // BTN_KH
            // 
            this.BTN_KH.Location = new System.Drawing.Point(70, 123);
            this.BTN_KH.Name = "BTN_KH";
            this.BTN_KH.Size = new System.Drawing.Size(181, 53);
            this.BTN_KH.TabIndex = 1;
            this.BTN_KH.Text = "Khách Hàng";
            this.BTN_KH.UseVisualStyleBackColor = true;
            this.BTN_KH.Click += new System.EventHandler(this.BTN_KH_Click);
            // 
            // BTN_LK
            // 
            this.BTN_LK.Location = new System.Drawing.Point(70, 43);
            this.BTN_LK.Name = "BTN_LK";
            this.BTN_LK.Size = new System.Drawing.Size(181, 54);
            this.BTN_LK.TabIndex = 0;
            this.BTN_LK.Text = "Linh Kiện";
            this.BTN_LK.UseVisualStyleBackColor = true;
            this.BTN_LK.Click += new System.EventHandler(this.BTN_LK_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.giaoDịchToolStripMenuItem,
            this.hệThốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.linhKiệnToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý ";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.BTN_KH_Click);
            // 
            // linhKiệnToolStripMenuItem
            // 
            this.linhKiệnToolStripMenuItem.Name = "linhKiệnToolStripMenuItem";
            this.linhKiệnToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.linhKiệnToolStripMenuItem.Text = "Linh Kiện";
            this.linhKiệnToolStripMenuItem.Click += new System.EventHandler(this.BTN_LK_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà Cung Cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.BTN_NCC_Click);
            // 
            // giaoDịchToolStripMenuItem
            // 
            this.giaoDịchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHàngToolStripMenuItem});
            this.giaoDịchToolStripMenuItem.Name = "giaoDịchToolStripMenuItem";
            this.giaoDịchToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.giaoDịchToolStripMenuItem.Text = "Giao Dịch";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.bánHàngToolStripMenuItem.Text = "Bán Hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.BTN_THOAT_Click);
            // 
            // BTN_DX
            // 
            this.BTN_DX.BackColor = System.Drawing.Color.Salmon;
            this.BTN_DX.Location = new System.Drawing.Point(565, 405);
            this.BTN_DX.Name = "BTN_DX";
            this.BTN_DX.Size = new System.Drawing.Size(119, 41);
            this.BTN_DX.TabIndex = 2;
            this.BTN_DX.Text = "Đăng Xuất";
            this.BTN_DX.UseVisualStyleBackColor = false;
            this.BTN_DX.Click += new System.EventHandler(this.BTN_THOAT_Click);
            // 
            // hanghoaTableAdapter1
            // 
            this.hanghoaTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.BTN_PK);
            this.groupBox2.Controls.Add(this.BTN_PH);
            this.groupBox2.Controls.Add(this.BTN_DH);
            this.groupBox2.Controls.Add(this.BTN_BH);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(12, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 406);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giao dịch";
            // 
            // BTN_PK
            // 
            this.BTN_PK.Location = new System.Drawing.Point(31, 333);
            this.BTN_PK.Name = "BTN_PK";
            this.BTN_PK.Size = new System.Drawing.Size(280, 51);
            this.BTN_PK.TabIndex = 3;
            this.BTN_PK.Text = "Phiếu kiểm";
            this.BTN_PK.UseVisualStyleBackColor = true;
            // 
            // BTN_PH
            // 
            this.BTN_PH.Location = new System.Drawing.Point(31, 246);
            this.BTN_PH.Name = "BTN_PH";
            this.BTN_PH.Size = new System.Drawing.Size(280, 51);
            this.BTN_PH.TabIndex = 2;
            this.BTN_PH.Text = "Phiếu hẹn";
            this.BTN_PH.UseVisualStyleBackColor = true;
            // 
            // BTN_DH
            // 
            this.BTN_DH.Location = new System.Drawing.Point(31, 161);
            this.BTN_DH.Name = "BTN_DH";
            this.BTN_DH.Size = new System.Drawing.Size(280, 51);
            this.BTN_DH.TabIndex = 1;
            this.BTN_DH.Text = "Đặt hàng";
            this.BTN_DH.UseVisualStyleBackColor = true;
            // 
            // BTN_BH
            // 
            this.BTN_BH.Location = new System.Drawing.Point(31, 71);
            this.BTN_BH.Name = "BTN_BH";
            this.BTN_BH.Size = new System.Drawing.Size(280, 51);
            this.BTN_BH.TabIndex = 0;
            this.BTN_BH.Text = "Bán hàng";
            this.BTN_BH.UseVisualStyleBackColor = true;
            this.BTN_BH.Click += new System.EventHandler(this.BTN_BH_Click);
            // 
            // frm_mainNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 458);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_DX);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frm_mainNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chủ";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button BTN_NCC;
        private System.Windows.Forms.Button BTN_KH;
        private System.Windows.Forms.Button BTN_LK;
        private System.Windows.Forms.Button BTN_DX;
        private DataSet1TableAdapters.HANGHOATableAdapter hanghoaTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_PK;
        private System.Windows.Forms.Button BTN_PH;
        private System.Windows.Forms.Button BTN_DH;
        private System.Windows.Forms.Button BTN_BH;
    }
}