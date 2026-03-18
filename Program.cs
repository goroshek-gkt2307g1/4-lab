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


			Console.WriteLine("\nПаттерн синглтон\n");

			PrototypeRegistry r1 = PrototypeRegistry.Instance;
			PrototypeRegistry r2 = PrototypeRegistry.Instance;

			Console.WriteLine($"Один объект? {ReferenceEquals(r1, r2)}\n");

			Console.WriteLine("тест прототипов\n");

			Computer game1 = r1.GetPrototype("gaming");
			Console.WriteLine("Оригинал (первая копия):");
			game1.Display();

			game1.AdditionalComponents.Add("новый компонент");
			Console.WriteLine("\nПосле изменения:");
			game1.Display();

			Computer game2 = r1.GetPrototype("gaming");
			Console.WriteLine("\nСвежая копия (без изменений):");
			game2.Display();

			Console.WriteLine("\nвсе прототипы\n");

			r1.GetPrototype("office").Display();
			r1.GetPrototype("home").Display();
			r1.GetPrototype("gaming").Display();

			Console.ReadLine();


		}
	}


}
