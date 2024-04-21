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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            LoadProductsData();
            btnOpenClientsForm.Click += (s, e) => OpenForm(new MainForm());
            btnOpenProductsForm.Click += (s, e) => OpenForm(new ProductsForm());
            btnOpenSalesForm.Click += (s, e) => OpenForm(new SalesEntryForm());
            this.FormClosed += ProductsForm_FormClosed;
        }

        // Завершаем работу приложения
        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Открытие другой формы
        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }


        // Загружает данные о товарах в gridControl
        private void LoadProductsData()
        {
            gridControl1.DataSource = DatabaseHelper.GetAllProducts();
            SetupProductsGridView();
        }

        //Настройка таблицы
        private void SetupProductsGridView()
        {
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                gridView.Columns["ProductID"].Visible = false;
                gridView.Columns["ProductName"].Caption = "Товар";
                gridView.Columns["CostPerUnit"].Caption = "Цена за единицу товара";

            }
        }


        // Добавляет товар
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var form = new AddProducts())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadProductsData(); 
                }
            }
        }


        // Редактирует выбранный продукт
        private void btnEditProduct_Click_1(object sender, EventArgs e)
        {
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            int selectedRowIndex = gridView.FocusedRowHandle;
            if (selectedRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                object productId = gridView.GetRowCellValue(selectedRowIndex, "ProductID");
                if (productId != null)
                {
                    using (var form = new UpdateProduct(productId.ToString()))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            // Обновление данных в GridControl после закрытия формы UpdateClient
                            LoadProductsData(); 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите товар для редактирования.");
                }
            }
            else
            {
                MessageBox.Show("Нет выбранной строки.");
            }
        }

        // Удаляет выбранный продукт
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            int selectedRowIndex = gridView.FocusedRowHandle;

            if (selectedRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                object productId = gridView.GetRowCellValue(selectedRowIndex, "ProductID");

                if (productId != null && MessageBox.Show("Вы уверены, что хотите удалить выбранный товар?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DatabaseHelper.DeleteProduct(productId.ToString()))
                    {
                        MessageBox.Show("Товар удалён.");
                        gridView.DeleteRow(selectedRowIndex); // Удаление строки из GridControl
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении товара.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите клиента для удаления.");
            }
        }

        
    }
}
