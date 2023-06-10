namespace LibManagement
{
    partial class FindTicketForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.cbxOption = new System.Windows.Forms.ComboBox();
            this.dgvFindTicket = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFind = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(331, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Từ khóa:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = global::LibManagement.Properties.Resources.icons8_exit_32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(760, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 39);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Image = global::LibManagement.Properties.Resources.search;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(760, 111);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(130, 39);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(424, 117);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(281, 26);
            this.txtFind.TabIndex = 9;
            // 
            // cbxOption
            // 
            this.cbxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxOption.FormattingEnabled = true;
            this.cbxOption.Items.AddRange(new object[] {
            "Mã phiếu",
            "Mã sách",
            "Mã độc giả",
            "Ngày mượn",
            "Ngày trả"});
            this.cbxOption.Location = new System.Drawing.Point(165, 117);
            this.cbxOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOption.Name = "cbxOption";
            this.cbxOption.Size = new System.Drawing.Size(143, 28);
            this.cbxOption.TabIndex = 8;
            this.cbxOption.SelectedIndexChanged += new System.EventHandler(this.FindTicket_Load);
            // 
            // dgvFindTicket
            // 
            this.dgvFindTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFindTicket.Location = new System.Drawing.Point(0, 262);
            this.dgvFindTicket.Name = "dgvFindTicket";
            this.dgvFindTicket.RowHeadersWidth = 51;
            this.dgvFindTicket.RowTemplate.Height = 24;
            this.dgvFindTicket.Size = new System.Drawing.Size(932, 261);
            this.dgvFindTicket.TabIndex = 14;
            this.dgvFindTicket.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindTicket_CellContentDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(299, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tra cứu phiếu mượn sách";
            // 
            // dtpFind
            // 
            this.dtpFind.CustomFormat = "dd / MM / yyyy";
            this.dtpFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpFind.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFind.Location = new System.Drawing.Point(424, 113);
            this.dtpFind.Name = "dtpFind";
            this.dtpFind.Size = new System.Drawing.Size(200, 30);
            this.dtpFind.TabIndex = 16;
            // 
            // FindTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.dtpFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFindTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cbxOption);
            this.Name = "FindTicketForm";
            this.Text = "Tra cứu phiếu mượn";
            this.Load += new System.EventHandler(this.FindTicket_Load);
            this.SizeChanged += new System.EventHandler(this.FindTicketForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ComboBox cbxOption;
        private System.Windows.Forms.DataGridView dgvFindTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFind;
    }
}