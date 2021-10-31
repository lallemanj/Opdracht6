using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseAdventureWorks
{
    public partial class AdventureWorks : Form
    {
        public AdventureWorks()
        {
            InitializeComponent();
            MessageBox.Show("Linker kolom kunt u per klik een currency code krijgen door de volgorde, rechter kolom kan u uit de lijst kiezen welke currency munt u wilt zien");
        }

        private void countryRegionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.countryRegionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorksDataSet);

        }

        private void AdventureWorks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.adventureWorksDataSet.Currency);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.CountryRegionCurrency' table. You can move, or remove it, as needed.
            this.countryRegionCurrencyTableAdapter.Fill(this.adventureWorksDataSet.CountryRegionCurrency);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.CountryRegion' table. You can move, or remove it, as needed.
            this.countryRegionTableAdapter.Fill(this.adventureWorksDataSet.CountryRegion);

        }

        private void countryRegionCurrencyDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                //if (countryRegionCurrencyDataGridView == currencyDataGridView)
            {
                DataGridViewRow row = countryRegionCurrencyDataGridView.Rows[e.RowIndex];

                textBox1.Text = row.Cells[1].Value.ToString();

                //txtName.Text = row.Cells[1].Value.ToString();
                //txtCountry.Text = row.Cells[2].Value.ToString();
            }
        }

        private void currencyDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            //if (countryRegionCurrencyDataGridView == currencyDataGridView)
            {
                DataGridViewRow row = currencyDataGridView.Rows[e.RowIndex];
                textBox2.Text = row.Cells[1].Value.ToString();
                //txtName.Text = row.Cells[1].Value.ToString();
                //txtCountry.Text = row.Cells[2].Value.ToString();
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.countryRegionCurrencyTableAdapter.FillBy(this.adventureWorksDataSet.CountryRegionCurrency);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
