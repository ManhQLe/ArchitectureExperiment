using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Repository.Client.Interface;


namespace MultiClientArchitecture.Factory
{
	public interface IClientRepositoryFactory
	{
		T GetClientRepository<T>(int ClientId);

	}
}
