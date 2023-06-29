using OnlineCinoteatr.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCinoteatr.Forms.Функции
{
    public partial class KolvoUserBuyPodpiska : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;

        DataSet ds = null;
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        public KolvoUserBuyPodpiska(string connectionString, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void hranimProcButton_Click(object sender, EventArgs e)
        {
            scalfuncView.Visible = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand($"SELECT dbo.KolvoUserBuyPodpiska(@idPodpiska) 'Кол-во пользователей'", connection))
                    {
                        cmd.Parameters.AddWithValue("@idPodpiska", Convert.ToInt32(idpodpiskaText.Text));

                        object result = cmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("Данная подписка не была куплена, функция вывела 0\nПроверьте правильность ввода данных и попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            da = new SqlDataAdapter($"SELECT dbo.KolvoUserBuyPodpiska('{Convert.ToInt32(idpodpiskaText.Text)}') 'Кол-во пользователей'", connectionString);
                            ds = new DataSet();
                            da.Fill(ds, "dbo.KolvoUserBuyPodpiska");
                            scalfuncView.DataSource = ds.Tables["dbo.KolvoUserBuyPodpiska"];
                        }
                    }

                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Проверьте данные и попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
