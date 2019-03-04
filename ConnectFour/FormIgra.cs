using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
    public partial class FormIgra : Form
    {
        FormDialog RoditeljForma { set; get; }
		private Button[,] matricaDugme;
		private Tabla tabla;
		private int igracnapotezu;
		private bool gameOver = false;
		public IController kontroler { get; set; }
        public static FormIgra igra;


		public FormIgra(FormDialog d)
        {
            InitializeComponent();
            RoditeljForma = d;
            d.Close();
			NovaIgra();
            igra = this; 
			
        }

		private void FormIgra_Load(object sender, EventArgs e)
		{

		}

		private void FormIgra_Click(object sender, EventArgs e)
		{
			if (!gameOver)
			
			{
				Point relative = this.PointToClient(new Point(MousePosition.X, MousePosition.Y));
				gameOver = kontroler.Klik(matricaDugme, ref igracnapotezu, relative,tabla, label1, label2);
              

				
					

				
			}
			this.Focus();
		}

		private void btnIgrajOpet_Click(object sender, EventArgs e)
		{
			NovaIgra();
		}
		private void NovaIgra()
		{
			if (matricaDugme != null)
				foreach (Button dugme in matricaDugme)
					this.Controls.Remove(dugme);
			matricaDugme = new Button[6, 7];
			igracnapotezu = 2;
			tabla = new Tabla();
			gameOver = false;
			for (int i = 0; i < 6; i++)
				for (int j = 0; j < 7; j++)
				{
					Button button1 = new Button();
					button1.ForeColor = Color.Transparent;
					button1.BackColor = Color.Transparent;
					button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
					button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
					button1.FlatStyle = FlatStyle.Flat;
					button1.FlatAppearance.BorderSize = 0;
					button1.Height = 60;
					button1.Width = 60;
					button1.Location = new Point(j * 69 + 49, i * 70 + 47);
					//button1.BackgroundImage = Image.FromFile("belizeton.png");
					button1.BackgroundImageLayout = ImageLayout.Stretch;
					button1.Click += FormIgra_Click;
					matricaDugme[i, j] = button1;
					this.Controls.Add(button1);
				}
		}

		private void btnGlavniMeni_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void FormIgra_FormClosed(object sender, FormClosedEventArgs e)
        {
            AIClass.Serialize(JedanIgracController.AI.transpozicija, File.Open("data.bin", FileMode.Create));
        }
	}
}
