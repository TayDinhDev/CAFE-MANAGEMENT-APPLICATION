namespace QuanLiQuanCafeNew.Presentation
{
    partial class fr_Sanpham
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
            this.msds = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_TMoi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imghinhanh = new System.Windows.Forms.PictureBox();
            this.cb_MaCD = new System.Windows.Forms.ComboBox();
            this.cb_Loai = new System.Windows.Forms.ComboBox();
            this.txt_GC = new System.Windows.Forms.TextBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_DGB = new System.Windows.Forms.TextBox();
            this.txt_DGN = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbcd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbimgpath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imghinhanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msds
            // 
            this.msds.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.msds.Location = new System.Drawing.Point(504, 115);
            this.msds.Margin = new System.Windows.Forms.Padding(4);
            this.msds.Name = "msds";
            this.msds.RowHeadersWidth = 51;
            this.msds.Size = new System.Drawing.Size(531, 497);
            this.msds.TabIndex = 20;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.bt_Xoa);
            this.panel3.Controls.Add(this.bt_Sua);
            this.panel3.Controls.Add(this.bt_Luu);
            this.panel3.Controls.Add(this.bt_TMoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(504, 62);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 53);
            this.panel3.TabIndex = 19;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Xoa.Location = new System.Drawing.Point(409, 0);
            this.bt_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(120, 53);
            this.bt_Xoa.TabIndex = 3;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Sua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Sua.Location = new System.Drawing.Point(293, 0);
            this.bt_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(116, 53);
            this.bt_Sua.TabIndex = 2;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_Luu.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Luu.Location = new System.Drawing.Point(172, 0);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(121, 53);
            this.bt_Luu.TabIndex = 1;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Luu.UseVisualStyleBackColor = true;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_TMoi
            // 
            this.bt_TMoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_TMoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_TMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_TMoi.Location = new System.Drawing.Point(0, 0);
            this.bt_TMoi.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TMoi.Name = "bt_TMoi";
            this.bt_TMoi.Size = new System.Drawing.Size(172, 53);
            this.bt_TMoi.TabIndex = 0;
            this.bt_TMoi.Text = "Thêm Mới";
            this.bt_TMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_TMoi.UseVisualStyleBackColor = true;
            this.bt_TMoi.Click += new System.EventHandler(this.bt_TMoi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel2.Controls.Add(this.txt_Ngay);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.imghinhanh);
            this.panel2.Controls.Add(this.cb_MaCD);
            this.panel2.Controls.Add(this.cb_Loai);
            this.panel2.Controls.Add(this.txt_GC);
            this.panel2.Controls.Add(this.txt_SL);
            this.panel2.Controls.Add(this.txt_DGB);
            this.panel2.Controls.Add(this.txt_DGN);
            this.panel2.Controls.Add(this.txt_Ten);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_Ma);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbcd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.lbimgpath);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 550);
            this.panel2.TabIndex = 18;
            // 
            // txt_Ngay
            // 
            this.txt_Ngay.CustomFormat = "dd/MM/yyyy";
            this.txt_Ngay.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_Ngay.Location = new System.Drawing.Point(159, 319);
            this.txt_Ngay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ngay.Name = "txt_Ngay";
            this.txt_Ngay.Size = new System.Drawing.Size(313, 32);
            this.txt_Ngay.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày Sinh";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(396, 460);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xóa Hình";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm Hình";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imghinhanh
            // 
            this.imghinhanh.Location = new System.Drawing.Point(223, 388);
            this.imghinhanh.Margin = new System.Windows.Forms.Padding(4);
            this.imghinhanh.Name = "imghinhanh";
            this.imghinhanh.Size = new System.Drawing.Size(165, 135);
            this.imghinhanh.TabIndex = 6;
            this.imghinhanh.TabStop = false;
            // 
            // cb_MaCD
            // 
            this.cb_MaCD.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaCD.FormattingEnabled = true;
            this.cb_MaCD.Location = new System.Drawing.Point(156, 145);
            this.cb_MaCD.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MaCD.Name = "cb_MaCD";
            this.cb_MaCD.Size = new System.Drawing.Size(143, 31);
            this.cb_MaCD.TabIndex = 5;
            this.cb_MaCD.SelectedIndexChanged += new System.EventHandler(this.cb_MaCD_SelectedIndexChanged);
            // 
            // cb_Loai
            // 
            this.cb_Loai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Loai.FormattingEnabled = true;
            this.cb_Loai.Location = new System.Drawing.Point(156, 105);
            this.cb_Loai.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Loai.Name = "cb_Loai";
            this.cb_Loai.Size = new System.Drawing.Size(143, 31);
            this.cb_Loai.TabIndex = 5;
            this.cb_Loai.SelectedIndexChanged += new System.EventHandler(this.cb_Loai_SelectedIndexChanged);
            // 
            // txt_GC
            // 
            this.txt_GC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GC.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GC.Location = new System.Drawing.Point(13, 388);
            this.txt_GC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GC.Multiline = true;
            this.txt_GC.Name = "txt_GC";
            this.txt_GC.Size = new System.Drawing.Size(183, 136);
            this.txt_GC.TabIndex = 4;
            // 
            // txt_SL
            // 
            this.txt_SL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SL.Enabled = false;
            this.txt_SL.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SL.Location = new System.Drawing.Point(221, 278);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(251, 32);
            this.txt_SL.TabIndex = 4;
            // 
            // txt_DGB
            // 
            this.txt_DGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DGB.Enabled = false;
            this.txt_DGB.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DGB.Location = new System.Drawing.Point(156, 238);
            this.txt_DGB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DGB.Name = "txt_DGB";
            this.txt_DGB.Size = new System.Drawing.Size(316, 32);
            this.txt_DGB.TabIndex = 4;
            // 
            // txt_DGN
            // 
            this.txt_DGN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DGN.Enabled = false;
            this.txt_DGN.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DGN.Location = new System.Drawing.Point(156, 197);
            this.txt_DGN.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DGN.Name = "txt_DGN";
            this.txt_DGN.Size = new System.Drawing.Size(316, 32);
            this.txt_DGN.TabIndex = 4;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Ten.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten.Location = new System.Drawing.Point(156, 64);
            this.txt_Ten.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(316, 32);
            this.txt_Ten.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(261, 359);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 25);
            this.label14.TabIndex = 2;
            this.label14.Text = "Hình Ảnh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 287);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(176, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Số Lượng Hiện Có";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 361);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ghi Chú";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Đơn Giá Bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 201);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Đơn Giá Nhập";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Ma.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma.Location = new System.Drawing.Point(156, 20);
            this.txt_Ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.Size = new System.Drawing.Size(316, 32);
            this.txt_Ma.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Loại";
            // 
            // lbcd
            // 
            this.lbcd.AutoSize = true;
            this.lbcd.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcd.Location = new System.Drawing.Point(308, 149);
            this.lbcd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcd.Name = "lbcd";
            this.lbcd.Size = new System.Drawing.Size(33, 25);
            this.lbcd.TabIndex = 2;
            this.lbcd.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Mã Công Dụng";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(308, 108);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(33, 25);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "---";
            // 
            // lbimgpath
            // 
            this.lbimgpath.AutoSize = true;
            this.lbimgpath.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimgpath.Location = new System.Drawing.Point(8, -2);
            this.lbimgpath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbimgpath.Name = "lbimgpath";
            this.lbimgpath.Size = new System.Drawing.Size(121, 25);
            this.lbimgpath.TabIndex = 2;
            this.lbimgpath.Text = "C:\\\\temp.jpg";
            this.lbimgpath.Visible = false;
            this.lbimgpath.Click += new System.EventHandler(this.lbimgpath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 62);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(320, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // fr_Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 612);
            this.Controls.Add(this.msds);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fr_Sanpham";
            this.Text = "fr_Sanpham";
            this.Load += new System.EventHandler(this.fr_Sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imghinhanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView msds;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_TMoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txt_Ngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imghinhanh;
        private System.Windows.Forms.ComboBox cb_MaCD;
        private System.Windows.Forms.ComboBox cb_Loai;
        private System.Windows.Forms.TextBox txt_GC;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_DGB;
        private System.Windows.Forms.TextBox txt_DGN;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbcd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbimgpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}