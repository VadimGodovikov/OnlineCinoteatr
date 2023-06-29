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

namespace OnlineCinoteatr.Forms.PodpiskaForms
{
    public partial class UpdatePodpiska : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int podId;
        private mainForm mainForm;
        public UpdatePodpiska(string connectionString, int podId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.podId = podId;
            this.mainForm = mainForm;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Podpiska pod;
            using (Context db = new Context(connectionString))
            {
                try
                {
                    pod = db.Podpiskas.Find(podId);

                    pod.NamePodpiska = nameText.Text;
                    pod.Price = Convert.ToDecimal(priceText.Text);

                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            mainForm.showPodpiska();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SetDefaultInfoAboutPodpiska()
        {
            Podpiska pod;
            using (Context db = new Context(connectionString))
            {
                pod = db.Podpiskas.Find(podId);
            }

            nameText.Text = pod.NamePodpiska.ToString();
            priceText.Text = pod.Price.ToString();

        }

        private void UpdatePodpiska_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutPodpiska();
        }
    }
}
