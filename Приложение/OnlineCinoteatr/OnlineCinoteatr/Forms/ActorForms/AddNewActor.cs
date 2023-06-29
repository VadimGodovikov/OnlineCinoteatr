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

namespace OnlineCinoteatr.Forms.ActorForms
{
    public partial class AddNewActor : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;
        public AddNewActor(string connectionString, mainForm mainForm)
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
                    Actor actor = new Actor()
                    {
                        Surname = surnameText.Text,
                        FirstName = firstnameText.Text,
                        MiddleName = middleNameText.Text,
                        KolichestvoFilmov = Convert.ToInt32(KolvoFilmovText.Text),
                        Birthday = dateTimeBirthday.Value.Date,
                    };

                    db.Actors.Add(actor);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            mainForm.showActors();
            this.Close();
        }

        private void AddNewActor_Load(object sender, EventArgs e)
        {

        }
    }
}
