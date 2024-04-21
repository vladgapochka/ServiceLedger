using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using MySql.Data.MySqlClient;

namespace ServiceLedger
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            LoadClientsData();
            btnOpenClientsForm.Click += (s, e) => OpenForm(new MainForm());
            btnOpenProductsForm.Click += (s, e) => OpenForm(new ProductsForm());
            btnOpenSalesForm.Click += (s, e) => OpenForm(new SalesEntryForm());
            this.FormClosed += MainForm_FormClosed;
        }

        // Завершаем работу приложения
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        // Загрузка данных о клиентах в GridControl
        private void LoadClientsData()
        {
            gridControl1.DataSource = DatabaseHelper.GetAllClients();
            SetupClientsGridView(); // Настройка отображения столбцов на русском языке
        }

       //Настройка таблицы
        private void SetupClientsGridView()
        {
            var gridView = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;

            if (gridView != null)
            {
                gridView.Columns["ClientID"].Visible = false;
                gridView.Columns["Name"].Caption = "Имя клиента";
                gridView.Columns["Phone"].Caption = "Телефон";
                gridView.Columns["Email"].Caption = "Электронная почта";
                
            }
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



        // Добавление нового клиента
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            using (var form = new AddClient())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadClientsData(); // Обновление списка клиентов после добавления
                }
            }
        }

        // Редактирование данных клиента
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (GetSelectedClientId(out var clientId))
            {
                using (var form = new UpdateClient(clientId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadClientsData(); 
                    }
                }
            }
        }

        // Удаление клиента
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (GetSelectedClientId(out var clientId) &&
                MessageBox.Show("Вы уверены, что хотите удалить выбранного клиента?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes &&
                DatabaseHelper.DeleteClient(clientId))
            {
                LoadClientsData(); 
            }
        }

        // Получение ID выбранного клиента из GridControl
        private bool GetSelectedClientId(out string clientId)
        {
            var gridView = gridControl1.MainView as GridView;
            int selectedRowIndex = gridView.FocusedRowHandle;

            if (selectedRowIndex != GridControl.InvalidRowHandle)
            {
                clientId = gridView.GetRowCellValue(selectedRowIndex, "ClientID").ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Нет выбранной строки.");
                clientId = null;
                return false;
            }
        }
    }
}
