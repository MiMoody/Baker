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
    public partial class GoodsCreate : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        public GoodsCreate()
        {
            InitializeComponent();
        }

        private void GoodsCreate_Load(object sender, EventArgs e)
        {
            var TableUnits = db.Units.ToList();
            var TableUnitsMoney = db.UnitMoney.ToList();
            CmbUnits.DataSource = TableUnits;
            CmbUnits.DisplayMember = "Name";
            CmbUnits.ValueMember = "IdUnit";
            CmbUnitMoney.DataSource = TableUnitsMoney;
            CmbUnitMoney.DisplayMember = "Name";
            CmbUnitMoney.ValueMember = "IdUnit";
            var TableIng = from ing in db.ingridients
                           select new 
                           { Iding = ing.Idingridient, NameIng = ing.Name };
            ListIngridient.DataSource = TableIng.ToList();
            ListIngridient.DisplayMember = "NameIng";
            ListIngridient.ValueMember = "Iding";
            CompositionTable.Columns.Add("Iding","Id");
            CompositionTable.Columns.Add("NameIng","Наименование");
            //CompositionTable.Columns["Iding"].Visible = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            new GoodsForn().Show();
        }

        private void BtnAddIng_Click(object sender, EventArgs e)
        {
            if (ListIngridient.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(ListIngridient.SelectedValue);
                string name = db.ingridients.Where(p => p.Idingridient == id).FirstOrDefault().Name; 
                CompositionTable.Rows.Add(id, name);
            }
            else { MessageBox.Show("Вы не выбрали ингредиент!"); }
        }

        private void BtnDelIng_Click(object sender, EventArgs e)
        {
            if (CompositionTable.RowCount > 0)
            {
                CompositionTable.Rows.Remove(CompositionTable.SelectedRows[0]);
            }
            else MessageBox.Show("В таблице нечего удалять!");
           
        }

        private void BtnCreateGood_Click(object sender, EventArgs e)
        {
            if (CompositionTable.RowCount>0&&TxtName.Text!=string.Empty&&TxtPrice.Text!=string.Empty&&TxtQuantity.Text!=String.Empty)
            {
                Goods goods = new Goods
                {
                    Name = TxtName.Text,
                    Quantity = Convert.ToInt32(TxtQuantity.Text),
                    Price = Convert.ToDecimal(TxtPrice.Text),
                    IdUnit = Convert.ToInt32(CmbUnits.SelectedValue),
                    IdUnitMoney = Convert.ToInt32(CmbUnitMoney.SelectedValue)
                };
                db.Goods.Add(goods);
                db.SaveChanges();
                int MaxId = Convert.ToInt32(db.Goods.Max(p=>p.IdGooods));   
                for (int i = 0; i < CompositionTable.RowCount; i++)
                {
                    ElementGoods element = new ElementGoods();
                    element.IdGoods = MaxId;
                    element.IdIngridient = Convert.ToInt32(CompositionTable[0, i].Value);
                    db.ElementGoods.Add(element);
                    db.SaveChanges();
                }
                MessageBox.Show("Вы успешно добавили продукт!");
                this.Close();
                new GoodsForn().Show();
                
            }
            
        }

        private void ListIngridient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
