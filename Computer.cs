using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
	public interface ICloneable
	{
		void ShallowCopy();
		void DeepCopy();
	}

	public class Computer : ICloneable
	{
		public string CPU;
		public int RAM;
		public string GPU;
		public List<string> AdditionalComponents = new List<string> { };


		public void Display()
		{
			Console.WriteLine($"CPU: { CPU} \nGPU: { GPU} \nRAM: {RAM} \nAdditionalComponents: {AdditionalComponents}" );
		}

		public void ShallowCopy()
		{

		}
		public void DeepCopy() 
		{

		}
	}
}
