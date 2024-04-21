using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLedger
{
    public partial class ProductSelectionForm : Form
    {
        public int SelectedProductId { get; private set; }
        public string SelectedProductName { get; private set; }
        public int SelectedQuantity { get; private set; }
        public decimal SelectedProductPrice { get; private set; }
        public ProductSelectionForm()
        {
            InitializeComponent();
            LoadProductsList();
        }

        // Загрузка comboBox  данныи о товарах
        private void LoadProductsList()
        {
            var productsTable = DatabaseHelper.GetAllProducts();
            lookUpEditProducts.Properties.DataSource = productsTable;
            lookUpEditProducts.Properties.DisplayMember = "ProductName";
            lookUpEditProducts.Properties.ValueMember = "ProductID";
        }

        // Класс для представления элемента в ComboBoxEdit
        public class ComboBoxItem
        {
            public string Description { get; set; }
            public object Value { get; set; }
            public override string ToString()
            {
                return Description;
            }
        }

        //Добавление товара
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lookUpEditProducts.EditValue != null && quantity.Value > 0)
            {
                SelectedProductId = Convert.ToInt32(lookUpEditProducts.EditValue);
                SelectedProductName = ((DataRowView)lookUpEditProducts.GetSelectedDataRow())["ProductName"].ToString();
                SelectedQuantity = Convert.ToInt32(quantity.Value);
                SelectedProductPrice = DatabaseHelper.GetProductPrice(SelectedProductId);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Выберите товар и укажите количество.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
