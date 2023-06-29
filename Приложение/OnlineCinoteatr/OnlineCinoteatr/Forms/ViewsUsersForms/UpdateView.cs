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

namespace OnlineCinoteatr.Forms.ViewsUsersForms
{
    public partial class UpdateView : Form
    {
        private string connectionString = "Data Source=LAPTOP-UK68BV1P;Initial Catalog=OnlineCinoteatr;Integrated Security=True";
        private int viewId;
        private mainForm mainForm;
        public UpdateView(string connectionString, int viewId, mainForm mainForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.viewId = viewId;
            this.mainForm = mainForm;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void SetDefaultInfoAboutViews()
        {
            ViewsFilmsUser view;
            using (Context db = new Context(connectionString))
            {
                view = db.ViewsFilmsUsers.Find(viewId);
            }

            idfilmaText.Text = view.ID_Filma.ToString();
            iduseraText.Text = view.ID_Usera.ToString();
            dateTimeView.Value = view.DataProsmotra;
        }

        private void UpdateView_Load(object sender, EventArgs e)
        {
            SetDefaultInfoAboutViews();
        }
    }
}
