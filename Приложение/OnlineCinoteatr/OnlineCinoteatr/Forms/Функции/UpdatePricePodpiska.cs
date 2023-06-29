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
using OnlineCinoteatr.Model;
using System.Data.SqlClient;

namespace OnlineCinoteatr.Forms.Функции
{
    public partial class UpdatePricePodpiska : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;

        DataSet ds = null;
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        public UpdatePricePodpiska(string connectionString, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showPodpiska()
        {
            using (Context db = new Context(connectionString))
            {
                updateDataGrid.DataSource = db.Database.SqlQuery<Podpiska>("SELECT * FROM Podpiska").ToList();

                updateDataGrid.Columns["ID_Podpiska"].Visible = false;
                updateDataGrid.Columns["NamePodpiska"].HeaderText = "Название";
                updateDataGrid.Columns["Price"].HeaderText = "Стоимость";

                updateDataGrid.Columns.Remove("UserPodpiskas");
            }
        }

        private void updatePriceButton_Click(object sender, EventArgs e)
        {

            try
            {
                string sqlQuery = $"UPDATE Podpiska SET Price = Price + {Convert.ToInt32(priceText.Text)}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Проверьте введённые данные и попробуйте снова\nДанные должны быть в целом значение (55, 250, и т.д.)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            showPodpiska();
        }

        private void UpdatePricePodpiska_Load(object sender, EventArgs e)
        {
            updateDataGrid.Visible = true;
            showPodpiska();
        }
    }
}
