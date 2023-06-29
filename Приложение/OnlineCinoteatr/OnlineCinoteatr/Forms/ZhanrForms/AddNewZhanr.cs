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

namespace OnlineCinoteatr.Forms.ZhanrForms
{
    public partial class AddNewZhanr : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;
        public AddNewZhanr(string connectionString, mainForm mainForm)
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
                    Zhanr zhanr = new Zhanr()
                    {
                        ZhanrName = nameZhanr.Text
                    };

                    db.Zhanrs.Add(zhanr);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Введены некорректные данные. Попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            mainForm.showZhanr();
            this.Close();
        }
    }
}
