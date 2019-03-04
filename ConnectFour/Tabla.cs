using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
	public class Tabla
	{
		
		public byte[,] board { get; set; }
		public Tabla()
		{
			board = new byte[,]{
			{0,0,0,0,0,0,0,},
			{0,0,0,0,0,0,0,},
			{0,0,0,0,0,0,0,},
			{0,0,0,0,0,0,0,},
			{0,0,0,0,0,0,0,},
			{0,0,0,0,0,0,0,},
		};
		}
		public bool MozeDaSeOdigra(int kolona)
		{
			return board[0, kolona] == 0;
		}
		public int OdigrajPotez(int kolona, int igrac)
		{
			for (int i = 5; i >= 0; --i)
			{
				if(kolona<0 || kolona>6)
				MessageBox.Show(kolona.ToString()); 
				if (board[i, kolona] == 0)
				{
					board[i, kolona] = (byte)igrac;
					return i;
				}
			}
			return -1;
		}
		public int ishod()
		{
			int ai = 0, human = 0;
			for (int i = 5; i >= 0; --i)
			{
				for (int j = 0; j <= 6; ++j)
				{
					if (board[i, j] == 0) continue;

					
					if (j <= 3)
					{
						for (int k = 0; k < 4; ++k)
						{
							if (board[i, j + k] == 1) ai++;
							else if (board[i, j + k] == 2) human++;
							else break;
						}
						if (ai == 4) return 1; else if (human == 4) return 2;
						ai = 0; human = 0;
					}

					
					if (i >= 3)
					{
						for (int k = 0; k < 4; ++k)
						{
							if (board[i - k, j] == 1) ai++;
							else if (board[i - k, j] == 2) human++;
							else break;
						}
						if (ai == 4) return 1; else if (human == 4) return 2;
						ai = 0; human = 0;
					}

					
					if (j <= 3 && i >= 3)
					{
						for (int k = 0; k < 4; ++k)
						{
							if (board[i - k, j + k] == 1) ai++;
							else if (board[i - k, j + k] == 2) human++;
							else break;
						}
						if (ai == 4) return 1; else if (human == 4) return 2;
						ai = 0; human = 0;
					}

					
					if (j >= 3 && i >= 3)
					{
						for (int k = 0; k < 4; ++k)
						{
							if (board[i - k, j - k] == 1) ai++;
							else if (board[i - k, j - k] == 2) human++;
							else break;
						}
						if (ai == 4) return 1; else if (human == 4) return 2;
						ai = 0; human = 0;
					}
				}
			}

			for (int j = 0; j < 7; ++j)
			{
				
				if (board[0, j] == 0) return -1;
			}
			
			return 0;
		}
		public bool IspravanPotez(int kolona)
		{
			return board[0,kolona] == 0;
		}
		public void VratiPotez(int kolona)
		{
			for (int i = 0; i <= 5; ++i)
			{
				if (board[i, kolona] != 0)
				{
					board[i, kolona] = 0;
					break;
				}
			}
		}
		public string Key()
		{
			string kljuc = "";
			for (int i = 0; i <= 5; i++)
				for (int j = 0; j <= 6; j++)
				{
					string tmp = (board[i, j]).ToString().PadLeft(2, '0');
					kljuc += tmp;
				}
			return kljuc;
		}
	}
}
