using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Repository.Client.Interface;
using MultiClientArchitecture.Repository.Admin.Interface;
using Ninject;

namespace MultiClientArchitecture.Factory
{
	public class ClientRepositoryFactory : IClientRepositoryFactory
	{
		IAdminRepository _adminRepo;
		IKernel _kernel;

		public ClientRepositoryFactory(IAdminRepository adminRepo) {
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
	}
}
