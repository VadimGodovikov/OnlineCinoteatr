using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineCinoteatr.Model;
using OnlineCinoteatr.Forms;
using System.Runtime.CompilerServices;

namespace OnlineCinoteatr
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private string connectionString;

        public static string GetRemoteConnectionString(string login, string password)
        {
            SqlConnectionStringBuilder sqlString = new SqlConnectionStringBuilder()
            {
                DataSource = $"LAPTOP-UK68BV1P",
                InitialCatalog = "OnlineCinoteatr",  //Database
                IntegratedSecurity = false,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework",
                UserID = login,
                Password = password
            };
            return sqlString.ToString();
        }

        public string ClientRole = "";
        mainForm mainForm = new mainForm();
        private void authBut_Click(object sender, EventArgs e)
        {
            connectionString = GetRemoteConnectionString(loginText.Text, passText.Text);

            using (Context db = new Context(connectionString))
            {
                try
                {
                    if (db.Database.SqlQuery<int>("SELECT is_member('ClientOC')").FirstOrDefault() == 1)
                        ClientRole = "ClientOC";
                    else if (db.Database.SqlQuery<int>("SELECT is_member('Administrator')").FirstOrDefault() == 1)
                        ClientRole = "Administrator";
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте снова!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                switch (ClientRole)
                {
                    case "ClientOC":
                        MessageBox.Show("Вы успешно авторизовались!", "Успешно", MessageBoxButtons.OK);
                        mainForm.HideButtonUser();
                        mainForm.Show();
                        this.Hide();
                        break;
                    case "Administrator":
                        MessageBox.Show("Вы успешно авторизовались!", "Успешно", MessageBoxButtons.OK);
                        mainForm.Show();
                        this.Hide();
                        break;

                }

            }
        }

        private void backBut_Click(object sender, EventArgs e)
        {
            authregForm authregForm = new authregForm();
            authregForm.Show();
            this.Hide();
            return;
        }
    }
}
