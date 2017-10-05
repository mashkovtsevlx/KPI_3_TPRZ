using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFructs
{
	internal class Fruct
	{
		//фрукт для продавца характеризується:
		//де росте
		private string where;

		//назвою
		private string name;

		//ціною
		private double cost;

		public void SetName(string name)
		{
			this.name = name;
		}

		//установка цены фрукта
		private void SetCost(double cost)
		{
			this.cost = cost;
		}

		//установка поля: где растет
		protected void SetWhere(string where)
		{
			this.where = where;
		}

		//вывод результата установок
		public string WRTLN()
		{
			return String.Format("name = {0}   where = {1}", name, where);
		}
	}
}