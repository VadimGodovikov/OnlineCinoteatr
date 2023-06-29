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
    public partial class AddNewPodpiska : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;
        public AddNewPodpiska(string connectionString, mainForm mainForm)
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
                    Podpiska pod = new Podpiska()
                    {
                        NamePodpiska = nameText.Text,
                        Price = Convert.ToDecimal(priceText.Text)                        
                    };

                    db.Podpiskas.Add(pod);
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
    }
}
