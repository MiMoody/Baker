
namespace Baker
{
    partial class ChangeProvider
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabColor = new System.Windows.Forms.Label();
            this.LabChangeProvider = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabName = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.BtnClose);
            this.MainPanel.Controls.Add(this.LabColor);
            this.MainPanel.Controls.Add(this.LabChangeProvider);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(616, 385);
            this.MainPanel.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.Location = new System.Drawing.Point(11, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 29);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "Назад";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LabColor
            // 
            this.LabColor.BackColor = System.Drawing.SystemColors.Info;
            this.LabColor.Location = new System.Drawing.Point(-9, 0);
            this.LabColor.Name = "LabColor";
            this.LabColor.Size = new System.Drawing.Size(625, 50);
            this.LabColor.TabIndex = 22;
            // 
            // LabChangeProvider
            // 
            this.LabChangeProvider.AutoSize = true;
            this.LabChangeProvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabChangeProvider.Location = new System.Drawing.Point(178, 73);
            this.LabChangeProvider.Name = "LabChangeProvider";
            this.LabChangeProvider.Size = new System.Drawing.Size(255, 19);
            this.LabChangeProvider.TabIndex = 15;
            this.LabChangeProvider.Text = "Редактирование поставщика";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtPhone.Location = new System.Drawing.Point(204, 251);
            this.TxtPhone.Mask = "9 (999) 999-99-99";
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(203, 23);
            this.TxtPhone.TabIndex = 24;
            this.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCreate.Location = new System.Drawing.Point(251, 288);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(106, 28);
            this.BtnCreate.TabIndex = 21;
            this.BtnCreate.Text = "Изменить";
            this.BtnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(264, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(276, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email";
            // 
            // LabName
            // 
            this.LabName.AutoSize = true;
            this.LabName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabName.Location = new System.Drawing.Point(245, 113);
            this.LabName.Name = "LabName";
            this.LabName.Size = new System.Drawing.Size(134, 19);
            this.LabName.TabIndex = 18;
            this.LabName.Text = "Наименование";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtEmail.Location = new System.Drawing.Point(204, 189);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(205, 23);
            this.TxtEmail.TabIndex = 17;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtName.Location = new System.Drawing.Point(202, 136);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(205, 23);
            this.TxtName.TabIndex = 16;
            this.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(-9, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 50);
            this.label2.TabIndex = 23;
            // 
            // ChangeProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 385);
            this.Controls.Add(this.TxtPhone);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeProvider";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LabColor;
        private System.Windows.Forms.Label LabChangeProvider;
        private System.Windows.Forms.MaskedTextBox TxtPhone;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabName;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
    }
}