using Farmacim.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacim.view
{
    public partial class FormSearchProduto : Form
    {
        public FormSearchProduto()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Utils.showAbout();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            Utils.showDashBoard();
            this.Close();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            Utils.showAddProduto();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Utils.showOrder();
            this.Close();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Utils.wantExit(this);
        }
    }
}
