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

		public T GetClientRepository<T>(int clientId) where T: IClientRepository
		{
			if (_kernel == null)
				throw new Exception("IoC container is not configured for factory");
			var clientRecord = _adminRepo.GetClientRecordById(clientId);

			T repo = IoCContainer.Get<T>();
			repo.OfClient = clientRecord;
			return repo;
		}

		public T GetClientService<T>(int clientId) where T : IBusinessService
		{
			if (_kernel == null)
				throw new Exception("IoC container is not configured for factory");
			var clientRecord = _adminRepo.GetClientRecordById(clientId);

			T repo = IoCContainer.Get<T>();
			repo.OfClient = clientRecord;
			return repo;
		}
	}
}
