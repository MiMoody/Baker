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
    public partial class CreateIngredient : Form
    {

        Pekarnya2Entities db = new Pekarnya2Entities();
        public CreateIngredient()
        {
            InitializeComponent();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateIngredient_Load(object sender, EventArgs e)
        {
           
            var TableUnits = db.Units.ToList();
            var TableProvider = db.Provider.ToList();
            var TableUnitsMoney = db.UnitMoney.ToList();
            CmbUnits.DataSource = TableUnits;
            CmbUnits.DisplayMember = "Name";
            CmbUnits.ValueMember = "IdUnit";
            //CmbUnits.SelectedIndex = 1;
            CmbProvider.DataSource = TableProvider;
            CmbProvider.DisplayMember = "Name";
            CmbProvider.ValueMember = "Idprovider";
            CmbUnitMoney.DataSource = TableUnitsMoney;
            CmbUnitMoney.DisplayMember = "Name";
            CmbUnitMoney.ValueMember = "IdUnit";


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            IngredientsForm ing = new IngredientsForm();
            ing.Visible = true;
            ing.ShowInTaskbar = true;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtName.Text != string.Empty && TxtQuantity.Text != string.Empty && TxtPrice.Text != string.Empty)
                {
                    if (Convert.ToDouble(TxtPrice.Text)>0)
                    {
                        ingridients ing = new ingridients
                        {
                            Name = TxtName.Text,
                            Quantity = Convert.ToInt32(TxtQuantity.Text),
                            Price = Convert.ToDecimal(TxtPrice.Text),
                            Unit = Convert.ToInt32(CmbUnits.SelectedValue),
                            IdProvider = Convert.ToInt32(CmbProvider.SelectedValue),
                            IdUnitMoney = Convert.ToInt32(CmbUnitMoney.SelectedValue)
                        };
                        db.ingridients.Add(ing);
                        db.SaveChanges();
                        new IngredientsForm().UpdateTable();
                        MessageBox.Show("Вы успешно добавили ингредиент!");
                        this.Close();
                        IngredientsForm ingred = new IngredientsForm();
                        ingred.Visible = true;
                        ingred.ShowInTaskbar = true;
                    }
                    else MessageBox.Show("Вы неккоректно заполнили поля!");
                }
                else MessageBox.Show("Вы заполнили не все поля!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
