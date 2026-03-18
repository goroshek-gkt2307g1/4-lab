using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
	public class GamingComputerFactory : IComputerFactory
	{
		public Computer Construct()
		{
			return new ComputerBuilder()
				.WithCPU("CPU_Gaming")
				.WithGPU("GPU_Gaming")
				.WithRAM(32)
				.WithComponent("Component 1")

				.Build();

		}
	}
}
