using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
	public sealed class PrototypeRegistry
	{
		private static volatile PrototypeRegistry _instance;
		private static readonly object _lock = new object();
		private Dictionary<string, Computer> registry = new Dictionary<string, Computer>();

		private PrototypeRegistry() 
		{
			GamingComputerFactory gamingComputer = new GamingComputerFactory();
			Computer gamingPC = gamingComputer.Construct();

			HomeComputerFactory homeComputer = new HomeComputerFactory();
			Computer homePC = homeComputer.Construct();

			OfficeComputerFactory officeComputer = new OfficeComputerFactory();
			Computer officePC = officeComputer.Construct();

			registry.Add("gaming", gamingPC);
			registry.Add("home", homePC);
			registry.Add("office", officePC);
		}

		public static PrototypeRegistry Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lock)
					{
						if (_instance == null)
							_instance = new PrototypeRegistry();
					}
				}
				return _instance;
			}
		}

		public Computer GetPrototype(string key)
		{
			if (registry.ContainsKey(key))
			{
				Computer original = registry[key];
				Computer copy = original.DeepCopy();
				return copy;
			}
			return null;

		}

	}
}
