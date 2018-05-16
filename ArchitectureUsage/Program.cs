using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Factory;
using MultiClientArchitecture.Repository.Admin.Interface;
using MultiClientArchitecture.BusinessService;
using Ninject;
namespace ArchitectureUsage
{
	class Program
	{
		static void Main(string[] args)
		{
			IKernel kernel = new StandardKernel();
			kernel.Bind<IClientFactory>().To<ClientFactory>();
			kernel.Bind<IAdminRepository>().To<IAdminRepository>();
			
		}
	}
}
