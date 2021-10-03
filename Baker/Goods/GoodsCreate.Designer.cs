
namespace Baker
{
    partial class GoodsCreate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnAddIng = new System.Windows.Forms.Button();
            this.BtnDelIng = new System.Windows.Forms.Button();
            this.ListIngridient = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompositionTable = new System.Windows.Forms.DataGridView();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbUnitMoney = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbUnits = new System.Windows.Forms.ComboBox();
            this.BtnCreateGood = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LabQuantity = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabColor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnAddIng);
            this.MainPanel.Controls.Add(this.BtnDelIng);
            this.MainPanel.Controls.Add(this.ListIngridient);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.CompositionTable);
            this.MainPanel.Controls.Add(this.TxtPrice);
            this.MainPanel.Controls.Add(this.label6);
            this.MainPanel.Controls.Add(this.CmbUnitMoney);
            this.MainPanel.Controls.Add(this.label5);
            this.MainPanel.Controls.Add(this.CmbUnits);
            this.MainPanel.Controls.Add(this.BtnCreateGood);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.LabQuantity);
            this.MainPanel.Controls.Add(this.LabName);
            this.MainPanel.Controls.Add(this.TxtQuantity);
            this.MainPanel.Controls.Add(this.TxtName);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.LabColor);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1067, 721);
            this.MainPanel.TabIndex = 1;
            // 
            // BtnAddIng
            // 
            this.BtnAddIng.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddIng.Location = new System.Drawing.Point(533, 602);
            this.BtnAddIng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAddIng.Name = "BtnAddIng";
            this.BtnAddIng.Size = new System.Drawing.Size(340, 38);
            this.BtnAddIng.TabIndex = 39;
            this.BtnAddIng.Text = "Добавить ингредиент";
            this.BtnAddIng.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAddIng.UseVisualStyleBackColor = true;
            this.BtnAddIng.Click += new System.EventHandler(this.BtnAddIng_Click);
            // 
            // BtnDelIng
            // 
            this.BtnDelIng.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnDelIng.Location = new System.Drawing.Point(533, 347);
            this.BtnDelIng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelIng.Name = "BtnDelIng";
            this.BtnDelIng.Size = new System.Drawing.Size(340, 38);
            this.BtnDelIng.TabIndex = 38;
            this.BtnDelIng.Text = "Удалить ингредиент";
            this.BtnDelIng.UseVisualStyleBackColor = true;
            this.BtnDelIng.Click += new System.EventHandler(this.BtnDelIng_Click);
            // 
            // ListIngridient
            // 
            this.ListIngridient.FormattingEnabled = true;
            this.ListIngridient.ItemHeight = 19;
            this.ListIngridient.Location = new System.Drawing.Point(385, 410);
            this.ListIngridient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListIngridient.Name = "ListIngridient";
            this.ListIngridient.Size = new System.Drawing.Size(637, 175);
            this.ListIngridient.TabIndex = 37;
            this.ListIngridient.SelectedIndexChanged += new System.EventHandler(this.ListIngridient_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(609, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Состав продукта";
            // 
            // CompositionTable
            // 
            this.CompositionTable.AllowUserToAddRows = false;
            this.CompositionTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.CompositionTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CompositionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CompositionTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.CompositionTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CompositionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompositionTable.Location = new System.Drawing.Point(385, 154);
            this.CompositionTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompositionTable.MultiSelect = false;
            this.CompositionTable.Name = "CompositionTable";
            this.CompositionTable.ReadOnly = true;
            this.CompositionTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompositionTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CompositionTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompositionTable.Size = new System.Drawing.Size(639, 185);
            this.CompositionTable.TabIndex = 35;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPrice.Location = new System.Drawing.Point(59, 383);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(272, 27);
            this.TxtPrice.TabIndex = 34;
            this.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(157, 347);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Цена";
            // 
            // CmbUnitMoney
            // 
            this.CmbUnitMoney.FormattingEnabled = true;
            this.CmbUnitMoney.Location = new System.Drawing.Point(56, 458);
            this.CmbUnitMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbUnitMoney.Name = "CmbUnitMoney";
            this.CmbUnitMoney.Size = new System.Drawing.Size(272, 27);
            this.CmbUnitMoney.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(144, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Валюта";
            // 
            // CmbUnits
            // 
            this.CmbUnits.FormattingEnabled = true;
            this.CmbUnits.Location = new System.Drawing.Point(56, 300);
            this.CmbUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CmbUnits.Name = "CmbUnits";
            this.CmbUnits.Size = new System.Drawing.Size(272, 27);
            this.CmbUnits.TabIndex = 24;
            // 
            // BtnCreateGood
            // 
            this.BtnCreateGood.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreateGood.Location = new System.Drawing.Point(72, 511);
            this.BtnCreateGood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCreateGood.Name = "BtnCreateGood";
            this.BtnCreateGood.Size = new System.Drawing.Size(244, 47);
            this.BtnCreateGood.TabIndex = 21;
            this.BtnCreateGood.Text = "Добавить продукт";
            this.BtnCreateGood.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCreateGood.UseVisualStyleBackColor = true;
            this.BtnCreateGood.Click += new System.EventHandler(this.BtnCreateGood_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Единицы измерения";
            // 
            // LabQuantity
            // 
            this.LabQuantity.AutoSize = true;
            this.LabQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabQuantity.Location = new System.Drawing.Point(125, 191);
            this.LabQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabQuantity.Name = "LabQuantity";
            this.LabQuantity.Size = new System.Drawing.Size(130, 23);
            this.LabQuantity.TabIndex = 19;
            this.LabQuantity.Text = "Количество";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabName.Location = new System.Drawing.Point(111, 126);
            this.LabName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(164, 23);
            this.LabName.TabIndex = 18;
            this.LabName.Text = "Наименование";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtQuantity.Location = new System.Drawing.Point(56, 219);
            this.TxtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(272, 27);
            this.TxtQuantity.TabIndex = 17;
            this.TxtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(53, 154);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(272, 27);
            this.TxtName.TabIndex = 16;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(416, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавление продукта";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(24, 15);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(100, 36);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "Назад";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LabColor
            // 
            this.LabColor.BackColor = System.Drawing.SystemColors.Info;
            this.LabColor.Location = new System.Drawing.Point(4, 2);
            this.LabColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabColor.Name = "LabColor";
            this.LabColor.Size = new System.Drawing.Size(1063, 62);
            this.LabColor.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(4, 655);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1059, 62);
            this.label2.TabIndex = 23;
            // 
            // GoodsCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 721);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GoodsCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodsCreate";
            this.Load += new System.EventHandler(this.GoodsCreate_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompositionTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbUnitMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbUnits;
        private System.Windows.Forms.Button BtnCreateGood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabQuantity;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListIngridient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CompositionTable;
        private System.Windows.Forms.Button BtnDelIng;
        private System.Windows.Forms.Button BtnAddIng;
    }
}