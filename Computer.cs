using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_4
{
	public interface IMyCloneable
	{
		Computer ShallowCopy();
		Computer DeepCopy();
	}

	public class Computer : IMyCloneable
	{
		public string CPU;
		public int RAM;
		public string GPU;
		public List<string> AdditionalComponents = new List<string> { };


		public void Display()
		{
			Console.WriteLine($"CPU: {CPU}");
			Console.WriteLine($"GPU: {GPU}");
			Console.WriteLine($"RAM: {RAM}");
			Console.WriteLine("AdditionalComponents:");

			if (AdditionalComponents.Count == 0)
			{
				Console.WriteLine("  (нет дополнительных компонентов)");
			}
			else
			{
				foreach (string component in AdditionalComponents)
				{
					Console.WriteLine($"  - {component}");
				}
			}
		}


		public Computer ShallowCopy()
		{
			return (Computer)MemberwiseClone();
		}
		public Computer DeepCopy() 
		{
			Computer other = (Computer)MemberwiseClone();
			other.AdditionalComponents = new List<string>(this.AdditionalComponents);
			return other;
		}
	}
}
