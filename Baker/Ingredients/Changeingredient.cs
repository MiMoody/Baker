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
    public partial class Changeingredient : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        int Id;
        ingridients ingridients;
        public Changeingredient(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void Changeingredient_Load(object sender, EventArgs e)
        {
            var TableUnits = db.Units.ToList();
            var TableProvider = db.Provider.ToList();
            var TableUnitsMoney = db.UnitMoney.ToList();
            ingridients = db.ingridients.Where(p => p.Idingridient == Id).FirstOrDefault();
            TxtName.Text = ingridients.Name;
            TxtQuantity.Text = ingridients.Quantity.ToString();
            TxtPrice.Text = ingridients.Price.ToString();
            CmbUnits.DataSource = TableUnits;
            CmbUnits.DisplayMember = "Name";
            CmbUnits.ValueMember = "IdUnit";
            CmbUnits.SelectedIndex = ingridients.Unit-1;
            CmbProvider.DataSource = TableProvider;
            CmbProvider.DisplayMember = "Name";
            CmbProvider.ValueMember = "Idprovider";
            CmbProvider.SelectedValue = ingridients.IdProvider;
            CmbUnitMoney.DataSource = TableUnitsMoney;
            CmbUnitMoney.DisplayMember = "Name";
            CmbUnitMoney.ValueMember = "IdUnit";
            CmbUnitMoney.SelectedValue = ingridients.IdUnitMoney;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            IngredientsForm ing = new IngredientsForm();
            ing.Visible = true;
            ing.ShowInTaskbar = true;
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                ingridients.Name = TxtName.Text;
                ingridients.Quantity = Convert.ToInt32(TxtQuantity.Text);
                ingridients.Price = Convert.ToDecimal(TxtPrice.Text);
                ingridients.IdProvider = Convert.ToInt32(CmbProvider.SelectedValue);
                ingridients.Unit = Convert.ToInt32(CmbUnits.SelectedValue);
                ingridients.IdUnitMoney = Convert.ToInt32(CmbUnitMoney.SelectedValue);
                db.SaveChanges();
                MessageBox.Show("Вы успешно отредактировали данные об ингридиенте!");
                this.Close();
                IngredientsForm ing = new IngredientsForm();
                ing.Visible = true;
                ing.ShowInTaskbar = true;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
