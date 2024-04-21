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
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        // Добавляет товаор в базу
        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                bool isSuccess = DatabaseHelper.AddNewProducts(txtNameProduct.Text, txtCostPerUnit.Text);

                if (isSuccess)
                {
                    MessageBox.Show("Товар успешно добавлен.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при добавлении товара.");
                }
            }
        }


        // Валидация входных данных
        private bool ValidateInputs()
        {
            // Проверка, что название товара не пустое
            if (string.IsNullOrWhiteSpace(txtNameProduct.Text))
            {
                MessageBox.Show("Введите название товара.", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNameProduct.Focus();
                return false;
            }

            // Проверка, что цена за единицу товара это валидное число
            if (!decimal.TryParse(txtCostPerUnit.Text, out decimal cost))
            {
                MessageBox.Show("Введите корректную стоимость за единицу товара.", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCostPerUnit.Focus();
                return false;
            }

            return true;
        }

        // Закрыть форму без сохранения изменений
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
