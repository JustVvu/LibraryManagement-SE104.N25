namespace LibManagement
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtpReport = new System.Windows.Forms.DateTimePicker();
            this.txtTopBook = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExpiredReader = new System.Windows.Forms.TextBox();
            this.txtLentBook = new System.Windows.Forms.TextBox();
            this.txtReturnedBook = new System.Windows.Forms.TextBox();
            this.txtNewReader = new System.Windows.Forms.TextBox();
            this.txtTotalReader = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quanlythuvienDataSet1 = new LibManagement.QUANLYTHUVIENDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlythuvienDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 56);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Báo cáo thông tin thư viện";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.dtpReport);
            this.groupBox1.Controls.Add(this.txtTopBook);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtExpiredReader);
            this.groupBox1.Controls.Add(this.txtLentBook);
            this.groupBox1.Controls.Add(this.txtReturnedBook);
            this.groupBox1.Controls.Add(this.txtNewReader);
            this.groupBox1.Controls.Add(this.txtTotalReader);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 452);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(644, 42);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.Location = new System.Drawing.Point(457, 42);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(163, 38);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Xem báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtpReport
            // 
            this.dtpReport.CustomFormat = "MM / yyyy";
            this.dtpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReport.Location = new System.Drawing.Point(264, 49);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(162, 30);
            this.dtpReport.TabIndex = 14;
            // 
            // txtTopBook
            // 
            this.txtTopBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTopBook.Location = new System.Drawing.Point(404, 341);
            this.txtTopBook.Multiline = true;
            this.txtTopBook.Name = "txtTopBook";
            this.txtTopBook.Size = new System.Drawing.Size(240, 30);
            this.txtTopBook.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(36, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sách mượn nhiều nhất:";
            // 
            // txtExpiredReader
            // 
            this.txtExpiredReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtExpiredReader.Location = new System.Drawing.Point(404, 221);
            this.txtExpiredReader.Name = "txtExpiredReader";
            this.txtExpiredReader.Size = new System.Drawing.Size(240, 30);
            this.txtExpiredReader.TabIndex = 11;
            // 
            // txtLentBook
            // 
            this.txtLentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLentBook.Location = new System.Drawing.Point(404, 261);
            this.txtLentBook.Name = "txtLentBook";
            this.txtLentBook.Size = new System.Drawing.Size(240, 30);
            this.txtLentBook.TabIndex = 10;
            // 
            // txtReturnedBook
            // 
            this.txtReturnedBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtReturnedBook.Location = new System.Drawing.Point(404, 299);
            this.txtReturnedBook.Name = "txtReturnedBook";
            this.txtReturnedBook.Size = new System.Drawing.Size(240, 30);
            this.txtReturnedBook.TabIndex = 9;
            // 
            // txtNewReader
            // 
            this.txtNewReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewReader.Location = new System.Drawing.Point(404, 181);
            this.txtNewReader.Name = "txtNewReader";
            this.txtNewReader.Size = new System.Drawing.Size(240, 30);
            this.txtNewReader.TabIndex = 8;
            // 
            // txtTotalReader
            // 
            this.txtTotalReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalReader.Location = new System.Drawing.Point(404, 137);
            this.txtTotalReader.Name = "txtTotalReader";
            this.txtTotalReader.Size = new System.Drawing.Size(240, 30);
            this.txtTotalReader.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(36, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng số độc giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(36, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số độc giả đăng kí mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số độc giả hết hạn thành viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(36, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số sách đã trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(36, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số sách đã mượn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Báo cáo theo tháng:";
            // 
            // quanlythuvienDataSet1
            // 
            this.quanlythuvienDataSet1.DataSetName = "QUANLYTHUVIENDataSet";
            this.quanlythuvienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Thống kê";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportForm_FormClosed);
            this.Load += new System.EventHandler(this.Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanlythuvienDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QUANLYTHUVIENDataSet quanlythuvienDataSet1;
        private System.Windows.Forms.TextBox txtExpiredReader;
        private System.Windows.Forms.TextBox txtLentBook;
        private System.Windows.Forms.TextBox txtReturnedBook;
        private System.Windows.Forms.TextBox txtNewReader;
        private System.Windows.Forms.TextBox txtTotalReader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTopBook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
    }
}