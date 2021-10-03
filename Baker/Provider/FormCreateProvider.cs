using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baker
{
    public partial class FormCreateProvider : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        public FormCreateProvider()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
         new ProviderForm().Show();
            

        }

        private void TxxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string NameProvider, Email, Phone;
            NameProvider = TxtName.Text;
            Email = TxtEmail.Text;
            Phone = TxtPhone.Text;
            if (NameProvider != String.Empty && Email != String.Empty)
            {
                Provider provider = new Provider { Name = NameProvider, Email = Email, Phone = Phone };
                db.Provider.Add(provider);
                db.SaveChanges();
                MessageBox.Show("Вы успешно добавили поставщика");
                this.Close();
                ProviderForm providerForm = new ProviderForm();
                providerForm.UpdateTable();
                providerForm.ShowInTaskbar = true;
                providerForm.Visible = true;
            }
            else MessageBox.Show("Вы не ввели данные!");




        }

        private void FormCreateProvider_Load(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
