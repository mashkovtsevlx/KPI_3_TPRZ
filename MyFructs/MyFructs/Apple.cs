using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFructs
{
	internal class Apple : Fruct
	{
		public Apple(string nameApp, /* double cost, */ string whereApp)
		{
			SetName(nameApp);
			// при вызове этого метода будет ошибка, т.к. он недоступен SetCost(5.00);
			SetCommonName(whereApp);
		}

		//характеризується сортом
		private string Sort;
	}
}