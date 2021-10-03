using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baker
{
    public partial class GoodsForn : Form
    {
        Pekarnya2Entities db = new Pekarnya2Entities();
        int Id;
        public GoodsForn()
        {
            InitializeComponent();
        }

        private void GoodsForn_Load(object sender, EventArgs e)
        {
            UpdateTable();
            CmbGender.SelectedIndex = 0;
        }
        public void UpdateTable()
        {
            var query = from goods in db.Goods
                        join un in db.Units on goods.IdUnit equals un.IdUnit
                        join unm in db.UnitMoney on goods.IdUnitMoney equals unm.IdUnit
                        select new
                        { 
                            IdGoods = goods.IdGooods,
                            NameGood = goods.Name,
                            Quantity = goods.Quantity,
                            Unit = un.Name,
                            Price = goods.Price,
                            UnitMoney = unm.Name


                        };
            GoodsTable.DataSource = query.ToList();
            GoodsTable.Columns[0].Visible = false;
            GoodsTable.Columns[1].HeaderText = "Наименование";
            GoodsTable.Columns[2].HeaderText = "Количество";
            GoodsTable.Columns[3].HeaderText = "Ед. измерения";
            GoodsTable.Columns[4].HeaderText = "Цена";
            GoodsTable.Columns[5].HeaderText = "Валюта";

            if (GoodsTable.Rows.Count > 0)
            {
                Id = Convert.ToInt32(GoodsTable[0, 0].Value);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            new GoodsCreate().Show();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {   
            string search = TxtSearch.Text;    
            var query = from goods in db.Goods
                        join un in db.Units on goods.IdUnit equals un.IdUnit
                        join unm in db.UnitMoney on goods.IdUnitMoney equals unm.IdUnit
                        where  DbFunctions.Like(goods.Name, "%" + search + "%") || DbFunctions.Like(un.Name, "%" + search + "%")
                        select new
                        {
                            IdGoods = goods.IdGooods,
                            NameGood = goods.Name,
                            Quantity = goods.Quantity,
                            Unit = un.Name,
                            Price = goods.Price,
                            UnitMoney = unm.Name
                        };
            GoodsTable.DataSource = query.ToList();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {

            var query = from goods in db.Goods
                        join un in db.Units on goods.IdUnit equals un.IdUnit
                        join unm in db.UnitMoney on goods.IdUnitMoney equals unm.IdUnit
                        orderby un.Name 
                        select new
                        {
                            IdGoods = goods.IdGooods,
                            NameGood = goods.Name,
                            Quantity = goods.Quantity,
                            Unit = un.Name,
                            Price = goods.Price,
                            UnitMoney = unm.Name
                        };
            GoodsTable.DataSource = query.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGender.SelectedIndex == 1)
            {
                var query = from goods in db.Goods
                            join un in db.Units on goods.IdUnit equals un.IdUnit
                            join unm in db.UnitMoney on goods.IdUnitMoney equals unm.IdUnit
                            where unm.IdUnit == 1
                            select new
                            {
                                IdGoods = goods.IdGooods,
                                NameGood = goods.Name,
                                Quantity = goods.Quantity,
                                Unit = un.Name,
                                Price = goods.Price,
                                UnitMoney = unm.Name
                            };
                GoodsTable.DataSource = query.ToList();
            }
            else if (CmbGender.SelectedIndex == 2)
            {
                var query = from goods in db.Goods
                            join un in db.Units on goods.IdUnit equals un.IdUnit
                            join unm in db.UnitMoney on goods.IdUnitMoney equals unm.IdUnit
                            where unm.IdUnit == 2
                            select new
                            {
                                IdGoods = goods.IdGooods,
                                NameGood = goods.Name,
                                Quantity = goods.Quantity,
                                Unit = un.Name,
                                Price = goods.Price,
                                UnitMoney = unm.Name
                            };
                GoodsTable.DataSource = query.ToList();
            }
            else
            {
                var query = from goods in db.Goods
                            join un in db.Units on goods.IdUnit equals un.IdUnit
                            join unm in db.UnitMoney on goods.IdUnitMoney equals unm.IdUnit
                            select new
                            {
                                IdGoods = goods.IdGooods,
                                NameGood = goods.Name,
                                Quantity = goods.Quantity,
                                Unit = un.Name,
                                Price = goods.Price,
                                UnitMoney = unm.Name


                            };
                GoodsTable.DataSource = query.ToList();
            }
        }
    }
}
