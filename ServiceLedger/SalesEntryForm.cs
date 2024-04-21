using DevExpress.Data.PivotGrid;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLedger
{
    public partial class SalesEntryForm : Form
    {
        public SalesEntryForm()
        {
            InitializeComponent();
            LoadClientsList2();
            SetupPivotGrid();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            LoadClientsList();
            SetCurrentDateTime();
            InitializeSalesGrid();
            LoadPivotGridData();
            dtpStartDate.ValueChanged += new EventHandler(OnDateChanged);
            dtpEndDate.ValueChanged += new EventHandler(OnDateChanged);
            btnOpenClientsForm.Click += (s, e) => OpenForm(new MainForm());
            btnOpenProductsForm.Click += (s, e) => OpenForm(new ProductsForm());
            btnOpenSalesForm.Click += (s, e) => OpenForm(new SalesEntryForm());
            this.FormClosed += SalesEntryForm_FormClosed;
        }

        // Завершаем работу приложения
        private void SalesEntryForm_FormClosed(object sender, FormClosedEventArgs e)
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


        // Загрузка данных о клиенте в comboBox
        private void LoadClientsList()
        {
            var clientsTable = DatabaseHelper.GetAllClients();
            comboBoxClients.Properties.DataSource = clientsTable;
            comboBoxClients.Properties.DisplayMember = "Name";
            comboBoxClients.Properties.ValueMember = "ClientID";

        }

        // Установка текущей даты
        private void SetCurrentDateTime()
        {
            dateEditSaleDate.EditValue = DateTime.Now; 
        }

        // Настройка таблицы добавления продаж
        private void InitializeSalesGrid()
        {
            DataTable salesDataTable = new DataTable();

            salesDataTable.Columns.Add("ProductID", typeof(int));
            salesDataTable.Columns.Add("ProductName", typeof(string));
            salesDataTable.Columns.Add("Quantity", typeof(int));
            salesDataTable.Columns.Add("CostPerUnit", typeof(decimal));
            salesDataTable.Columns.Add("TotalCost", typeof(decimal), "Quantity * CostPerUnit");


            
            gridControlSales.DataSource = salesDataTable;

            var gridView = gridControlSales.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                // Настройка внешнего вида и поведения столбцов
                gridView.Columns["ProductID"].Visible = false; 
                gridView.Columns["ProductName"].Caption = "Товар";
                gridView.Columns["Quantity"].Caption = "Кол-во";
                gridView.Columns["CostPerUnit"].Caption = "Цена за единицу";
                gridView.Columns["TotalCost"].Caption = "Общая стоймость";
                gridView.Columns["TotalCost"].OptionsColumn.ReadOnly = true; 

                // Настройка редактирования столбцов
                gridView.OptionsBehavior.Editable = true; 
                gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            }
        }

        // Добавление товара
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (ProductSelectionForm selectionForm = new ProductSelectionForm())
            {
                if (selectionForm.ShowDialog() == DialogResult.OK)
                {
                    int productId = selectionForm.SelectedProductId;
                    string productName = selectionForm.SelectedProductName;
                    int quantity = selectionForm.SelectedQuantity;
                    decimal price = selectionForm.SelectedProductPrice;

                    DataTable dataTable = gridControlSales.DataSource as DataTable;
                   
                    DataRow newRow = dataTable.NewRow();
                    newRow["ProductID"] = productId;
                    newRow["ProductName"] = productName;
                    newRow["Quantity"] = quantity;
                    newRow["CostPerUnit"] = price; 
                    dataTable.Rows.Add(newRow);

                }
            }
        }

        // Удаление товара из таблицы
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            var gridView = gridControlSales.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView.SelectedRowsCount > 0)
            {
                int selectedRowHandle = gridView.FocusedRowHandle;
                if (selectedRowHandle >= 0)
                {
                    gridView.DeleteRow(selectedRowHandle);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        // Добавление продажи в бд 
        private void btnAddSale_Click(object sender, EventArgs e)
        {
            int clientId = (int)comboBoxClients.EditValue;
            DateTime saleDate = dateEditSaleDate.DateTime;

            DataTable products = (DataTable)gridControlSales.DataSource;

            bool saleAdded = DatabaseHelper.AddNewSale(clientId, saleDate, products);
            if (saleAdded)
            {
                MessageBox.Show("Продажа успешно добавлена.");
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении продажи.");
            }
        }

        private void OnDateChanged(object sender, EventArgs e)
        {
            LoadPivotGridData();
        }

        // Настройка сводной таблицы продаж
        private void LoadPivotGridData()
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);

            DataTable salesData = DatabaseHelper.GetSalesData(startDate, endDate);
            pivotGridControl1.DataSource = salesData;

            pivotGridControl1.RetrieveFields();

            pivotGridControl1.Fields["ClientName"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["ProductName"].Area = PivotArea.RowArea;
            pivotGridControl1.Fields["Quantity"].Area = PivotArea.DataArea;
            pivotGridControl1.Fields["TotalCost"].Area = PivotArea.DataArea;
            pivotGridControl1.Fields["SaleDateTime"].Area = PivotArea.ColumnArea;

            pivotGridControl1.Fields["SaleDateTime"].GroupInterval = PivotGroupInterval.DateMonth;

            pivotGridControl1.Fields["ClientName"].Caption = "Клиент";
            pivotGridControl1.Fields["ProductName"].Caption = "Продукт";
            pivotGridControl1.Fields["Quantity"].Caption = "Количество";
            pivotGridControl1.Fields["TotalCost"].Caption = "Общая Стоимость";
            pivotGridControl1.Fields["SaleDateTime"].Caption = "Дата Продажи";

            pivotGridControl1.BestFit();
        }

        // Загрузка списка клиентов в comboBoxClient2
        private void LoadClientsList2()
        {
            DataTable clientsTable = DatabaseHelper.GetAllClients();
            comboBoxClient2.Properties.DataSource = clientsTable;
            comboBoxClient2.Properties.DisplayMember = "Name";
            comboBoxClient2.Properties.ValueMember = "ClientID";
        }

        // Настройка pivotGridControl2 или отчета оказанных услуг по клиенту
        private void SetupPivotGrid()
        {
            int clientId = Convert.ToInt32(comboBoxClient2.EditValue);
            DateTime startDate = dtpStartDate2.Value.Date;
            DateTime endDate = dtpEndDate2.Value.Date.AddDays(1).AddTicks(-1);
            DataTable salesData = DatabaseHelper.GetClientSalesReport(clientId, startDate, endDate);

            pivotGridControl2.DataSource = salesData;

            pivotGridControl2.RetrieveFields();

            SetupPivotGridField(pivotGridControl2.Fields["ClientName"], "Клиент", PivotArea.RowArea);
            SetupPivotGridField(pivotGridControl2.Fields["ProductName"], "Продукт", PivotArea.RowArea);
            SetupPivotGridField(pivotGridControl2.Fields["Quantity"], "Количество", PivotArea.DataArea);
            SetupPivotGridField(pivotGridControl2.Fields["TotalCost"], "Общая Стоимость", PivotArea.DataArea);
            SetupPivotGridField(pivotGridControl2.Fields["SaleDateTime"], "Месяц продажи", PivotArea.ColumnArea, PivotGroupInterval.DateMonth);
        }

        private void SetupPivotGridField(PivotGridField field, string caption, PivotArea area, PivotGroupInterval? groupInterval = null)
        {
            if (field == null) return;

            field.Area = area;
            field.Caption = caption;

            if (groupInterval.HasValue)
            {
                field.GroupInterval = groupInterval.Value;
            }
        }


        // Генерация отчета 
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (comboBoxClient2.EditValue is null)
            {
                MessageBox.Show("Выберите клиента для формирования отчета.");
                return;
            }

            int clientId = Convert.ToInt32(comboBoxClient2.EditValue);
            DateTime startDate = dtpStartDate2.Value.Date; 
            DateTime endDate = dtpEndDate2.Value.Date.AddDays(1).AddSeconds(-1); 

            DataTable reportData = DatabaseHelper.GetClientSalesReport(clientId, startDate, endDate);
            pivotGridControl2.DataSource = reportData;

            pivotGridControl2.RefreshData();
            pivotGridControl2.BestFit();
        }

        
    }
}
