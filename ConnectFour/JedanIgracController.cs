using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
	public class JedanIgracController : IController
	{
		public static AIClass AI;
        
		public JedanIgracController()
		{
			AI = new AIClass();
		

		}
		public bool Klik(Button[,] matricaDugme, ref int igracnapotezu, Point relative, Tabla tabla, Label label1, Label label2)
		{
			
			bool gameOver = false;
			if (relative.X > 42 && relative.X < 530)
			{
				bool pom = true;
				for (int i = 0; i < 2; i++)
				{
					int zetonKolona;
					int odigrajpotez;
					if (pom)
					{
						zetonKolona = (relative.X - 50) / 70;
						
						pom = false;
					}
					else
					{
						AI.b = tabla;
						zetonKolona = AI.GenerisiPotez();
						//zetonKolona = 3;
						odigrajpotez = 1;

					}
					odigrajpotez = tabla.OdigrajPotez(zetonKolona, igracnapotezu);
					if (odigrajpotez != -1)
					{
						matricaDugme[odigrajpotez, zetonKolona].BackgroundImage = Image.FromFile(igracnapotezu + ".png");
                        
                        FormIgra.igra.Refresh();
                        

						igracnapotezu = (igracnapotezu % 2) + 1;
						int stanjeTable = tabla.ishod();
						if (stanjeTable == 1)
						{
							gameOver = true;
							label2.Text = (Convert.ToInt32(label2.Text) + 1).ToString();
							MessageBox.Show("Pobednik je igrac 2");
							//AIClass.Serialize(AI.transpozicija, File.Open("data.bin", FileMode.Create));
							break;
						}
						else if (stanjeTable == 2)
						{
							gameOver = true;
							label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
							MessageBox.Show("Pobednik je igrac 1");
							//AIClass.Serialize(AI.transpozicija, File.Open("data.bin", FileMode.Create));
							break;
						}
						else if (stanjeTable == 0)
						{
							gameOver = true;
							MessageBox.Show("Nereseno");
							//AIClass.Serialize(AI.transpozicija, File.Open("data.bin", FileMode.Create));
							break;
						}
						else
							gameOver = false;
						
							





					}

				}
			}
			return gameOver;

		
		}
		void Proveri(ref bool gameOver, Tabla tabla, Label label1, Label label2)
		{
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

}
