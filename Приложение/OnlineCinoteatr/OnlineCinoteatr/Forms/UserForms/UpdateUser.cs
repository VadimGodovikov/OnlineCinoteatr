using OnlineCinoteatr.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCinoteatr.Forms.UserForms
{
    public partial class UpdateUser : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int userId;
        private mainForm mainForm;
        public UpdateUser(string connectionString, int userId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.userId = userId;
            this.mainForm = mainForm;
        }

        private void SetDefaultInfoAboutUsers()
        {
            User user;
            using (Context db = new Context(connectionString))
            {
                user = db.Users.Find(userId);
            }

            surnameText.Text = user.Surname.ToString();
            firstnameText.Text = user.FirstName.ToString();
            loginText.Text = user.UserLogin.ToString();
            passwordText.Text = user.UserPassword.ToString();
            dateTimeBirthday.Value = user.Birthday.Value;
            emailText.Text = user.Email.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User user;
            using (Context db = new Context(connectionString))
            {
                try
                {
                    user = db.Users.Find(userId);

                    user.Surname = surnameText.Text;
                    user.FirstName = firstnameText.Text;
                    user.MiddleName = middleNameText.Text;
                    user.UserLogin = loginText.Text;
                    user.UserPassword = passwordText.Text;
                    user.Birthday = dateTimeBirthday.Value.Date;
                    user.Email = emailText.Text;

                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            mainForm.showUsers();
            this.Close();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutUsers();
        }
    }
}
