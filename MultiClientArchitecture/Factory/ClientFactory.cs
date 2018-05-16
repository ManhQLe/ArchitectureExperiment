using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Repository.Client.Interface;
using MultiClientArchitecture.Repository.Admin.Interface;
using Ninject;
using MultiClientArchitecture.BusinessService;

namespace MultiClientArchitecture.Factory
{
	public class ClientFactory : IClientFactory
	{
		IAdminRepository _adminRepo;
		IKernel _kernel;

		public ClientFactory(IAdminRepository adminRepo) {
			_adminRepo = adminRepo;
		}

		public IKernel IoCContainer { get => _kernel; set => _kernel = value; }

		public T GetClientEntity<T>(int clientId) where T: IClientIdentity
		{
			if (_kernel == null)
				throw new Exception("IoC container is not configured for factorization");
			var clientRecord = _adminRepo.GetClientRecordById(clientId);

			T clientEntity = IoCContainer.Get<T>();
			clientEntity.OfClient = clientRecord;
			return clientEntity;
		}

		
	}
}
