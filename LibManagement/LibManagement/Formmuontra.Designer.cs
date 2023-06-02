namespace WindowsFormsApplication1
{
    partial class Formmuontra
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.luu = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.comnhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comdocgia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmaphieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.commaphieumuon = new System.Windows.Forms.ComboBox();
            this.commasach = new System.Windows.Forms.ComboBox();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.ngaytra = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ghichu = new System.Windows.Forms.RichTextBox();
            this.luoi1 = new System.Windows.Forms.DataGridView();
            this.them1 = new System.Windows.Forms.Button();
            this.sua1 = new System.Windows.Forms.Button();
            this.xoa1 = new System.Windows.Forms.Button();
            this.luu1 = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(24, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.luu);
            this.tab1.Controls.Add(this.thoat);
            this.tab1.Controls.Add(this.xoa);
            this.tab1.Controls.Add(this.sua);
            this.tab1.Controls.Add(this.them);
            this.tab1.Controls.Add(this.luoi);
            this.tab1.Controls.Add(this.comnhanvien);
            this.tab1.Controls.Add(this.label5);
            this.tab1.Controls.Add(this.comdocgia);
            this.tab1.Controls.Add(this.label4);
            this.tab1.Controls.Add(this.txtmaphieu);
            this.tab1.Controls.Add(this.label3);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(694, 479);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "Lập phiếu mượn";
            this.tab1.UseVisualStyleBackColor = true;
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // luu
            // 
            this.luu.Enabled = false;
            this.luu.Location = new System.Drawing.Point(486, 49);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(75, 31);
            this.luu.TabIndex = 46;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(486, 103);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 31);
            this.thoat.TabIndex = 45;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(378, 160);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 31);
            this.xoa.TabIndex = 44;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(376, 101);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 29);
            this.sua.TabIndex = 43;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(378, 46);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(73, 29);
            this.them.TabIndex = 42;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(35, 231);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(352, 199);
            this.luoi.TabIndex = 26;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            this.luoi.SelectionChanged += new System.EventHandler(this.luoi_SelectionChanged);
            // 
            // comnhanvien
            // 
            this.comnhanvien.FormattingEnabled = true;
            this.comnhanvien.Location = new System.Drawing.Point(210, 170);
            this.comnhanvien.Name = "comnhanvien";
            this.comnhanvien.Size = new System.Drawing.Size(121, 21);
            this.comnhanvien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(31, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Người lập phiếu";
            // 
            // comdocgia
            // 
            this.comdocgia.FormattingEnabled = true;
            this.comdocgia.Location = new System.Drawing.Point(210, 113);
            this.comdocgia.Name = "comdocgia";
            this.comdocgia.Size = new System.Drawing.Size(121, 21);
            this.comdocgia.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã độc giả";
            // 
            // txtmaphieu
            // 
            this.txtmaphieu.Location = new System.Drawing.Point(210, 61);
            this.txtmaphieu.Name = "txtmaphieu";
            this.txtmaphieu.Size = new System.Drawing.Size(121, 20);
            this.txtmaphieu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(31, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(206, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TẠO PHIẾU MƯỢN";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.label12);
            this.tab2.Controls.Add(this.l);
            this.tab2.Controls.Add(this.luu1);
            this.tab2.Controls.Add(this.xoa1);
            this.tab2.Controls.Add(this.sua1);
            this.tab2.Controls.Add(this.them1);
            this.tab2.Controls.Add(this.luoi1);
            this.tab2.Controls.Add(this.ghichu);
            this.tab2.Controls.Add(this.label11);
            this.tab2.Controls.Add(this.ngaytra);
            this.tab2.Controls.Add(this.label6);
            this.tab2.Controls.Add(this.ngaymuon);
            this.tab2.Controls.Add(this.commasach);
            this.tab2.Controls.Add(this.commaphieumuon);
            this.tab2.Controls.Add(this.label8);
            this.tab2.Controls.Add(this.label9);
            this.tab2.Controls.Add(this.label10);
            this.tab2.Controls.Add(this.label7);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(694, 479);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Chi tiết mượn-trả";
            this.tab2.UseVisualStyleBackColor = true;
            this.tab2.Click += new System.EventHandler(this.tab2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(305, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lí Mượn Trả Sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(273, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chi tiết mượn - trả  sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(6, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày mượn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(318, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Mã sách";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mã phiếu mượn";
            // 
            // commaphieumuon
            // 
            this.commaphieumuon.FormattingEnabled = true;
            this.commaphieumuon.Location = new System.Drawing.Point(165, 88);
            this.commaphieumuon.Name = "commaphieumuon";
            this.commaphieumuon.Size = new System.Drawing.Size(121, 21);
            this.commaphieumuon.TabIndex = 11;
            // 
            // commasach
            // 
            this.commasach.FormattingEnabled = true;
            this.commasach.Location = new System.Drawing.Point(451, 86);
            this.commasach.Name = "commasach";
            this.commasach.Size = new System.Drawing.Size(121, 21);
            this.commasach.TabIndex = 12;
            // 
            // ngaymuon
            // 
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaymuon.Location = new System.Drawing.Point(164, 138);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(121, 20);
            this.ngaymuon.TabIndex = 13;
            this.ngaymuon.Value = new System.DateTime(2020, 8, 11, 23, 36, 38, 0);
            // 
            // ngaytra
            // 
            this.ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaytra.Location = new System.Drawing.Point(451, 140);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(121, 20);
            this.ngaytra.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(318, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày hẹn trả";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(6, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tình trạng sách";
            // 
            // ghichu
            // 
            this.ghichu.Location = new System.Drawing.Point(167, 183);
            this.ghichu.Name = "ghichu";
            this.ghichu.Size = new System.Drawing.Size(412, 47);
            this.ghichu.TabIndex = 17;
            this.ghichu.Text = "";
            // 
            // luoi1
            // 
            this.luoi1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi1.Location = new System.Drawing.Point(82, 329);
            this.luoi1.Name = "luoi1";
            this.luoi1.Size = new System.Drawing.Size(553, 150);
            this.luoi1.TabIndex = 18;
            this.luoi1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi1_CellContentClick);
            this.luoi1.SelectionChanged += new System.EventHandler(this.luoi1_SelectionChanged);
            // 
            // them1
            // 
            this.them1.Location = new System.Drawing.Point(121, 247);
            this.them1.Name = "them1";
            this.them1.Size = new System.Drawing.Size(75, 32);
            this.them1.TabIndex = 19;
            this.them1.Text = "Thêm ";
            this.them1.UseVisualStyleBackColor = true;
            this.them1.Click += new System.EventHandler(this.them1_Click);
            // 
            // sua1
            // 
            this.sua1.Location = new System.Drawing.Point(242, 247);
            this.sua1.Name = "sua1";
            this.sua1.Size = new System.Drawing.Size(75, 32);
            this.sua1.TabIndex = 20;
            this.sua1.Text = "Gia hạn";
            this.sua1.UseVisualStyleBackColor = true;
            this.sua1.Click += new System.EventHandler(this.sua1_Click);
            // 
            // xoa1
            // 
            this.xoa1.Location = new System.Drawing.Point(353, 247);
            this.xoa1.Name = "xoa1";
            this.xoa1.Size = new System.Drawing.Size(75, 32);
            this.xoa1.TabIndex = 21;
            this.xoa1.Text = "Trả sách";
            this.xoa1.UseVisualStyleBackColor = true;
            this.xoa1.Click += new System.EventHandler(this.xoa1_Click);
            // 
            // luu1
            // 
            this.luu1.Location = new System.Drawing.Point(462, 247);
            this.luu1.Name = "luu1";
            this.luu1.Size = new System.Drawing.Size(75, 32);
            this.luu1.TabIndex = 22;
            this.luu1.Text = "Lưu";
            this.luu1.UseVisualStyleBackColor = true;
            this.luu1.Click += new System.EventHandler(this.luu1_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.ForeColor = System.Drawing.Color.Red;
            this.l.Location = new System.Drawing.Point(285, 310);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(44, 13);
            this.l.TabIndex = 23;
            this.l.Text = "soluong";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tổng số quyển sách độc giả đang mượn";
            // 
            // Formmuontra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Formmuontra";
            this.Text = "Mượn trả sách";
            this.Load += new System.EventHandler(this.Formmuontra_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comnhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comdocgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmaphieu;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox commasach;
        private System.Windows.Forms.ComboBox commaphieumuon;
        private System.Windows.Forms.DateTimePicker ngaytra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox ghichu;
        private System.Windows.Forms.Button them1;
        private System.Windows.Forms.DataGridView luoi1;
        private System.Windows.Forms.Button sua1;
        private System.Windows.Forms.Button xoa1;
        private System.Windows.Forms.Button luu1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label12;
    }
}