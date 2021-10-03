
namespace Baker
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnProvider = new System.Windows.Forms.Button();
            this.BtnGoods = new System.Windows.Forms.Button();
            this.BtnIngridients = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnProvider
            // 
            this.BtnProvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnProvider.Location = new System.Drawing.Point(228, 91);
            this.BtnProvider.Name = "BtnProvider";
            this.BtnProvider.Size = new System.Drawing.Size(162, 37);
            this.BtnProvider.TabIndex = 0;
            this.BtnProvider.Text = "Поставщики";
            this.BtnProvider.UseVisualStyleBackColor = true;
            this.BtnProvider.Click += new System.EventHandler(this.BtnProvider_Click);
            // 
            // BtnGoods
            // 
            this.BtnGoods.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnGoods.Location = new System.Drawing.Point(228, 145);
            this.BtnGoods.Name = "BtnGoods";
            this.BtnGoods.Size = new System.Drawing.Size(162, 37);
            this.BtnGoods.TabIndex = 1;
            this.BtnGoods.Text = "Продукты";
            this.BtnGoods.UseVisualStyleBackColor = true;
            this.BtnGoods.Click += new System.EventHandler(this.BtnGoods_Click);
            // 
            // BtnIngridients
            // 
            this.BtnIngridients.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnIngridients.Location = new System.Drawing.Point(228, 200);
            this.BtnIngridients.Name = "BtnIngridients";
            this.BtnIngridients.Size = new System.Drawing.Size(162, 37);
            this.BtnIngridients.TabIndex = 2;
            this.BtnIngridients.Text = "Ингредиенты";
            this.BtnIngridients.UseVisualStyleBackColor = true;
            this.BtnIngridients.Click += new System.EventHandler(this.BtnIngridients_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(12, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(82, 33);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Выход";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LabColor
            // 
            this.LabColor.BackColor = System.Drawing.SystemColors.Info;
            this.LabColor.Location = new System.Drawing.Point(-1, -1);
            this.LabColor.Name = "LabColor";
            this.LabColor.Size = new System.Drawing.Size(625, 50);
            this.LabColor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(-1, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 50);
            this.label1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnIngridients);
            this.Controls.Add(this.BtnGoods);
            this.Controls.Add(this.BtnProvider);
            this.Controls.Add(this.LabColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProvider;
        private System.Windows.Forms.Button BtnGoods;
        private System.Windows.Forms.Button BtnIngridients;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabColor;
        private System.Windows.Forms.Label label1;
    }
}

