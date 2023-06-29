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
    public partial class UpdateBuilders : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int buildId;
        private mainForm mainForm;
        public UpdateBuilders(string connectionString, int buildId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.buildId = buildId;
            this.mainForm = mainForm;
        }

        private void SetDefaultInfoAboutBuilders()
        {
            Builder builder;
            using (Context db = new Context(connectionString))
            {
                builder = db.Builders.Find(buildId);
            }

            surnameText.Text = builder.Surname.ToString();
            firstnameText.Text = builder.FirstName.ToString();
            KolvoFilmovText.Text = builder.KolichestvoFilmov.ToString();
            dateTimeBirthday.Value = builder.Birthday.Value;
            postText.Text = builder.Post.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Builder builder;
            using (Context db = new Context(connectionString))
            {
                try
                {
                    builder = db.Builders.Find(buildId);

                    builder.Surname = surnameText.Text;
                    builder.FirstName = firstnameText.Text;
                    builder.MiddleName = middleNameText.Text;
                    builder.KolichestvoFilmov = Convert.ToInt32(KolvoFilmovText.Text);
                    builder.Birthday = dateTimeBirthday.Value.Date;
                    builder.PhoneNumber = phoneText.Text;
                    builder.Post = postText.Text;

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

        private void UpdateBuilders_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutBuilders();
        }
    }
}
