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
    public partial class ProviderForm : Form
    {
        int TotalPages;
        int CurrentIndexPage =1;
        int PageSize;
        Pekarnya2Entities db = new Pekarnya2Entities();
        int Id;
        string NameProvider, EmailProvider, PhoneProvider;
        public ProviderForm()
        {
            InitializeComponent();
        }
        private void CalculateTotalPages()
        {
            int RowCount = Convert.ToInt32(db.Provider.ToList().Count());
            TotalPages = RowCount / PageSize;
            if(RowCount % PageSize > 0)
                TotalPages += 1;
        }
        private List<Provider> GetCurrentRecords(int page)
        {
            List<Provider> list = new List<Provider>();

            if (page == 1)
            {
                list = db.Provider.OrderBy(p => p.Idprovider).Take(PageSize).ToList();
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * PageSize;
                var NoProviders = db.Provider.Select(p => p.Idprovider).Take(PreviousPageOffSet).ToArray();
                list = db.Provider.Where(p => !NoProviders.Contains(p.Idprovider)).Take(PageSize).ToList();
            }
           
            return list;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
         public void UpdateTable()
        {
            CmbPagesCount.SelectedIndex = 0;
            PageSize = Convert.ToInt32(db.Provider.ToList().Count());
            CalculateTotalPages();
            ProviderTable.DataSource = db.Provider.ToList();
            ProviderTable.Columns[4].Visible = false;
            ProviderTable.Columns[0].Visible = false;
            ProviderTable.Columns[1].HeaderText = "Наименование";
            if (ProviderTable.Rows.Count > 0)
            {
                Id = Convert.ToInt32(ProviderTable[0, 0].Value);
                NameProvider = ProviderTable[1, 0].Value.ToString();
                EmailProvider = ProviderTable[2, 0].Value.ToString();
                PhoneProvider = ProviderTable[3, 0].Value.ToString();
            }
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //Class1.formProv = this;
            this.Close();
            new FormCreateProvider().Show();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого поставщика?", null, MessageBoxButtons.YesNo) ;
            if (result == DialogResult.Yes)
            {
                try 
                {
                    Provider provider = db.Provider.Where(p => p.Idprovider == Id).FirstOrDefault();
                    db.Provider.Remove(provider);
                    db.SaveChanges();
                    UpdateTable();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                
            }

              
        }

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (CurrentIndexPage < TotalPages)
            {
                CurrentIndexPage++;
                ProviderTable.DataSource =
                GetCurrentRecords(CurrentIndexPage);
            }
        }

        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (CurrentIndexPage > 1)
            {
                CurrentIndexPage--;
                ProviderTable.DataSource =
                GetCurrentRecords(CurrentIndexPage);
            }
        }

        private void CmbPagesCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbPagesCount.SelectedIndex == 0) UpdateTable();
            else
            {
                PageSize = Convert.ToInt32(CmbPagesCount.SelectedItem);
                CalculateTotalPages();
                ProviderTable.DataSource = GetCurrentRecords(1);

            }
        }

        private void ProviderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(ProviderTable[0, e.RowIndex].Value);
                NameProvider = ProviderTable[1, e.RowIndex].Value.ToString();
                EmailProvider = ProviderTable[2, e.RowIndex].Value.ToString();
                PhoneProvider = ProviderTable[3, e.RowIndex].Value.ToString();
            }
            catch {
            }

            
       
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            ChangeProvider changeProvider = new ChangeProvider(Id,NameProvider,EmailProvider,PhoneProvider);
            changeProvider.Show();
            this.Visible = false;
            this.ShowInTaskbar = false;
        }
    }
}
