﻿namespace LibManagement
{
    partial class FindBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBookForm));
            this.cbxOption = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBookFind = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookFind)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxOption
            // 
            this.cbxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxOption.FormattingEnabled = true;
            this.cbxOption.Items.AddRange(new object[] {
            "Mã sách",
            "Tên sách",
            "Tác giả",
            "Nhà xuất bản",
            "Thể loại",
            "Năm xuất bản"});
            this.cbxOption.Location = new System.Drawing.Point(165, 117);
            this.cbxOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOption.Name = "cbxOption";
            this.cbxOption.Size = new System.Drawing.Size(143, 28);
            this.cbxOption.TabIndex = 0;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(424, 117);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(281, 26);
            this.txtFind.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(388, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tra cứu sách";
            // 
            // dgvBookFind
            // 
            this.dgvBookFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBookFind.Location = new System.Drawing.Point(0, 262);
            this.dgvBookFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBookFind.Name = "dgvBookFind";
            this.dgvBookFind.RowHeadersWidth = 51;
            this.dgvBookFind.RowTemplate.Height = 24;
            this.dgvBookFind.Size = new System.Drawing.Size(932, 261);
            this.dgvBookFind.TabIndex = 6;
            this.dgvBookFind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookFind_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(331, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ khóa:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(760, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(760, 111);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(131, 39);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBookFind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cbxOption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindBookForm";
            this.Text = "Tra cứu Sách";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindBookForm_FormClosed);
            this.Load += new System.EventHandler(this.FindBookForm_Load);
            this.SizeChanged += new System.EventHandler(this.FindBookForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxOption;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvBookFind;
        private System.Windows.Forms.Label label3;
    }
}