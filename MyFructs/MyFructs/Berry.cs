using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFructs
{
	internal class Berry
	{
		public Berry(string name, string where)
		{
			SetName("Это ягода");
			SetCommonName("куст");
		}

		private enum ColorBerry { Red = 1, Black = 2, Blue = 3, Creen = 4 };
	}
}