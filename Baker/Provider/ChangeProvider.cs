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
    public partial class ChangeProvider : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        int IdProvider;
        public ChangeProvider(int id,string nameProv, string emailProv, string phoneProv)
        {
            InitializeComponent();
            IdProvider = id;
            TxtName.Text = nameProv;
            TxtEmail.Text = emailProv;
            TxtPhone.Text = phoneProv;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            ProviderForm providerForm = new ProviderForm();
            providerForm.ShowInTaskbar = true;
            providerForm.Visible = true;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Provider provider = db.Provider.Where(p => p.Idprovider == IdProvider).FirstOrDefault();
                provider.Name = TxtName.Text;
                provider.Email = TxtEmail.Text;
                provider.Phone = TxtPhone.Text;
                db.SaveChanges();
                MessageBox.Show("Вы успешно обновили данные об поставщике!");
                this.Close();
                ProviderForm providerForm = new ProviderForm();
                providerForm.UpdateTable();
                providerForm.Visible = true;
                providerForm.ShowInTaskbar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            


        }
    }
}
