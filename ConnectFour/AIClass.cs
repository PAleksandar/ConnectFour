using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
	public class AIClass
	{
		private int maxDubina = 7;

		public Dictionary<string, TranspositionValue> transpozicija;
		public Tabla b { get; set; }

		private int PozicijaSledecegPoteza = -1;
		//public AIClass(Tabla prosledjena)
		//{
		//	b= prosledjena;

		//}
		public AIClass()
		{
			transpozicija = Deserialize<Dictionary<string, TranspositionValue>>(File.Open("data.bin", FileMode.Open));
			//transpozicija = new Dictionary<string, TranspositionValue>();
		}
        public int evaluacija(Tabla b)
        {

           


            //////////


            int aiScore = 1;
            int score = 0;
            int praznine = 0;
            int k = 0, josPoteza = 0;
            for (int i = 5; i >= 0; --i)
            {
                for (int j = 0; j <= 6; ++j)
                {

                    if (b.board[i,j] == 0 || b.board[i,j] == 2) continue;

                    if (j <= 3)
                    {
                        for (k = 1; k < 4; ++k)
                        {
                            if (b.board[i,j + k] == 1)
								aiScore++;
                            else if (b.board[i,j + k] == 2)
								{ aiScore = 0; praznine = 0; break; }
                            else
								praznine++;
                        }

                        josPoteza = 0;
                        if (praznine > 0)
                            for (int c = 1; c < 4; ++c)
                            {
                                int column = j + c;
                                for (int m = i; m <= 5; m++)
                                {
                                    if (b.board[m,column] == 0) josPoteza++;
                                    else break;
                                }
                            }

                        if (josPoteza != 0) score += izracunajScore(aiScore, josPoteza);
                        aiScore = 1;
                        praznine = 0;
                    }

                    if (i >= 3)
                    {
                        for (k = 1; k < 4; ++k)
                        {
                            if (b.board[i - k,j] == 1) aiScore++;
                            else if (b.board[i - k,j] == 2)
							{ aiScore = 0; break; }
                        }
                        josPoteza = 0;

                        if (aiScore > 0)
                        {
                            int column = j;
                            for (int m = i - k + 1; m <= i - 1; m++)
                            {
                                if (b.board[m,column] == 0)
									josPoteza++;
                                else
									break;
                            }
                        }
                        if (josPoteza != 0)
							score += izracunajScore(aiScore, josPoteza);
                        aiScore = 1;
                        praznine = 0;
                    }

                    if (j >= 3)
                    {
                        for (k = 1; k < 4; ++k)
                        {
                            if (b.board[i,j - k] == 1)
								aiScore++;
                            else if (b.board[i,j - k] == 2)
							{ aiScore = 0; praznine = 0; break; }
                            else praznine++;
                        }
                        josPoteza = 0;
                        if (praznine > 0)
                            for (int c = 1; c < 4; ++c)
                            {
                                int column = j - c;
                                for (int m = i; m <= 5; m++)
                                {
                                    if (b.board[m,column] == 0)
										josPoteza++;
                                    else break;
                                }
                            }

                        if (josPoteza != 0)
							score += izracunajScore(aiScore, josPoteza);
                        aiScore = 1;
                        praznine = 0;
                    }

                    if (j <= 3 && i >= 3)
                    {
                        for (k = 1; k < 4; ++k)
                        {
                            if (b.board[i - k,j + k] == 1)
								aiScore++;
                            else if (b.board[i - k,j + k] == 2)
							{ aiScore = 0; praznine = 0; break; }
                            else
								praznine++;
                        }
                        josPoteza = 0;
                        if (praznine > 0)
                        {
                            for (int c = 1; c < 4; ++c)
                            {
                                int column = j + c, row = i - c;
                                for (int m = row; m <= 5; ++m)
                                {
                                    if (b.board[m,column] == 0)
										josPoteza++;
                                    else if (b.board[m,column] == 1) ;
                                    else break;
                                }
                            }
                            if (josPoteza != 0) score += izracunajScore(aiScore, josPoteza);
                            aiScore = 1;
                            praznine = 0;
                        }
                    }

                    if (i >= 3 && j >= 3)
                    {
                        for (k = 1; k < 4; ++k)
                        {
                            if (b.board[i - k,j - k] == 1) aiScore++;
                            else if (b.board[i - k,j - k] == 2) { aiScore = 0; praznine = 0; break; }
                            else praznine++;
                        }
                        josPoteza = 0;
                        if (praznine > 0)
                        {
                            for (int c = 1; c < 4; ++c)
                            {
                                int column = j - c, row = i - c;
                                for (int m = row; m <= 5; ++m)
                                {
                                    if (b.board[m,column] == 0) josPoteza++;
                                    else if (b.board[m,column] == 1) ;
                                    else break;
                                }
                            }
                            if (josPoteza != 0) score += izracunajScore(aiScore, josPoteza);
                            aiScore = 1;
                            praznine = 0;
                        }
                    }
                }
            }
            return score;
        }

		



		int izracunajScore(int aiScore, int josPoteza)
		{
			int moveScore = 4 - josPoteza;
			if (aiScore == 0) return 0;
			else if (aiScore == 1) return 1 * moveScore;
			else if (aiScore == 2) return 10 * moveScore;
			else if (aiScore == 3) return 100 * moveScore;
			else return 1000;
		}


		public int GenerisiPotez()
		{
			PozicijaSledecegPoteza = -1;
			alphabeta(0, 1, int.MinValue, int.MaxValue);
			//System.Windows.Forms.MessageBox.Show("Pozicija " + PozicijaSledecegPoteza);
			////////////////////dodato
			if(PozicijaSledecegPoteza==-1)
			{
				int i = 0;

				while (!b.IspravanPotez(i))
					i++;
                PozicijaSledecegPoteza = i;
			}
			//using (StreamWriter file = new StreamWriter("myfile.txt"))
			//	foreach (var entry in transpozicija)
			//	{
					
			//		TranspositionValue tv = entry.Value as TranspositionValue;
			//		for (int i = 0; i < 6; i++)
			//			for (int j = 0; j < 7; j++)
			//				file.Write(tv.board[i, j]);
			//		file.WriteLine();
			//		file.WriteLine("AlphaBeta " + tv.alphabetavalue + "Dubina "+tv.depth + "Key "+entry.Key);
			//	}

			return PozicijaSledecegPoteza;
		}


		public int alphabeta(int depth, int turn, int alpha, int beta)
		{
			


			int gameResult = b.ishod();


            if (gameResult == 1)
            {
                if (depth != 1) return int.MaxValue / 2;
                else return int.MaxValue;
            }
            else if (gameResult == 2)
            {

                if (depth != 2)
                {
                    return int.MinValue / 2;
                }
                else
                {
                   // MessageBox.Show("Sledeci potez gubi");
                    return int.MinValue;

                }
            }
            else if (gameResult == 0) return 0;

            //if (gameResult == 1) return int.MaxValue / 2;
            //else if (gameResult == 2) return int.MinValue / 2;
            //else if (gameResult == 0) return 0;

            
			if (depth == maxDubina)
				return evaluacija(b);
			TranspositionValue tv = null;
			if (transpozicija.TryGetValue(b.Key(), out tv))
				if (depth >= tv.depth)
				{

					//using (StreamWriter tw = File.AppendText("nob.txt"))
					//{
					//	tw.WriteLine("Tablica hit " + tv.depth + " " + tv.alphabetavalue + " " + tv.SledeciPotez);


					//}

					if (depth == 0)
					{
						PozicijaSledecegPoteza = tv.SledeciPotez;
						return tv.alphabetavalue;
					}
					if (tv.granica == 2 && alpha < tv.alphabetavalue)
						alpha = tv.alphabetavalue;
					else if (tv.granica == 1 && beta > tv.alphabetavalue)
						beta = tv.alphabetavalue;
					else
						if (tv.granica == 0)
						return tv.alphabetavalue;
					if (alpha >= beta)
						return tv.alphabetavalue;
				}


			if (turn==1)
			{
				int v = int.MinValue;
				int i;
				for(i=0;i<7;i++)
				{
					if (!b.IspravanPotez(i)) continue;
					b.OdigrajPotez(i, 1);
					int score = alphabeta(depth + 1, 2, alpha, beta); 
					if (depth==0)
					{
						//using (StreamWriter tw = File.AppendText("nob.txt"))
						//{
						//	tw.WriteLine("Dubina: "+ depth + " "+ score+ " then");
							
						//}
					}
					if (score>v)
					{
						if(depth==0)
							PozicijaSledecegPoteza = i;
						v = score;
					}
					alpha = Math.Max(alpha, v);
					b.VratiPotez(i);
					if (beta <= alpha)
						break;
				}
				TranspositionValue tvpom = null;
				if (!transpozicija.TryGetValue(b.Key(), out tvpom))
				{
						if(depth==0)
						transpozicija.Add(b.Key(), new TranspositionValue(depth, v, PozicijaSledecegPoteza,alpha==v?(i==7?0:-1):1));
						else
						transpozicija.Add(b.Key(), new TranspositionValue(depth, v, -1, alpha == v ? (i == 7 ? 0 : -1 ): 1));
				}


				else
				{
				
				    tvpom.depth = depth;
					tvpom.alphabetavalue = v;
					
					tvpom.granica = alpha == v ? i == 7 ? 0 : -1 : 1;
					if (depth == 0)
					{
						tvpom.SledeciPotez = PozicijaSledecegPoteza;
						

					}

				}


				return v;

			}
			else
			{
				int v = int.MaxValue;
				int i;
				for(i=0;i<7;i++)
				{
					if (!b.IspravanPotez(i)) continue;
					b.OdigrajPotez(i, 2);
					int score = alphabeta(depth + 1, 1, alpha, beta);
					if (depth==0)
					{
						//using (StreamWriter tw = File.AppendText("nob.txt"))
						//{
						//	tw.WriteLine("Dubina: " + depth + " " +score +"else");

						//}
					}
					v = Math.Min(v, score);
					beta = Math.Min(beta, v);
					b.VratiPotez(i);
					if (beta <= alpha)
						break;
				}

				TranspositionValue tvpom = null;
				if (!transpozicija.TryGetValue(b.Key(), out tvpom))
				{
					transpozicija.Add(b.Key(), new TranspositionValue(depth, v, -1,beta == v ? i == 7 ? 0 : -1 : 2));
				}
				else
				{

					tvpom.depth = depth;
					tvpom.alphabetavalue = v;
					
					tvpom.granica = beta== v ? i == 7 ? 0 : -1 : 2;

				}
				return v;

			}
				

			
			
		}




		public static void Serialize<Object>(Object dictionary, Stream stream)
		{
			try 
			{
				using (stream)
				{
					
					BinaryFormatter bin = new BinaryFormatter();
					
					bin.Serialize(stream, dictionary);
				}
			}
			catch (IOException)
			{
			}
		}

		public static Object Deserialize<Object>(Stream stream) where Object : new()
		{
			Object ret = CreateInstance<Object>();
			try
			{
				using (stream)
				{
					
					BinaryFormatter bin = new BinaryFormatter();
					
					ret = (Object)bin.Deserialize(stream);
				}
			}
			catch (IOException)
			{
			}
			return ret;
		}
		
		public static Object CreateInstance<Object>() where Object : new()
		{
			return (Object)Activator.CreateInstance(typeof(Object));
		}




	}
	
	
}
