using Farmacim.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacim.utils
{
    public static class Utils
    {
        public static void showAbout()
        {
            FormAbout about = new FormAbout();
            about.Show();
        }     
        public static void wantExit(Form form)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente sair do sistema?", "Deseja sair", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                form.Close();
            }
        }

        public static void showDashBoard()
        {
            FormDashBoard form = new FormDashBoard();
            form.Show();
        }
        public static void showAddProduto()
        {
            FormAddProduto form = new FormAddProduto();
            form.Show();
        }
        public static void showSearchProduto()
        {
            FormSearchProduto form = new FormSearchProduto();
            form.Show();
        }

        public static void showOrder()
        {
            FormOrder form = new FormOrder();
            form.Show();
        }       

    }
}
