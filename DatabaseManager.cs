using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace Приложение
{
    public class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable GetData(string sqlQuery)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка");
                return null;
            }
        }

        public bool UpdateData(DataTable dataTable, string sqlQuery)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection);
                    NpgsqlCommandBuilder builder = new NpgsqlCommandBuilder(adapter);
                    adapter.Update(dataTable);

                    MessageBox.Show("Изменения сохранены успешно!", "Успех");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка");
                return false;
            }
        }

        ///для удаления, добавления, ОБНОВЛЕНИЯ
        public bool ExecuteCommand(string sqlQuery)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Команда выполнена успешно!", "Успех");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при выполнении команды: {ex.Message}", "Ошибка");
                return false;
            }
        }

        public bool CheckLogin(string login, string password, string table)
        {
            string sqlQuery = $"SELECT COUNT(*) FROM {table} WHERE login = @login AND password = @password";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0; // Если count больше 0, значит, такой пользователь существует
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при проверке логина и пароля: {ex.Message}", "Ошибка");
                return false;
            }
        }

    }
}
