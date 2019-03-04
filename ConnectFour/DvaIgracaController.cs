using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
	public class DvaIgracaController : IController
	{
		public bool Klik(Button[,] matricaDugme, ref int igracnapotezu, System.Drawing.Point relative,Tabla tabla,Label label1, Label label2)
		{
			bool gameOver=false;
			if (relative.X > 42 && relative.X < 530)
			{
				int zetonKolona = (relative.X - 50) / 70;
				int odigrajpotez = tabla.OdigrajPotez(zetonKolona, igracnapotezu);
				if (odigrajpotez != -1)
				{
					matricaDugme[odigrajpotez, zetonKolona].BackgroundImage = Image.FromFile(igracnapotezu + ".png");

					igracnapotezu = (igracnapotezu % 2) + 1;
					int stanjeTable = tabla.ishod();
					if (stanjeTable == 1)
					{
						gameOver = true;
						label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
						MessageBox.Show("Pobednik je igrac 1");
					}
					else if (stanjeTable == 2)
					{
						gameOver = true;
						label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
						MessageBox.Show("Pobednik je igrac 2");
					}
					else if (stanjeTable == 0)
					{
						gameOver = true;
						MessageBox.Show("Nereseno");
					}
					else
						gameOver = false;
					
					



				}
			}
			return gameOver;
		}
}

}