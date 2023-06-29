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
    public partial class CheckUserPodpiska : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;

        DataSet ds = null;
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        public CheckUserPodpiska(string connectionString, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void hranimProcButton_Click(object sender, EventArgs e)
        {
            hranimProc.Visible = true;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // 2. Создание команды для выполнения хранимой процедуры
                SqlCommand command = new SqlCommand("CheckUserPodpiska", connection);
                command.CommandType = CommandType.StoredProcedure;

                // 3. Создание параметра для входного параметра хранимой процедуры
                SqlParameter param = new SqlParameter("@idPodpiska", SqlDbType.Int);
                param.Value = idpodpiskaText.Text;
                command.Parameters.Add(param);

                // 4. Создание адаптера для заполнения DataGridView данными
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // 5. Выполнение хранимой процедуры
                connection.Open();
                command.ExecuteNonQuery();

                // 6. Заполнение DataGridView данными
                hranimProc.DataSource = table;

            }
            catch
            {
                MessageBox.Show("Что-то пошло не так. Проверьте данные и попробуйте ещё раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
