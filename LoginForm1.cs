using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;



namespace Приложение
{
    public partial class LoginForm1 : Form
    {
        private readonly DatabaseManager dbManager;
        public LoginForm1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager("Host=localhost;Username=postgres;Password=qwerty;Database=hookah");
        }

        private void CloseButtom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButtom_MouseEnter(object sender, EventArgs e)
        {
            CloseButtom.ForeColor = Color.Red;
        }

        private void CloseButtom_MouseLeave(object sender, EventArgs e)
        {
            CloseButtom.ForeColor = Color.White;
        }

        private void AvtorisationButton_Click(object sender, EventArgs e)
        {
            string enteredLogin = LoginField.Text;
            string enteredPassword = PasswordField.Text;

            if (CheckLogin(enteredLogin, enteredPassword, "administrators"))
            {
                AdministratorForm adminForm = new AdministratorForm();
                adminForm.ShowDialog();
                this.Hide();
                this.Show();
            }
            else if (CheckLogin(enteredLogin, enteredPassword, "owners"))
            {
                OwnerForm ownerForm = new OwnerForm();
                ownerForm.ShowDialog();
                this.Hide();
                this.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа");
            }
        }
        private bool CheckLogin(string login, string password, string table)
        {
            return dbManager.CheckLogin(login, password, table);
        }
    }
}
