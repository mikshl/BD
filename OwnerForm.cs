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
    public partial class OwnerForm : Form
    {
        private readonly DatabaseManager dbManager;
        private DataTable dataTable;
        public OwnerForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager("Host=localhost;Username=postgres;Password=qwerty;Database=hookah");
            dataGridViewEmployees.ReadOnly = true;
            LoadData();
        }

        private void LoadData()
        {
            // Замените на ваш запрос или представление
            string sqlQuery = "SELECT * FROM administrators";
            dataTable = dbManager.GetData(sqlQuery);

            if (dataTable != null)
            {
                dataGridViewEmployees.DataSource = dataTable;
                dataGridViewEmployees.ReadOnly = false;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM administrators";
            bool success = dbManager.UpdateData(dataTable, sqlQuery);
            if (success)
                LoadData();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployees.SelectedRows.Count > 0)
            {
                int administratorId = Convert.ToInt32(dataGridViewEmployees.SelectedRows[0].Cells["admin_id"].Value);

                string deleteEmployeeProcedure = $"CALL delete_administrator({administratorId})";
                dbManager.ExecuteCommand(deleteEmployeeProcedure);

                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.", "Предупреждение");
            }
        }

        private void btnSwitchFormAd_Click(object sender, EventArgs e)
        {
            AdministratorForm adminForm = new AdministratorForm();
            this.Hide();
            adminForm.ShowDialog();
            this.Show();
        }
    }
}
