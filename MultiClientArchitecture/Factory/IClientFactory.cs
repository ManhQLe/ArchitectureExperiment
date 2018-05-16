using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Repository.Client.Interface;
using MultiClientArchitecture.BusinessService;
using Ninject;

namespace MultiClientArchitecture.Factory
{
	public interface IClientFactory: IBaseFactory
	{
		T GetClientEntity<T>(int clientId) where T : IClientIdentity;
	
	}
}
