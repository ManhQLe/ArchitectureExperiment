using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace MultiClientArchitecture.Factory
{
	public interface IBaseFactory
	{
		IKernel IoCContainer { get; set; }
	}
}
