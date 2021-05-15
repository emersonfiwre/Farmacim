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
    public partial class FormSingup : Form
    {
        public FormSingup()
        {
            InitializeComponent();
        }

        private void FormSingup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
