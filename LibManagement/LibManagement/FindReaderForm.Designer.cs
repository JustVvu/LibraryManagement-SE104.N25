namespace LibManagement
{
    partial class FindReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindReaderForm));
            this.cbxOption = new System.Windows.Forms.ComboBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvFindReader = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.qUANLYTHUVIENDataSet = new LibManagement.QUANLYTHUVIENDataSet();
            this.qUANLYTHUVIENDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxOption
            // 
            this.cbxOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbxOption.FormattingEnabled = true;
            this.cbxOption.Items.AddRange(new object[] {
            "Mã độc giả",
            "Tên độc giả",
            "CMND/CCCD",
            "Số điện thoại"});
            this.cbxOption.Location = new System.Drawing.Point(170, 114);
            this.cbxOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOption.Name = "cbxOption";
            this.cbxOption.Size = new System.Drawing.Size(143, 28);
            this.cbxOption.TabIndex = 0;
            // 
            // txtFind
            // 
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtFind.Location = new System.Drawing.Point(427, 113);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(281, 30);
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
            this.label2.Location = new System.Drawing.Point(355, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tra cứu độc giả";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(760, 111);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(130, 39);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(760, 172);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvFindReader
            // 
            this.dgvFindReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindReader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFindReader.Location = new System.Drawing.Point(0, 225);
            this.dgvFindReader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFindReader.Name = "dgvFindReader";
            this.dgvFindReader.RowHeadersWidth = 51;
            this.dgvFindReader.RowTemplate.Height = 24;
            this.dgvFindReader.Size = new System.Drawing.Size(932, 298);
            this.dgvFindReader.TabIndex = 6;
            this.dgvFindReader.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindReader_CellContentDoubleClick);
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
            // qUANLYTHUVIENDataSet
            // 
            this.qUANLYTHUVIENDataSet.DataSetName = "QUANLYTHUVIENDataSet";
            this.qUANLYTHUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYTHUVIENDataSetBindingSource
            // 
            this.qUANLYTHUVIENDataSetBindingSource.DataSource = this.qUANLYTHUVIENDataSet;
            this.qUANLYTHUVIENDataSetBindingSource.Position = 0;
            // 
            // FindReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvFindReader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.cbxOption);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FindReaderForm";
            this.Text = "Tra cứu Độc giả";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindReaderForm_FormClosed);
            this.Load += new System.EventHandler(this.TimDocGiaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYTHUVIENDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvFindReader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource qUANLYTHUVIENDataSetBindingSource;
        private QUANLYTHUVIENDataSet qUANLYTHUVIENDataSet;
    }
}