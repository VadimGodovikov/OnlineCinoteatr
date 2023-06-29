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
using OnlineCinoteatr.Forms;

namespace OnlineCinoteatr.Forms.Films
{
    public partial class UpdateFilm : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int filmId;
        private mainForm mainForm;

        public UpdateFilm(string connectionString, int filmId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.filmId = filmId;
            this.mainForm = mainForm;
        }

        private void SetDefaultInfoAboutFilm()
        {
            Film film;
            using(Context db = new Context(connectionString))
            {
                film = db.Films.Find(filmId);
            }

            nameFilm.Text = film.FilmName.ToString();
            countryBuild.Text = film.Country.ToString();
            AgeResText.Text = film.AgeRestriction.ToString();
            DescText.Text = film.FilmDescription.ToString();
        }

        string repertuar = "";

        private void AddButton_Click(object sender, EventArgs e)
        {
            Film film;
            using (Context db = new Context(connectionString))
            {
                try
                {
                    film = db.Films.Find(filmId);

                    film.FilmName = nameFilm.Text;
                    film.DataVihoda = dateTimeBuild.Value.Date;
                    film.Country = countryBuild.Text;
                    film.AgeRestriction = AgeResText.Text;
                    film.FilmDescription = DescText.Text;
                    film.Repertuar = repertuar;
                   

                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            mainForm.showFilm();
            this.Close();
        }

        private void checkSer_CheckedChanged(object sender, EventArgs e)
        {
            repertuar = "сериал";
        }

        private void checkKor_CheckedChanged(object sender, EventArgs e)
        {
            repertuar = "короткометражка";
        }

        private void checkFilm_CheckedChanged(object sender, EventArgs e)
        {
            repertuar = "фильм";
        }

        private void checkMult_CheckedChanged(object sender, EventArgs e)
        {
            repertuar = "мультфильм";
        }

        private void UpdateFilm_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutFilm();
        }
    }
}
