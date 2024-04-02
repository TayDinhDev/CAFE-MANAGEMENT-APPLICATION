namespace QuanLiQuanCafeNew.Presentation
{
    partial class fr_DangNhap
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
			this.bt_Thoat = new System.Windows.Forms.Button();
			this.bt_OK = new System.Windows.Forms.Button();
			this.txt_Pass = new System.Windows.Forms.TextBox();
			this.txt_User = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// bt_Thoat
			// 
			this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_Thoat.Location = new System.Drawing.Point(204, 110);
			this.bt_Thoat.Name = "bt_Thoat";
			this.bt_Thoat.Size = new System.Drawing.Size(125, 37);
			this.bt_Thoat.TabIndex = 76;
			this.bt_Thoat.Text = "Exit";
			this.bt_Thoat.UseVisualStyleBackColor = true;
			this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
			// 
			// bt_OK
			// 
			this.bt_OK.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bt_OK.Location = new System.Drawing.Point(37, 110);
			this.bt_OK.Name = "bt_OK";
			this.bt_OK.Size = new System.Drawing.Size(125, 37);
			this.bt_OK.TabIndex = 77;
			this.bt_OK.Text = "OK";
			this.bt_OK.UseVisualStyleBackColor = true;
			this.bt_OK.Click += new System.EventHandler(this.cmddn_Click);
			// 
			// txt_Pass
			// 
			this.txt_Pass.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Pass.Location = new System.Drawing.Point(138, 61);
			this.txt_Pass.Name = "txt_Pass";
			this.txt_Pass.PasswordChar = '*';
			this.txt_Pass.Size = new System.Drawing.Size(214, 32);
			this.txt_Pass.TabIndex = 73;
			this.txt_Pass.Text = "admin";
			this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
			// 
			// txt_User
			// 
			this.txt_User.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_User.Location = new System.Drawing.Point(138, 22);
			this.txt_User.Name = "txt_User";
			this.txt_User.Size = new System.Drawing.Size(214, 32);
			this.txt_User.TabIndex = 72;
			this.txt_User.Text = "admin";
			this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 25);
			this.label3.TabIndex = 74;
			this.label3.Text = "Mật Khẩu";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(151, 25);
			this.label2.TabIndex = 75;
			this.label2.Text = "Tên Đăng Nhập";
			// 
			// fr_DangNhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 240);
			this.Controls.Add(this.bt_Thoat);
			this.Controls.Add(this.bt_OK);
			this.Controls.Add(this.txt_Pass);
			this.Controls.Add(this.txt_User);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "fr_DangNhap";
			this.Text = "fr_DangNhap";
			this.Load += new System.EventHandler(this.fr_DangNhap_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox txt_Pass;
	}
}