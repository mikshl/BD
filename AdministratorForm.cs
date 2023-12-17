using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приложение
{
    public partial class AdministratorForm : Form
    {
        private readonly DatabaseManager dbManager;
        private DataTable dataTable;
        public AdministratorForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager("Host=localhost;Username=postgres;Password=qwerty;Database=hookah");

            /// красота Серый цвет для текста в кнопках удаления
            {

                IdClientForDelTextBox.Text = "Введите id";
                IdClientForDelTextBox.ForeColor = Color.Gray;

                IdOrderForDelTextBox.Text = "Введите id";
                IdOrderForDelTextBox.ForeColor = Color.Gray;
            }
            // Инициализация DataGridView
            dataGridView1.ReadOnly = true;
            LoadData();

        }

        private void LoadData()
        {
            string sqlQuery = "SELECT * FROM OrderClientView";
            dataTable = dbManager.GetData(sqlQuery);

            if (dataTable != null)
            {
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = false;
            }
        }

       


        private void IdClientForDelTextBox_Enter(object sender, EventArgs e)
        {
            if (IdClientForDelTextBox.Text == "Введите id")
            {
                IdClientForDelTextBox.Text = "";
                IdClientForDelTextBox.ForeColor = Color.Black;
            }
        }

        private void IdClientForDelTextBox_Leave(object sender, EventArgs e)
        {
            if (IdClientForDelTextBox.Text == "")
            {
                IdClientForDelTextBox.Text = "Введите id";
                IdClientForDelTextBox.ForeColor = Color.Gray;
            }
        }

        private void IdOrderForDelTextBox_Enter(object sender, EventArgs e)
        {
            if (IdOrderForDelTextBox.Text == "Введите id")
            {
                IdOrderForDelTextBox.Text = "";
                IdOrderForDelTextBox.ForeColor = Color.Black;
            }
        }

        private void IdOrderForDelTextBox_Leave(object sender, EventArgs e)
        {
            if (IdOrderForDelTextBox.Text == "")
            {
                IdOrderForDelTextBox.Text = "Введите id";
                IdOrderForDelTextBox.ForeColor = Color.Gray;
            }
        }
        

        ///Добавление клиента
        private void AddClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Извлекаем данные из текстовых полей
                string fullName = AddClientFIO.Text;
                DateTime dateOfBirth = AddClientBirthDate.Value;
                string phoneNumber = AddClientPhone.Text;

                // Выполняем SQL-запрос для добавления нового клиента
                string sqlQuery = $"CALL insert_client('{fullName}', '{dateOfBirth:yyyy-MM-dd}', '{phoneNumber}')";

                // Выполняем запрос
                bool success = dbManager.ExecuteCommand(sqlQuery);

                // Если запрос выполнен успешно, перезагружаем данные
                if (success)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении клиента: {ex.Message}", "Ошибка");
            }
        }

        ///Удаление клиента
        private void DelClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                int clientIdToDelete;
                if (!int.TryParse(IdClientForDelTextBox.Text, out clientIdToDelete))
                {
                    MessageBox.Show("Пожалуйста, введите корректный ID клиента для удаления.", "Ошибка");
                    return;
                }

                string sqlQuery = $"CALL delete_client({clientIdToDelete})";

                // Выполняем запрос
                bool success = dbManager.ExecuteCommand(sqlQuery);

                if (success)
                { 
                    LoadData();
                    ///красота
                    IdClientForDelTextBox.Text = "Введите id";
                    IdClientForDelTextBox.ForeColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении клиента: {ex.Message}", "Ошибка");
            }
        }
        ///Добавление заказа
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                int clientId, roomId, durationHours;
                decimal hookahPrice;

                if (!int.TryParse(AddOrderClientID.Text, out clientId) || !int.TryParse(AddOrderRoomID.Text, out roomId) ||
                    !int.TryParse(AddOrderDurationTime.Text, out durationHours) || !decimal.TryParse(AddOrderHookahPrice.Text, out hookahPrice))
                {
                    MessageBox.Show("Пожалуйста, введите корректные значения для вставки заказа.", "Ошибка");
                    return;
                }

                DateTime reservationDate = DateTime.Now;

                string sqlQuery = $"CALL insert_order({clientId}, {roomId}, {durationHours}, {hookahPrice}, '{reservationDate.ToString("yyyy-MM-dd HH:mm:ss")}' )";

                bool success = dbManager.ExecuteCommand(sqlQuery);
                if (success)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вставке заказа: {ex.Message}", "Ошибка");
            }
        }
        ///Удаление заказа
        private void DelOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем ID заказа из текстового поля
                int orderIdToDelete;
                if (!int.TryParse(IdOrderForDelTextBox.Text, out orderIdToDelete))
                {
                    MessageBox.Show("Пожалуйста, введите корректный ID заказа для удаления.", "Ошибка");
                    return;
                }

                string sqlQuery = $"CALL delete_order({orderIdToDelete})";

                bool success = dbManager.ExecuteCommand(sqlQuery);

                // Если запрос выполнен успешно, перезагружаем данные
                if (success)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении заказа: {ex.Message}", "Ошибка");
            }
        }

        private void UptadeNewRoomPriceButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем значения из текстовых полей
                int roomId;
                decimal hourlyRate;

                if (!int.TryParse(UpdateRoomIDTextbox.Text, out roomId) ||  !decimal.TryParse(UpdateNewPriceTextBox.Text, out hourlyRate))
                {
                    MessageBox.Show("Пожалуйста, введите корректные значения для обновления почасовой аренды зала.", "Ошибка");
                    return;
                }

                string sqlQuery = $"CALL update_hourly_rate( {roomId}, {hourlyRate})";

                bool success = dbManager.ExecuteCommand(sqlQuery);
                if (success)
                    LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вставке заказа: {ex.Message}", "Ошибка");
            }
        }
    }
}
