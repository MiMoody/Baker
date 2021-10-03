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
    public partial class IngredientsForm : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        int Id;
        public IngredientsForm()
        {
            InitializeComponent();
        }
        public void UpdateTable()
        {
            try
            {
                //var query = from ing in db.ingridients
                //            join pr in db.Provider on ing.IdProvider equals pr.Idprovider
                //            join un in db.Units on ing.Unit equals un.IdUnit
                //            join unm in db.UnitMoney on ing.IdUnitMoney equals unm.IdUnit
                //            select new
                //            {
                //                Name = ing.Name,
                //                NameProvider = pr.Name
                //            };

                DataTable tableIng = new DataTable();
                new ingridients().Read(tableIng);
                IngredientTable.DataSource = tableIng;

                if (IngredientTable.Rows.Count > 0)
                {
                    IngredientTable.Columns[0].Visible = false;
                    IngredientTable.Columns[1].HeaderText = "Наименование";
                    IngredientTable.Columns[2].HeaderText = "Количество";
                    IngredientTable.Columns[3].HeaderText = "Ед. измерения";
                    IngredientTable.Columns[4].HeaderText = "Поставщик";
                    IngredientTable.Columns[5].HeaderText = "Цена";
                    IngredientTable.Columns[6].HeaderText = "Валюта";
                    Id = Convert.ToInt32(IngredientTable[0, 0].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()) ;
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void IngredientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(IngredientTable[0,e.RowIndex].Value);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            new CreateIngredient().Show();

        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            new Changeingredient(Id).Show();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этот ингредиент?", null, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    ingridients ing = db.ingridients.Where(p => p.Idingridient == Id).FirstOrDefault();
                    db.ingridients.Remove(ing);
                    db.SaveChanges();
                    UpdateTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


            }
        }
    }
}
