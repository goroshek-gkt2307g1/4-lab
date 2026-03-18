using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
	public class OfficeComputerFactory : IComputerFactory
	{
		public Computer Construct()
		{
			return new ComputerBuilder()
				.WithCPU("CPU_Office")
				.WithGPU("GPU_Office")
				.WithRAM(8)
				.WithComponent("Component 1")

				.Build();

		}
	}
}
