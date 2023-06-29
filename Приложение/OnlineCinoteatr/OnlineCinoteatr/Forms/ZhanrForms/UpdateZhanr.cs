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
    public partial class UpdateZhanr : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int zhanrId;
        private mainForm mainForm;
        public UpdateZhanr(string connectionString, int zhanrId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.zhanrId = zhanrId;
            this.mainForm = mainForm;
        }

        private void SetDefaultInfoAboutZhanr()
        {
            Zhanr zhanr;
            using (Context db = new Context(connectionString))
            {
                zhanr = db.Zhanrs.Find(zhanrId);
            }

            nameZhanr.Text = zhanr.ZhanrName.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Zhanr zhanr;
            using (Context db = new Context(connectionString))
            {
                try
                {
                    zhanr = db.Zhanrs.Find(zhanrId);

                    zhanr.ZhanrName = nameZhanr.Text;

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

        private void UpdateZhanr_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutZhanr();
        }
    }
}
