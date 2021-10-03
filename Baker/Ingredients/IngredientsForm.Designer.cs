
namespace Baker
{
    partial class IngredientsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LabIngredient = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.IngredientTable = new System.Windows.Forms.DataGridView();
            this.LabColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDel);
            this.panel1.Controls.Add(this.BtnChange);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.LabIngredient);
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.IngredientTable);
            this.panel1.Controls.Add(this.LabColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
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
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
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
            // LabIngredient
            // 
            this.LabIngredient.AutoSize = true;
            this.LabIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabIngredient.Location = new System.Drawing.Point(336, 74);
            this.LabIngredient.Name = "LabIngredient";
            this.LabIngredient.Size = new System.Drawing.Size(155, 25);
            this.LabIngredient.TabIndex = 10;
            this.LabIngredient.Text = "Ингредиенты";
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
            // IngredientTable
            // 
            this.IngredientTable.AllowUserToAddRows = false;
            this.IngredientTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.IngredientTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.IngredientTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IngredientTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.IngredientTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.IngredientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngredientTable.Location = new System.Drawing.Point(13, 143);
            this.IngredientTable.MultiSelect = false;
            this.IngredientTable.Name = "IngredientTable";
            this.IngredientTable.ReadOnly = true;
            this.IngredientTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IngredientTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.IngredientTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IngredientTable.Size = new System.Drawing.Size(776, 150);
            this.IngredientTable.TabIndex = 8;
            this.IngredientTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngredientTable_CellClick);
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
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма ингредиентов";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngredientTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnChange;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label LabIngredient;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridView IngredientTable;
        private System.Windows.Forms.Label LabColor;
        private System.Windows.Forms.Label label1;
    }
}