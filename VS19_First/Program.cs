using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace VS19_First
{
	class Program
	{

		static Channel<string> YY = Channel.CreateUnbounded<string>();

		static async Task Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			await funks.G(funks.Z());


			//var consumeTask = Task.Run(async () =>
			//{
			//	await  UU();
			//});

			//await Task.Delay(2000);

			//var produceTask = OO();

			//await Task.WhenAll(produceTask);

			//YY.Writer.Complete();

			//await YY.Reader.Completion;

			Console.WriteLine("Poop");

			////await Task.WhenAll(w, o);

			Console.ReadLine();
		}

		//public static async Task OO()
		//{
		//	await foreach (var p in funks.Z())
		//	{
		//		Console.WriteLine(p);
		//		await YY.Writer.WriteAsync(p);
		//	}
		//}

		//public static async Task UU()
		//{
		//	var hh = YY.Reader.ReadAllAsync();
		//	funks.G(hh);
		//	//while (await YY.Reader.WaitToReadAsync())
		//	//{
		//	//	Console.WriteLine("UUS");
		//	//	await Task.Delay(3000);
		//	//	var hh = YY.Reader.ReadAllAsync();

		//	//	funks.G(hh);

		//	//	Console.WriteLine("UUE");
		//	//}
		//}
	}
}
