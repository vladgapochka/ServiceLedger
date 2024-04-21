using MySql.Data.MySqlClient;
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
    public partial class UpdateClient : Form
    {
        private string clientId;
        public UpdateClient(string clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
            LoadClientData(clientId);
        }

        // Загрузка данных о клиенте
        private void LoadClientData(string clientId)
        {
            try
            {
                using (var connection = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT Name, Phone, Email FROM Clients WHERE ClientID = @ClientID";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", clientId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text = reader["Name"].ToString();
                                txtPhone.Text = reader["Phone"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Клиент не найден.");
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

        // Сохранить изменения
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Все поля должны быть заполнены.");
                    return;
                }

                bool isSuccess = DatabaseHelper.UpdateClient(clientId, name, phone, email);

                if (isSuccess)
                {
                    MessageBox.Show("Данные клиента обновлены.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении данных.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }

        // Отмена обновления данных клиента
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
