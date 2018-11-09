namespace VentureWindowsForm
{
    partial class Form1
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
            this.labReel = new System.Windows.Forms.Label();
            this.labTable = new System.Windows.Forms.Label();
            this.labPartNo = new System.Windows.Forms.Label();
            this.labSide = new System.Windows.Forms.Label();
            this.textModelNo = new System.Windows.Forms.TextBox();
            this.textReel = new System.Windows.Forms.TextBox();
            this.textTable = new System.Windows.Forms.TextBox();
            this.textPartNo = new System.Windows.Forms.TextBox();
            this.textSide = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textSearchPart = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.btnSearchModel = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnDebugError = new System.Windows.Forms.Button();
            this.labelModel = new System.Windows.Forms.Label();
            this.Export = new System.Windows.Forms.Button();
            this.labReg = new System.Windows.Forms.Label();
            this.textPer = new System.Windows.Forms.TextBox();
            this.F4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTURE : Manufacturing Process Instructions";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入 Model Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labReel
            // 
            this.labReel.AutoSize = true;
            this.labReel.Location = new System.Drawing.Point(273, 200);
            this.labReel.Name = "labReel";
            this.labReel.Size = new System.Drawing.Size(46, 20);
            this.labReel.TabIndex = 2;
            this.labReel.Text = "Reel:";
            // 
            // labTable
            // 
            this.labTable.AutoSize = true;
            this.labTable.Location = new System.Drawing.Point(36, 199);
            this.labTable.Name = "labTable";
            this.labTable.Size = new System.Drawing.Size(52, 20);
            this.labTable.TabIndex = 3;
            this.labTable.Text = "Table:";
            // 
            // labPartNo
            // 
            this.labPartNo.AutoSize = true;
            this.labPartNo.Location = new System.Drawing.Point(593, 199);
            this.labPartNo.Name = "labPartNo";
            this.labPartNo.Size = new System.Drawing.Size(102, 20);
            this.labPartNo.TabIndex = 4;
            this.labPartNo.Text = "Part Number:";
            // 
            // labSide
            // 
            this.labSide.AutoSize = true;
            this.labSide.Location = new System.Drawing.Point(434, 200);
            this.labSide.Name = "labSide";
            this.labSide.Size = new System.Drawing.Size(45, 20);
            this.labSide.TabIndex = 5;
            this.labSide.Text = "Side:";
            // 
            // textModelNo
            // 
            this.textModelNo.AutoCompleteCustomSource.AddRange(new string[] {
            "T8-73-02210-R-B",
            "T8-73-02210-R-T",
            "T8-E-206012-R-B",
            "T8-E-206012-R-T",
            "T8-E-206044-R-B",
            "T8-E-206044-R-T",
            "T8-E-207585-R-B",
            "T8-E-207585-R-T"});
            this.textModelNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textModelNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textModelNo.Location = new System.Drawing.Point(218, 136);
            this.textModelNo.Name = "textModelNo";
            this.textModelNo.Size = new System.Drawing.Size(196, 26);
            this.textModelNo.TabIndex = 7;
            this.textModelNo.TextChanged += new System.EventHandler(this.textModelNo_TextChanged);
            this.textModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textModelNo_KeyDown);
            // 
            // textReel
            // 
            this.textReel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReel.Location = new System.Drawing.Point(277, 223);
            this.textReel.MaximumSize = new System.Drawing.Size(150, 40);
            this.textReel.Name = "textReel";
            this.textReel.Size = new System.Drawing.Size(126, 35);
            this.textReel.TabIndex = 8;
            this.textReel.TextChanged += new System.EventHandler(this.textReel_TextChanged);
            // 
            // textTable
            // 
            this.textTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTable.Location = new System.Drawing.Point(40, 222);
            this.textTable.Name = "textTable";
            this.textTable.Size = new System.Drawing.Size(215, 35);
            this.textTable.TabIndex = 9;
            this.textTable.TextChanged += new System.EventHandler(this.textTable_TextChanged);
            // 
            // textPartNo
            // 
            this.textPartNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPartNo.Location = new System.Drawing.Point(597, 222);
            this.textPartNo.Name = "textPartNo";
            this.textPartNo.Size = new System.Drawing.Size(124, 35);
            this.textPartNo.TabIndex = 10;
            this.textPartNo.TextChanged += new System.EventHandler(this.textPartNo_TextChanged);
            // 
            // textSide
            // 
            this.textSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSide.Location = new System.Drawing.Point(438, 222);
            this.textSide.Name = "textSide";
            this.textSide.Size = new System.Drawing.Size(124, 35);
            this.textSide.TabIndex = 11;
            this.textSide.TextChanged += new System.EventHandler(this.textSide_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(40, 295);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(126, 35);
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFile.Location = new System.Drawing.Point(257, 73);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(169, 37);
            this.btnChooseFile.TabIndex = 19;
            this.btnChooseFile.Text = "直接选 Excel 文件";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F4,
            this.F1,
            this.F2,
            this.F3,
            this.Reg,
            this.F5});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(40, 397);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(819, 336);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "扫 (Part Number):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textSearchPart
            // 
            this.textSearchPart.Location = new System.Drawing.Point(732, 133);
            this.textSearchPart.Name = "textSearchPart";
            this.textSearchPart.Size = new System.Drawing.Size(124, 26);
            this.textSearchPart.TabIndex = 22;
            this.textSearchPart.TextChanged += new System.EventHandler(this.textSearchPart_TextChanged);
            this.textSearchPart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearchPart_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "数量:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFile.Location = new System.Drawing.Point(40, 73);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(169, 37);
            this.btnUploadFile.TabIndex = 25;
            this.btnUploadFile.Text = "上传文件夹";
            this.btnUploadFile.UseVisualStyleBackColor = true;
            this.btnUploadFile.Click += new System.EventHandler(this.btnUploadFile_Click);
            // 
            // btnSearchModel
            // 
            this.btnSearchModel.Location = new System.Drawing.Point(424, 133);
            this.btnSearchModel.Name = "btnSearchModel";
            this.btnSearchModel.Size = new System.Drawing.Size(75, 32);
            this.btnSearchModel.TabIndex = 26;
            this.btnSearchModel.Text = "Search";
            this.btnSearchModel.UseVisualStyleBackColor = true;
            this.btnSearchModel.Click += new System.EventHandler(this.btnSearchModel_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTable.Location = new System.Drawing.Point(733, 354);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(123, 37);
            this.btnClearTable.TabIndex = 28;
            this.btnClearTable.Text = "重新";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // btnDebugError
            // 
            this.btnDebugError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebugError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebugError.Location = new System.Drawing.Point(770, 280);
            this.btnDebugError.Name = "btnDebugError";
            this.btnDebugError.Size = new System.Drawing.Size(86, 67);
            this.btnDebugError.TabIndex = 29;
            this.btnDebugError.Text = "调试  /  刷新";
            this.btnDebugError.UseVisualStyleBackColor = true;
            this.btnDebugError.Click += new System.EventHandler(this.btnDebugError_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(374, 360);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(120, 20);
            this.labelModel.TabIndex = 30;
            this.labelModel.Text = "Model Number: ";
            this.labelModel.Click += new System.EventHandler(this.labelModel_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(758, 73);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(107, 37);
            this.Export.TabIndex = 31;
            this.Export.Text = "导出 .xls";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // labReg
            // 
            this.labReg.AutoSize = true;
            this.labReg.Location = new System.Drawing.Point(751, 199);
            this.labReg.Name = "labReg";
            this.labReg.Size = new System.Drawing.Size(37, 20);
            this.labReg.TabIndex = 32;
            this.labReg.Text = "Per:";
            // 
            // textPer
            // 
            this.textPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPer.Location = new System.Drawing.Point(755, 222);
            this.textPer.Name = "textPer";
            this.textPer.Size = new System.Drawing.Size(120, 35);
            this.textPer.TabIndex = 33;
            this.textPer.TextChanged += new System.EventHandler(this.textPer_TextChanged);
            // 
            // F4
            // 
            this.F4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F4.DataPropertyName = "F4";
            this.F4.FillWeight = 101.4483F;
            this.F4.HeaderText = "Table No.";
            this.F4.Name = "F4";
            // 
            // F1
            // 
            this.F1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F1.DataPropertyName = "F1";
            this.F1.FillWeight = 100.5155F;
            this.F1.HeaderText = "Reel";
            this.F1.Name = "F1";
            // 
            // F2
            // 
            this.F2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F2.DataPropertyName = "F2";
            this.F2.FillWeight = 99.73489F;
            this.F2.HeaderText = "Side";
            this.F2.Name = "F2";
            // 
            // F3
            // 
            this.F3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F3.DataPropertyName = "F3";
            this.F3.FillWeight = 97.82384F;
            this.F3.HeaderText = "Part No.";
            this.F3.Name = "F3";
            // 
            // Reg
            // 
            this.Reg.HeaderText = "Per";
            this.Reg.Name = "Reg";
            // 
            // F5
            // 
            this.F5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.F5.DataPropertyName = "F5";
            this.F5.FillWeight = 100.4775F;
            this.F5.HeaderText = "Checked?";
            this.F5.Name = "F5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(901, 772);
            this.Controls.Add(this.textPer);
            this.Controls.Add(this.labReg);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.btnDebugError);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnSearchModel);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSearchPart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textSide);
            this.Controls.Add(this.textPartNo);
            this.Controls.Add(this.textTable);
            this.Controls.Add(this.textReel);
            this.Controls.Add(this.textModelNo);
            this.Controls.Add(this.labSide);
            this.Controls.Add(this.labPartNo);
            this.Controls.Add(this.labTable);
            this.Controls.Add(this.labReel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labReel;
        private System.Windows.Forms.Label labTable;
        private System.Windows.Forms.Label labPartNo;
        private System.Windows.Forms.Label labSide;
        private System.Windows.Forms.TextBox textModelNo;
        private System.Windows.Forms.TextBox textReel;
        private System.Windows.Forms.TextBox textTable;
        private System.Windows.Forms.TextBox textPartNo;
        private System.Windows.Forms.TextBox textSide;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSearchPart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUploadFile;
        private System.Windows.Forms.Button btnSearchModel;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnDebugError;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Label labReg;
        private System.Windows.Forms.TextBox textPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn F4;
        private System.Windows.Forms.DataGridViewTextBoxColumn F1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F2;
        private System.Windows.Forms.DataGridViewTextBoxColumn F3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reg;
        private System.Windows.Forms.DataGridViewTextBoxColumn F5;
    }
}

