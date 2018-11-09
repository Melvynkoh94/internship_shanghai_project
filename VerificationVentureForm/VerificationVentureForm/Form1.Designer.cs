namespace VerificationVentureForm
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
            this.btnUploadFolder = new System.Windows.Forms.Button();
            this.textModelNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Per = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textFirstScan = new System.Windows.Forms.TextBox();
            this.textSecondScan = new System.Windows.Forms.TextBox();
            this.labFirstScan = new System.Windows.Forms.Label();
            this.labSecondScan = new System.Windows.Forms.Label();
            this.btnSearchAfterScan = new System.Windows.Forms.Button();
            this.labQnty = new System.Windows.Forms.Label();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.labelModel = new System.Windows.Forms.Label();
            this.btnDebugError = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadFolder
            // 
            this.btnUploadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadFolder.Location = new System.Drawing.Point(35, 31);
            this.btnUploadFolder.Name = "btnUploadFolder";
            this.btnUploadFolder.Size = new System.Drawing.Size(174, 37);
            this.btnUploadFolder.TabIndex = 0;
            this.btnUploadFolder.Text = "Upload Folder";
            this.btnUploadFolder.UseVisualStyleBackColor = true;
            this.btnUploadFolder.Click += new System.EventHandler(this.btnUploadFolder_Click);
            // 
            // textModelNo
            // 
            this.textModelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModelNo.Location = new System.Drawing.Point(276, 95);
            this.textModelNo.Name = "textModelNo";
            this.textModelNo.Size = new System.Drawing.Size(280, 44);
            this.textModelNo.TabIndex = 1;
            this.textModelNo.TextChanged += new System.EventHandler(this.textModelNo_TextChanged);
            this.textModelNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textModelNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Model Number:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(575, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table,
            this.Reel,
            this.Side,
            this.PartNo,
            this.Per});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(16, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 462);
            this.dataGridView1.TabIndex = 4;
            // 
            // Table
            // 
            this.Table.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Table.DataPropertyName = "F1";
            this.Table.HeaderText = "Table No.";
            this.Table.Name = "Table";
            // 
            // Reel
            // 
            this.Reel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Reel.DataPropertyName = "F2";
            this.Reel.HeaderText = "Reel";
            this.Reel.Name = "Reel";
            // 
            // Side
            // 
            this.Side.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Side.DataPropertyName = "F3";
            this.Side.HeaderText = "Side";
            this.Side.Name = "Side";
            // 
            // PartNo
            // 
            this.PartNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartNo.DataPropertyName = "F4";
            this.PartNo.HeaderText = "Part No.";
            this.PartNo.Name = "PartNo";
            // 
            // Per
            // 
            this.Per.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Per.DataPropertyName = "F6";
            this.Per.HeaderText = "Per";
            this.Per.Name = "Per";
            // 
            // textFirstScan
            // 
            this.textFirstScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstScan.Location = new System.Drawing.Point(36, 193);
            this.textFirstScan.Name = "textFirstScan";
            this.textFirstScan.Size = new System.Drawing.Size(366, 44);
            this.textFirstScan.TabIndex = 5;
            this.textFirstScan.TextChanged += new System.EventHandler(this.textFirstScan_TextChanged);
            // 
            // textSecondScan
            // 
            this.textSecondScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecondScan.Location = new System.Drawing.Point(433, 192);
            this.textSecondScan.Name = "textSecondScan";
            this.textSecondScan.Size = new System.Drawing.Size(246, 44);
            this.textSecondScan.TabIndex = 6;
            this.textSecondScan.TextChanged += new System.EventHandler(this.textSecondScan_TextChanged);
            this.textSecondScan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSecondScan_KeyDown);
            // 
            // labFirstScan
            // 
            this.labFirstScan.AutoSize = true;
            this.labFirstScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFirstScan.Location = new System.Drawing.Point(31, 164);
            this.labFirstScan.Name = "labFirstScan";
            this.labFirstScan.Size = new System.Drawing.Size(111, 25);
            this.labFirstScan.TabIndex = 7;
            this.labFirstScan.Text = "First Scan: ";
            // 
            // labSecondScan
            // 
            this.labSecondScan.AutoSize = true;
            this.labSecondScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSecondScan.Location = new System.Drawing.Point(428, 164);
            this.labSecondScan.Name = "labSecondScan";
            this.labSecondScan.Size = new System.Drawing.Size(142, 25);
            this.labSecondScan.TabIndex = 8;
            this.labSecondScan.Text = "Second Scan: ";
            // 
            // btnSearchAfterScan
            // 
            this.btnSearchAfterScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAfterScan.Location = new System.Drawing.Point(700, 178);
            this.btnSearchAfterScan.Name = "btnSearchAfterScan";
            this.btnSearchAfterScan.Size = new System.Drawing.Size(173, 73);
            this.btnSearchAfterScan.TabIndex = 9;
            this.btnSearchAfterScan.Text = "Search From Table";
            this.btnSearchAfterScan.UseVisualStyleBackColor = true;
            this.btnSearchAfterScan.Click += new System.EventHandler(this.btnSearchAfterScan_Click);
            // 
            // labQnty
            // 
            this.labQnty.AutoSize = true;
            this.labQnty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labQnty.Location = new System.Drawing.Point(31, 266);
            this.labQnty.Name = "labQnty";
            this.labQnty.Size = new System.Drawing.Size(141, 20);
            this.labQnty.TabIndex = 10;
            this.labQnty.Text = "Quantity Check: ";
            this.labQnty.Click += new System.EventHandler(this.labQnty_Click);
            // 
            // btnClearTable
            // 
            this.btnClearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTable.Location = new System.Drawing.Point(1000, 240);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(140, 42);
            this.btnClearTable.TabIndex = 11;
            this.btnClearTable.Text = "Clear Table";
            this.btnClearTable.UseVisualStyleBackColor = true;
            this.btnClearTable.Click += new System.EventHandler(this.btnClearTable_Click);
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(365, 265);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(120, 20);
            this.labelModel.TabIndex = 12;
            this.labelModel.Text = "Model Number: ";
            this.labelModel.Click += new System.EventHandler(this.labelModel_Click);
            // 
            // btnDebugError
            // 
            this.btnDebugError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebugError.Location = new System.Drawing.Point(1049, 173);
            this.btnDebugError.Name = "btnDebugError";
            this.btnDebugError.Size = new System.Drawing.Size(91, 61);
            this.btnDebugError.TabIndex = 13;
            this.btnDebugError.Text = "Debug Error";
            this.btnDebugError.UseVisualStyleBackColor = true;
            this.btnDebugError.Click += new System.EventHandler(this.btnDebugError_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1233, 762);
            this.Controls.Add(this.btnDebugError);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.labQnty);
            this.Controls.Add(this.btnSearchAfterScan);
            this.Controls.Add(this.labSecondScan);
            this.Controls.Add(this.labFirstScan);
            this.Controls.Add(this.textSecondScan);
            this.Controls.Add(this.textFirstScan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textModelNo);
            this.Controls.Add(this.btnUploadFolder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadFolder;
        private System.Windows.Forms.TextBox textModelNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Per;
        private System.Windows.Forms.TextBox textFirstScan;
        private System.Windows.Forms.TextBox textSecondScan;
        private System.Windows.Forms.Label labFirstScan;
        private System.Windows.Forms.Label labSecondScan;
        private System.Windows.Forms.Button btnSearchAfterScan;
        private System.Windows.Forms.Label labQnty;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Button btnDebugError;
    }
}

