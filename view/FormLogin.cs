using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacim
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSingup singup = new FormSingup();
            singup.Show();
            this.Hide();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FormDashBoard dashboard = new FormDashBoard();
            dashboard.Show();
            this.Hide();
        }

    }
}
