using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
	public class HomeComputerFactory : IComputerFactory
	{
		public Computer Construct()
		{
			return new ComputerBuilder()
				.WithCPU("CPU_Home")
				.WithGPU("GPU_Home")
				.WithRAM(16)
				.WithComponent("Component 1")

				.Build();

		}
	}
}
