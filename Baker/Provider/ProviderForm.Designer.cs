
namespace Baker
{
    partial class ProviderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProviderTable = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.Labprovider = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.LabColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNextPage = new System.Windows.Forms.Button();
            this.BtnPreviousPage = new System.Windows.Forms.Button();
            this.CmbPagesCount = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProviderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProviderTable
            // 
            this.ProviderTable.AllowUserToAddRows = false;
            this.ProviderTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            this.ProviderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ProviderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProviderTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ProviderTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProviderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProviderTable.Location = new System.Drawing.Point(12, 139);
            this.ProviderTable.MultiSelect = false;
            this.ProviderTable.Name = "ProviderTable";
            this.ProviderTable.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderTable.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ProviderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProviderTable.Size = new System.Drawing.Size(776, 150);
            this.ProviderTable.TabIndex = 0;
            this.ProviderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProviderTable_CellClick);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(12, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(84, 32);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Назад";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Labprovider
            // 
            this.Labprovider.AutoSize = true;
            this.Labprovider.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Labprovider.Location = new System.Drawing.Point(335, 70);
            this.Labprovider.Name = "Labprovider";
            this.Labprovider.Size = new System.Drawing.Size(145, 25);
            this.Labprovider.TabIndex = 2;
            this.Labprovider.Text = "Поставщики";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreate.Location = new System.Drawing.Point(179, 350);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(108, 36);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "Создать";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnChange
            // 
            this.BtnChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnChange.Location = new System.Drawing.Point(340, 350);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(108, 36);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "Изменить";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDel.Location = new System.Drawing.Point(490, 350);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(108, 36);
            this.BtnDel.TabIndex = 5;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // LabColor
            // 
            this.LabColor.BackColor = System.Drawing.SystemColors.Info;
            this.LabColor.Location = new System.Drawing.Point(-1, -6);
            this.LabColor.Name = "LabColor";
            this.LabColor.Size = new System.Drawing.Size(801, 50);
            this.LabColor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(-1, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 50);
            this.label1.TabIndex = 7;
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnNextPage.Location = new System.Drawing.Point(479, 298);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(136, 36);
            this.BtnNextPage.TabIndex = 8;
            this.BtnNextPage.Text = "Следующая";
            this.BtnNextPage.UseVisualStyleBackColor = true;
            this.BtnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // BtnPreviousPage
            // 
            this.BtnPreviousPage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPreviousPage.Location = new System.Drawing.Point(179, 295);
            this.BtnPreviousPage.Name = "BtnPreviousPage";
            this.BtnPreviousPage.Size = new System.Drawing.Size(127, 36);
            this.BtnPreviousPage.TabIndex = 9;
            this.BtnPreviousPage.Text = "Предыдущая";
            this.BtnPreviousPage.UseVisualStyleBackColor = true;
            this.BtnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // CmbPagesCount
            // 
            this.CmbPagesCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPagesCount.FormattingEnabled = true;
            this.CmbPagesCount.Items.AddRange(new object[] {
            "Все",
            "10",
            "30",
            "200"});
            this.CmbPagesCount.Location = new System.Drawing.Point(340, 112);
            this.CmbPagesCount.Name = "CmbPagesCount";
            this.CmbPagesCount.Size = new System.Drawing.Size(121, 21);
            this.CmbPagesCount.TabIndex = 10;
            this.CmbPagesCount.SelectedIndexChanged += new System.EventHandler(this.CmbPagesCount_SelectedIndexChanged);
            // 
            // ProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmbPagesCount);
            this.Controls.Add(this.BtnPreviousPage);
            this.Controls.Add(this.BtnNextPage);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.Labprovider);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.ProviderTable);
            this.Controls.Add(this.LabColor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProviderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProviderForm";
            this.Load += new System.EventHandler(this.ProviderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProviderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProviderTable;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label Labprovider;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label LabColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNextPage;
        private System.Windows.Forms.Button BtnPreviousPage;
        private System.Windows.Forms.ComboBox CmbPagesCount;
    }
}