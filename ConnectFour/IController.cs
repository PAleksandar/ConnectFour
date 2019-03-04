using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
{
	public interface IController
	{
		bool Klik(Button [,]matricaDugme,ref int igracnapotezu, System.Drawing.Point relative, Tabla tabla, Label label1, Label label2);

	}
}
