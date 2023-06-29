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
using OnlineCinoteatr.Model;

namespace OnlineCinoteatr.Forms.Films
{
    public partial class AddFilms : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;
        public AddFilms(string connectionString, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void AddFilms_Load(object sender, EventArgs e)
        {

        }

        string repertuar = "";
        private void AddButton_Click(object sender, EventArgs e)
        {
            using (Context db = new Context(connectionString))
            {
                try
                {
                    Film film = new Film()
                    {
                        FilmName = nameFilm.Text,
                        DataVihoda = dateTimeBuild.Value.Date,
                        Country = countryBuild.Text,
                        AgeRestriction = AgeResText.Text,
                        FilmDescription = DescText.Text,
                        Repertuar = repertuar
                    };

                    db.Films.Add(film);
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
    }
}
