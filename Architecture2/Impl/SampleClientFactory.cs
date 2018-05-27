using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Architecture2.Factory;

namespace Architecture2.Impl
{
	public class SampleClientFactory: IClientEntityFactory
	{
		ICentralRepository _centralAdminRepo;
		public SampleClientFactory(ICentralRepository repo) {
			_centralAdminRepo = repo;
		}
		
		public async Task<T> FabricateClientEntity<T>(int clientId) where T:IClientEntity
		{
			return await Task.Run<T>(() =>
			{
				var clientInfo =  _centralAdminRepo.GetClientById(clientId);
				IClientEntity e = new MySampleClientRepo();
				e.Client = clientInfo;
				return (T)e;
			});
		}
	}
}
