using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineCinoteatr.Model;

namespace OnlineCinoteatr
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void authBut_Click(object sender, EventArgs e)
        {
            var username = loginText.Text;
            var password = passText.Text;
            var confrimPas = confrimpassText.Text;

            if(confrimPas != password)
            {
                MessageBox.Show("Пароль должен совпадать. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == null || password == null) { MessageBox.Show("Данные не должны быть пустыми", "Error"); return; }
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {

                    // проверка на наличие такого пользователя

                    connection.Open();
                    var sql = $"SELECT COUNT(*) FROM sys.server_principals WHERE name = '{username}'";

                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        var count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Пользователь с таким именем уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Создание нового пользователя с роль ClientOC
                    sql = $"EXEC sp_addlogin '{username}', '{password}', 'OnlineCinoteatr'";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    sql = $"USE OnlineCinoteatr";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    sql = $"EXEC sp_adduser '{username}', '{username}'";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    sql = $"EXEC sp_addrolemember 'ClientOC', '{username}'";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Пользователь успешно зарегистрирован", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                
            }
            catch
            {
                MessageBox.Show($"Ошибка при регистрации пользователя","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var AuthorizationForm = new AuthorizationForm();
            AuthorizationForm.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            authregForm authregForm = new authregForm();
            authregForm.Show();
            this.Hide();
            return;
        }

        private void confrimpassText_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
