using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Repository.Client.Interface;
using MultiClientArchitecture.Repository.Admin.Interface;

namespace MultiClientArchitecture.Factory
{
	public class ClientRepositoryFactory : IClientRepositoryFactory
	{
		IAdminRepository _adminRepo;
		public ClientRepositoryFactory(IAdminRepository adminRepo) {
			_adminRepo = adminRepo;
		}

		public T GetClientRepository<T>(int ClientId)
		{
			var clientRecord = _adminRepo.GetClientRecordById(ClientId);
			
			
		}
	}
}
