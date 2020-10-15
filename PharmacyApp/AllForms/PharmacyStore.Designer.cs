namespace PharmacyApp
{
    partial class PharmacyStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacyStore));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbByMedicine = new System.Windows.Forms.ComboBox();
            this.cmbByTags = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgMedicinesBuy = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuyMedName = new System.Windows.Forms.MaskedTextBox();
            this.checkedTagList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmBuyMedCount = new System.Windows.Forms.NumericUpDown();
            this.btnBuyMed = new System.Windows.Forms.Button();
            this.btnSellMed = new System.Windows.Forms.Button();
            this.SellMedPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicinesBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyMedCount)).BeginInit();
            this.SellMedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.firmsToolStripMenuItem,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.medicineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicineToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // firmsToolStripMenuItem
            // 
            this.firmsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firmsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.firmsToolStripMenuItem.Name = "firmsToolStripMenuItem";
            this.firmsToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.firmsToolStripMenuItem.Text = "Firms";
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "by Medicine";
            // 
            // cmbByMedicine
            // 
            this.cmbByMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbByMedicine.FormattingEnabled = true;
            this.cmbByMedicine.Location = new System.Drawing.Point(12, 141);
            this.cmbByMedicine.Name = "cmbByMedicine";
            this.cmbByMedicine.Size = new System.Drawing.Size(168, 26);
            this.cmbByMedicine.TabIndex = 2;
            // 
            // cmbByTags
            // 
            this.cmbByTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbByTags.FormattingEnabled = true;
            this.cmbByTags.Location = new System.Drawing.Point(212, 141);
            this.cmbByTags.Name = "cmbByTags";
            this.cmbByTags.Size = new System.Drawing.Size(168, 26);
            this.cmbByTags.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(209, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "by Tags";
            // 
            // dtgMedicinesBuy
            // 
            this.dtgMedicinesBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMedicinesBuy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgMedicinesBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicinesBuy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgMedicinesBuy.Location = new System.Drawing.Point(0, 281);
            this.dtgMedicinesBuy.Name = "dtgMedicinesBuy";
            this.dtgMedicinesBuy.Size = new System.Drawing.Size(756, 171);
            this.dtgMedicinesBuy.TabIndex = 5;
            this.dtgMedicinesBuy.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgMedicinesBuy_RowHeaderMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Medicine";
            // 
            // txtBuyMedName
            // 
            this.txtBuyMedName.Enabled = false;
            this.txtBuyMedName.Location = new System.Drawing.Point(12, 44);
            this.txtBuyMedName.Name = "txtBuyMedName";
            this.txtBuyMedName.Size = new System.Drawing.Size(133, 20);
            this.txtBuyMedName.TabIndex = 7;
            // 
            // checkedTagList
            // 
            this.checkedTagList.FormattingEnabled = true;
            this.checkedTagList.Location = new System.Drawing.Point(161, 30);
            this.checkedTagList.Name = "checkedTagList";
            this.checkedTagList.Size = new System.Drawing.Size(165, 94);
            this.checkedTagList.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label4.Location = new System.Drawing.Point(8, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Count";
            // 
            // nmBuyMedCount
            // 
            this.nmBuyMedCount.Location = new System.Drawing.Point(12, 118);
            this.nmBuyMedCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmBuyMedCount.Name = "nmBuyMedCount";
            this.nmBuyMedCount.Size = new System.Drawing.Size(133, 20);
            this.nmBuyMedCount.TabIndex = 10;
            this.nmBuyMedCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBuyMed
            // 
            this.btnBuyMed.BackColor = System.Drawing.Color.Orange;
            this.btnBuyMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyMed.ForeColor = System.Drawing.Color.White;
            this.btnBuyMed.Location = new System.Drawing.Point(12, 164);
            this.btnBuyMed.Name = "btnBuyMed";
            this.btnBuyMed.Size = new System.Drawing.Size(76, 31);
            this.btnBuyMed.TabIndex = 11;
            this.btnBuyMed.Text = "Buy";
            this.btnBuyMed.UseVisualStyleBackColor = false;
            this.btnBuyMed.Click += new System.EventHandler(this.btnBuyMed_Click);
            // 
            // btnSellMed
            // 
            this.btnSellMed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnSellMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellMed.ForeColor = System.Drawing.Color.White;
            this.btnSellMed.Location = new System.Drawing.Point(162, 140);
            this.btnSellMed.Name = "btnSellMed";
            this.btnSellMed.Size = new System.Drawing.Size(76, 31);
            this.btnSellMed.TabIndex = 12;
            this.btnSellMed.Text = "Sell";
            this.btnSellMed.UseVisualStyleBackColor = false;
            this.btnSellMed.Click += new System.EventHandler(this.btnSellMed_Click);
            // 
            // SellMedPanel
            // 
            this.SellMedPanel.Controls.Add(this.txtBuyMedName);
            this.SellMedPanel.Controls.Add(this.btnSellMed);
            this.SellMedPanel.Controls.Add(this.label3);
            this.SellMedPanel.Controls.Add(this.checkedTagList);
            this.SellMedPanel.Controls.Add(this.btnBuyMed);
            this.SellMedPanel.Controls.Add(this.nmBuyMedCount);
            this.SellMedPanel.Controls.Add(this.label4);
            this.SellMedPanel.Location = new System.Drawing.Point(407, 60);
            this.SellMedPanel.Name = "SellMedPanel";
            this.SellMedPanel.Size = new System.Drawing.Size(337, 215);
            this.SellMedPanel.TabIndex = 13;
            this.SellMedPanel.Visible = false;
            // 
            // PharmacyStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 452);
            this.Controls.Add(this.SellMedPanel);
            this.Controls.Add(this.dtgMedicinesBuy);
            this.Controls.Add(this.cmbByTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbByMedicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PharmacyStore";
            this.Text = "Pharmacy Store";
            this.Load += new System.EventHandler(this.PharmacyStore_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicinesBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmBuyMedCount)).EndInit();
            this.SellMedPanel.ResumeLayout(false);
            this.SellMedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbByMedicine;
        private System.Windows.Forms.ComboBox cmbByTags;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgMedicinesBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBuyMedName;
        private System.Windows.Forms.CheckedListBox checkedTagList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmBuyMedCount;
        private System.Windows.Forms.Button btnBuyMed;
        private System.Windows.Forms.Button btnSellMed;
        private System.Windows.Forms.Panel SellMedPanel;
    }
}

