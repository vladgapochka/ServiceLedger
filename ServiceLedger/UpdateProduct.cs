using DevExpress.Utils.About;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ServiceLedger
{
    public partial class UpdateProduct : Form
    {
        private string productId;
        public UpdateProduct(string productId)
        {
            InitializeComponent();
            this.productId = productId;
            LoadProductsData(productId);
        }

        private void LoadProductsData(string productId)
        {
            try
            {
                using (var connection = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT ProductName, CostPerUnit FROM Products WHERE ProductID = @ProductID";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProductName.Text = reader["ProductName"].ToString();
                                txtCostPerUnit.Text = reader["CostPerUnit"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Товар не найден.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных клиента: " + ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            {
                // Собираем обновленные данные из полей ввода
                string productName = txtProductName.Text; // предполагается, что у вас есть TextBox с таким именем
                string costPerUnit = txtCostPerUnit.Text;

                // Вызываем метод обновления данных клиента
                if (DatabaseHelper.UpdateProduct(productId, productName, costPerUnit))
                {
                    MessageBox.Show("Данные по товару обновлены.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении данных.");
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
