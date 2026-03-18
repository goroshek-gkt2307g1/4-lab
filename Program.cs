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
			Console.WriteLine("Оригинальный компьютер");
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

			Computer shallowCopy = myComputer.ShallowCopy();
			Console.WriteLine("Поверхностная копия");
			shallowCopy.CPU = "AMD Ryzen 9 (изменено)";
			shallowCopy.AdditionalComponents.Add("Новый компонент добавлен в поверхностную копию");
			Console.WriteLine("\nПосле изменений");
			Console.WriteLine("Оригинал:");
			myComputer.Display();
			Console.WriteLine("Поверхностная копия:");
			shallowCopy.Display();

			Computer deepCopy = myComputer.DeepCopy();
			Console.WriteLine("Глубокая копия");
			deepCopy.CPU = "Intel Core i9 (изменено2)";
			deepCopy.AdditionalComponents.Add("Совсем новый компонент добавлен в глубокую копию");
			Console.WriteLine("\nПосле изменений");
			Console.WriteLine("Оригинал:");
			myComputer.Display();
			Console.WriteLine("Глубокая копия:");
			deepCopy.Display();

			Console.ReadLine();


		}
	}


}
