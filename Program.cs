using System;
using System.Collections.Generic;

namespace лаба_4
{

	public interface IComputerFactory
	{
		Computer Construct();
	}

	class Program
	{
		static void Main(string[] args)
		{
			ComputerBuilder builder = new ComputerBuilder();

			Computer myComputer = builder
				.WithCPU("Intel Core i5")
				.WithGPU("NVIDIA GTX 1660")
				.WithRAM(16)
				.WithComponent("Wi-Fi модуль")
				.WithComponent("Дополнительный вентилятор")
				.Build();
			Console.WriteLine("Компьютер создан");
			myComputer.Display();
			Console.ReadLine();

		}
	}


}
