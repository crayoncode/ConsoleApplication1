using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	public  class Person
	{
		private static bool flag = false;
		public static string GetTea(string spTest)
		{
			if (spTest == "去给我倒杯水")
			{
				if (flag)
				{
					return "老公,茶来了";
				}
				else
				{
					return "老公,没有水了";
				}
			}
			return "等待.......";
		}
	}
}
