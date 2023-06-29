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

namespace OnlineCinoteatr.Forms.BuilderForms
{
    public partial class AddNewBuilder : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;
        public AddNewBuilder(string connectionString, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            using (Context db = new Context(connectionString))
            {
                try
                {
                    Builder builder = new Builder()
                    {
                        Surname = surnameText.Text,
                        FirstName = firstnameText.Text,
                        MiddleName = middleNameText.Text,
                        KolichestvoFilmov = Convert.ToInt32(KolvoFilmovText.Text),
                        Birthday = dateTimeBirthday.Value.Date,
                        PhoneNumber = phoneText.Text,
                        Post = postText.Text
                    };

                    db.Builders.Add(builder);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            mainForm.showBuilders();
            this.Close();

        }
    }
}
