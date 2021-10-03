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
    public partial class MainForm : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnProvider_Click(object sender, EventArgs e)
        {
            ProviderForm provider = new ProviderForm();
            provider.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngridients_Click(object sender, EventArgs e)
        {
            IngredientsForm ingredientsForm = new IngredientsForm();
            ingredientsForm.Show();
            this.Visible = false;
            this.ShowInTaskbar = false;
        }

        private void BtnGoods_Click(object sender, EventArgs e)
        {
            new GoodsForn().Show();
            this.Hide();
        }
    }
}
