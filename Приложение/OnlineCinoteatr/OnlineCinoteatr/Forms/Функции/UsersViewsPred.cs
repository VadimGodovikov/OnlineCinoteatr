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
using OnlineCinoteatr.Model;

namespace OnlineCinoteatr.Forms.Функции
{
    public partial class UsersViewsPred : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private mainForm mainForm;

        DataSet ds = null;
        SqlDataAdapter da;
        SqlCommand cmd = new SqlCommand();
        public UsersViewsPred(string connectionString, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.mainForm = mainForm;
        }

        private void UsersViewsPred_Load(object sender, EventArgs e)
        {
            predDataGrid.Visible = true;
            showUserViewsPred();
        }

        private void showUserViewsPred()
        {
            using (Context db = new Context(connectionString))
            {

                da = new SqlDataAdapter("SELECT * FROM UsersViews", connectionString);
                ds = new DataSet();
                da.Fill(ds, "dbo.UsersViews");
                predDataGrid.DataSource = ds.Tables["dbo.UsersViews"];

            }
        }

        private void predDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
