using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacim.view
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void lbAcesse_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/search?q=Farmacim&biw=1360&bih=625&sxsrf=ALeKk03mK2yzc--1fgMC7D1Viyn_g8KDBw%3A1621043116801&ei=rCefYLepMPLC5OUPqJa60A4&oq=Farmacim&gs_lcp=Cgdnd3Mtd2l6EAMyCAgAEMcBEK8BMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgQIABAKMgoIABDHARCvARAKMgoIABDHARCvARAKMgoIABDHARCvARAKMgoIABDHARCvARAKOgcIIxCwAxAnOgcIABBHELADOggIIRAWEB0QHjoECCMQJzoICAAQsQMQgwE6CAguELEDEIMBOgIIADoFCAAQsQM6CAgAEMcBEKMCOgQIABBDOgoIABCxAxCDARBDOgsIABCxAxDHARCjAjoHCAAQsQMQQzoICAAQsQMQyQM6BQgAEJIDOgYIABAKEENQ5rw6WL7NOmD5zjpoAXACeACAAXyIAfYHkgEDNi40mAEAoAEBqgEHZ3dzLXdpesgBCcABAQ&sclient=gws-wiz&ved=0ahUKEwi3r5GZyMrwAhVyIbkGHSiLDuoQ4dUDCA4&uact=5");
        }
    }
}
