using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
	[Serializable]
	public class TranspositionValue
	{
		public int depth;
		public int alphabetavalue;
		public int SledeciPotez;
		//public int alpha;
		//public int beta;
		public int granica;//jedan gornja granica 2 donja
		public TranspositionValue(int d, int ab,int sledeci,int g)
		{
			depth = d;
			alphabetavalue = ab;
			
			SledeciPotez = sledeci;
			//alpha = a;
			//beta = b;
			granica = g;
			
		}
		
	}
}
