using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VS19_First
{

	public class MyObj
	{
		string val;

		public MyObj(string val)
		{
			this.val = val;
		}

		public override string ToString()
		{
			return this.val;
		}
	}
	static class funks
	{


		public static async IAsyncEnumerable<MyObj> Z()
		{
			for (int i = 0; i < 1000; i++)
			{

				await Task.Delay(1000);

				Console.WriteLine(i + " PROD");
				yield return new MyObj(i.ToString());
			}
		}

		internal static async Task G(IAsyncEnumerable<MyObj> hh)
		{
			List<MyObj> batch = new List<MyObj>();
			await foreach (var zz in hh)
			{
				batch.Add(zz);
				if (batch.Count > 5)
				{
					batch.ForEach(b => Console.WriteLine(b + " CONS"));
					batch.Clear();
				}
			}
			if (batch.Count > 0)
			{
				batch.ForEach(b => Console.WriteLine(b + " CONS"));
				batch.Clear();
			}
		}
	}
}
