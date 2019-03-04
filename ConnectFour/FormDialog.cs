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
    public partial class FormDialog : Form
    {
        FormPocetna RoditeljForma { set; get; }

        public FormDialog(FormPocetna f)
        {
            InitializeComponent();
            RoditeljForma = f;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            FormIgra fi = new FormIgra(this);
			if (rdbDrugi.Checked)
				fi.kontroler = new DvaIgracaController();
			else
				fi.kontroler = new JedanIgracController();
                
           
            RoditeljForma.Hide();
            this.Hide();
            this.DialogResult = fi.ShowDialog();
            this.Close();
        }
    }
}
