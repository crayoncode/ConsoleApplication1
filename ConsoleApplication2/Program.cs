using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
	public delegate string TeaDelegate(string spTest);
	class Program
	{
		static void Main(string[] args)
		{
			TestDelegate();
		}

		public static void TestDelegate()
		{
			//Operator op = new Operator();
			//TeaDelegate tea = new TeaDelegate(op.GetTea);
			//Console.WriteLine("去给我倒杯水");
			//Console.WriteLine();
			//string result = tea("去给我倒杯水");
			//Thread.Sleep(5000);
			//Console.WriteLine(result);
			//Console.WriteLine();

			//TeaDelegate delete = new TeaDelegate(Person.GetTea);
			//TeaDelegate delete = Person.GetTea;
			//Console.WriteLine("去倒杯水!");
			//Console.WriteLine();
			//string result = delete("去给我倒杯水");
			//Thread.Sleep(5000);
			//Console.WriteLine(result);
			//Console.WriteLine();

			//匿名函数
			bool flag = true;

			TeaDelegate tea = delegate (string spTest)
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
			 };

			Console.WriteLine("去给我倒杯水");
			Console.WriteLine();
			string result = tea("去给我倒杯水");
			Thread.Sleep(5000);
			Console.WriteLine(result);
			Console.WriteLine();

			Console.ReadKey();
		}
	}


	public class Operator
	{
		private bool flag = true;

		public string GetTea(string spTest)
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
