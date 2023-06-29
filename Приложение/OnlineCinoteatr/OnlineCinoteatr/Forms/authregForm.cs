using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineCinoteatr
{
    public partial class authregForm : Form
    {
        public authregForm()
        {
            InitializeComponent();
        }

        private void authoBut_Click(object sender, EventArgs e)
        {
            var AuthorizationForm = new AuthorizationForm();
            AuthorizationForm.Show();
            this.Hide();
            return;
        }

        private void regBut_Click(object sender, EventArgs e)
        {
            var RegistrationForm = new RegistrationForm();
            RegistrationForm.Show();
            this.Hide();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void authregForm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
