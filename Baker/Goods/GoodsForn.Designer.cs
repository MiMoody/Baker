
namespace Baker
{
    partial class GoodsForn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LabGood = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GoodsTable = new System.Windows.Forms.DataGridView();
            this.LabColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CmbGender);
            this.MainPanel.Controls.Add(this.TxtSearch);
            this.MainPanel.Controls.Add(this.BtnDel);
            this.MainPanel.Controls.Add(this.BtnChange);
            this.MainPanel.Controls.Add(this.BtnCreate);
            this.MainPanel.Controls.Add(this.LabGood);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.GoodsTable);
            this.MainPanel.Controls.Add(this.LabColor);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(236, 153);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(552, 20);
            this.TxtSearch.TabIndex = 16;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDel.Location = new System.Drawing.Point(491, 354);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(108, 36);
            this.BtnDel.TabIndex = 13;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = true;
            // 
            // BtnChange
            // 
            this.BtnChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.Location = new System.Drawing.Point(341, 354);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(108, 36);
            this.BtnChange.TabIndex = 12;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.UseVisualStyleBackColor = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreate.Location = new System.Drawing.Point(180, 354);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(108, 36);
            this.BtnCreate.TabIndex = 11;
            this.BtnCreate.Text = "Создать";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LabGood
            // 
            this.LabGood.AutoSize = true;
            this.LabGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabGood.Location = new System.Drawing.Point(336, 74);
            this.LabGood.Name = "LabGood";
            this.LabGood.Size = new System.Drawing.Size(118, 25);
            this.LabGood.TabIndex = 10;
            this.LabGood.Text = "Продукты";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(13, 10);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(84, 32);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Назад";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // GoodsTable
            // 
            this.GoodsTable.AllowUserToAddRows = false;
            this.GoodsTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            this.GoodsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GoodsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GoodsTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.GoodsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GoodsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsTable.Location = new System.Drawing.Point(13, 179);
            this.GoodsTable.MultiSelect = false;
            this.GoodsTable.Name = "GoodsTable";
            this.GoodsTable.ReadOnly = true;
            this.GoodsTable.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodsTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GoodsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GoodsTable.Size = new System.Drawing.Size(776, 150);
            this.GoodsTable.TabIndex = 8;
            // 
            // LabColor
            // 
            this.LabColor.BackColor = System.Drawing.SystemColors.Info;
            this.LabColor.Location = new System.Drawing.Point(0, -2);
            this.LabColor.Name = "LabColor";
            this.LabColor.Size = new System.Drawing.Size(801, 50);
            this.LabColor.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(0, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 50);
            this.label1.TabIndex = 15;
            // 
            // CmbGender
            // 
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Все",
            "М",
            "Ж"});
            this.CmbGender.Location = new System.Drawing.Point(13, 153);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(121, 21);
            this.CmbGender.TabIndex = 17;
            this.CmbGender.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // GoodsForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GoodsForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodsForn";
            this.Load += new System.EventHandler(this.GoodsForn_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label LabGood;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView GoodsTable;
        private System.Windows.Forms.Label LabColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ComboBox CmbGender;
    }
}