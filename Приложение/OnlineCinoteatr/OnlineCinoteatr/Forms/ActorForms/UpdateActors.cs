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
    public partial class UpdateActors : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int actorId;
        private mainForm mainForm;
        public UpdateActors(string connectionString, int actorId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.actorId = actorId;
            this.mainForm = mainForm;
        }

        private void SetDefaultInfoAboutActors()
        {
            Actor actor;
            using (Context db = new Context(connectionString))
            {
                actor = db.Actors.Find(actorId);
            }

            surnameText.Text = actor.Surname.ToString();
            firstnameText.Text = actor.FirstName.ToString();
            KolvoFilmovText.Text = actor.KolichestvoFilmov.ToString();
            dateTimeBirthday.Value = actor.Birthday.Value;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Actor actor;
            using (Context db = new Context(connectionString))
            {
                try
                {
                    actor = db.Actors.Find(actorId);

                    actor.Surname = surnameText.Text;
                    actor.FirstName = firstnameText.Text;
                    actor.MiddleName = middleNameText.Text;
                    actor.KolichestvoFilmov = Convert.ToInt32(KolvoFilmovText.Text);
                    actor.Birthday = dateTimeBirthday.Value.Date;

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

        private void UpdateActors_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutActors();
        }
    }
}
