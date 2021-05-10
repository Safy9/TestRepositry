namespace TransferDataToDatabase
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnTransferData = new System.Windows.Forms.Button();
            this.btnDataWillTransfer = new System.Windows.Forms.Button();
            this.rdoProduct = new System.Windows.Forms.RadioButton();
            this.rdoCategories = new System.Windows.Forms.RadioButton();
            this.lblCountRows = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.lblCountRows2 = new System.Windows.Forms.Label();
            this.rdoCategory2 = new System.Windows.Forms.RadioButton();
            this.rdoPoduct2 = new System.Windows.Forms.RadioButton();
            this.btnFillDGV2 = new System.Windows.Forms.Button();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDBName2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 424);
            this.panel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(519, 422);
            this.dgv.TabIndex = 0;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(12, 441);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(97, 31);
            this.btnFill.TabIndex = 1;
            this.btnFill.Text = "Fill DGV";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnTransferData
            // 
            this.btnTransferData.Location = new System.Drawing.Point(945, 480);
            this.btnTransferData.Name = "btnTransferData";
            this.btnTransferData.Size = new System.Drawing.Size(167, 40);
            this.btnTransferData.TabIndex = 2;
            this.btnTransferData.Text = "Transfer Data";
            this.btnTransferData.UseVisualStyleBackColor = true;
            this.btnTransferData.Click += new System.EventHandler(this.btnTransferData_Click);
            // 
            // btnDataWillTransfer
            // 
            this.btnDataWillTransfer.Location = new System.Drawing.Point(162, 442);
            this.btnDataWillTransfer.Name = "btnDataWillTransfer";
            this.btnDataWillTransfer.Size = new System.Drawing.Size(194, 31);
            this.btnDataWillTransfer.TabIndex = 3;
            this.btnDataWillTransfer.Text = "Data Will Transfer";
            this.btnDataWillTransfer.UseVisualStyleBackColor = true;
            this.btnDataWillTransfer.Click += new System.EventHandler(this.btnDataWillTransfer_Click);
            // 
            // rdoProduct
            // 
            this.rdoProduct.AutoSize = true;
            this.rdoProduct.Location = new System.Drawing.Point(432, 487);
            this.rdoProduct.Name = "rdoProduct";
            this.rdoProduct.Size = new System.Drawing.Size(101, 26);
            this.rdoProduct.TabIndex = 4;
            this.rdoProduct.Text = "Product";
            this.rdoProduct.UseVisualStyleBackColor = true;
            // 
            // rdoCategories
            // 
            this.rdoCategories.AutoSize = true;
            this.rdoCategories.Checked = true;
            this.rdoCategories.Location = new System.Drawing.Point(298, 486);
            this.rdoCategories.Name = "rdoCategories";
            this.rdoCategories.Size = new System.Drawing.Size(128, 26);
            this.rdoCategories.TabIndex = 5;
            this.rdoCategories.TabStop = true;
            this.rdoCategories.Text = "Categories";
            this.rdoCategories.UseVisualStyleBackColor = true;
            // 
            // lblCountRows
            // 
            this.lblCountRows.AutoSize = true;
            this.lblCountRows.Location = new System.Drawing.Point(377, 447);
            this.lblCountRows.Name = "lblCountRows";
            this.lblCountRows.Size = new System.Drawing.Size(155, 22);
            this.lblCountRows.TabIndex = 6;
            this.lblCountRows.Text = "Result : 0 Row(s)";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgv2);
            this.panel2.Location = new System.Drawing.Point(599, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 424);
            this.panel2.TabIndex = 7;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv2.Location = new System.Drawing.Point(0, 0);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(515, 422);
            this.dgv2.TabIndex = 0;
            // 
            // lblCountRows2
            // 
            this.lblCountRows2.AutoSize = true;
            this.lblCountRows2.Location = new System.Drawing.Point(963, 445);
            this.lblCountRows2.Name = "lblCountRows2";
            this.lblCountRows2.Size = new System.Drawing.Size(155, 22);
            this.lblCountRows2.TabIndex = 8;
            this.lblCountRows2.Text = "Result : 0 Row(s)";
            // 
            // rdoCategory2
            // 
            this.rdoCategory2.AutoSize = true;
            this.rdoCategory2.Checked = true;
            this.rdoCategory2.Location = new System.Drawing.Point(722, 443);
            this.rdoCategory2.Name = "rdoCategory2";
            this.rdoCategory2.Size = new System.Drawing.Size(128, 26);
            this.rdoCategory2.TabIndex = 11;
            this.rdoCategory2.TabStop = true;
            this.rdoCategory2.Text = "Categories";
            this.rdoCategory2.UseVisualStyleBackColor = true;
            // 
            // rdoPoduct2
            // 
            this.rdoPoduct2.AutoSize = true;
            this.rdoPoduct2.Location = new System.Drawing.Point(856, 443);
            this.rdoPoduct2.Name = "rdoPoduct2";
            this.rdoPoduct2.Size = new System.Drawing.Size(101, 26);
            this.rdoPoduct2.TabIndex = 10;
            this.rdoPoduct2.Text = "Product";
            this.rdoPoduct2.UseVisualStyleBackColor = true;
            // 
            // btnFillDGV2
            // 
            this.btnFillDGV2.Location = new System.Drawing.Point(600, 441);
            this.btnFillDGV2.Name = "btnFillDGV2";
            this.btnFillDGV2.Size = new System.Drawing.Size(116, 31);
            this.btnFillDGV2.TabIndex = 9;
            this.btnFillDGV2.Text = "Fill DGV";
            this.btnFillDGV2.UseVisualStyleBackColor = true;
            this.btnFillDGV2.Click += new System.EventHandler(this.btnFillDGV2_Click);
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(115, 485);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(177, 31);
            this.txtDBName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "DB Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "DB Name:";
            // 
            // txtDBName2
            // 
            this.txtDBName2.Location = new System.Drawing.Point(703, 485);
            this.txtDBName2.Name = "txtDBName2";
            this.txtDBName2.Size = new System.Drawing.Size(223, 31);
            this.txtDBName2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1124, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDBName2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.rdoCategory2);
            this.Controls.Add(this.rdoPoduct2);
            this.Controls.Add(this.btnFillDGV2);
            this.Controls.Add(this.lblCountRows2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCountRows);
            this.Controls.Add(this.rdoCategories);
            this.Controls.Add(this.rdoProduct);
            this.Controls.Add(this.btnDataWillTransfer);
            this.Controls.Add(this.btnTransferData);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Data From DGV To DB";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnTransferData;
        private System.Windows.Forms.Button btnDataWillTransfer;
        private System.Windows.Forms.RadioButton rdoProduct;
        private System.Windows.Forms.RadioButton rdoCategories;
        private System.Windows.Forms.Label lblCountRows;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label lblCountRows2;
        private System.Windows.Forms.RadioButton rdoCategory2;
        private System.Windows.Forms.RadioButton rdoPoduct2;
        private System.Windows.Forms.Button btnFillDGV2;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDBName2;
    }
}

