using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            FormDialog fd = new FormDialog(this);
            if (fd.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }
    }
}
