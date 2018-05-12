using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MultiClientArchitecture.Models;
using MultiClientArchitecture.Repository.Admin.Interface;


namespace MultiClientArchitecture.Repository.Admin
{
	public class SqlAdminRepository : SqlDbRepository, IAdminRepository
	{
		protected virtual string GetConfigConnectionString() {
			return ConfigurationManager.ConnectionStrings["ADMIN_CONN"].ConnectionString;
		}

		public ClientRecord GetClientRecordById(int clientId)
		{
			using (var Conn = OpenConnection(GetConfigConnectionString())) {				
			}
			return new ClientRecord();
		}

		public IEnumerable<ClientRecord> GetClientRecords() {
			using (var Conn = OpenConnection(GetConfigConnectionString()))
			{
			}

			return new List<ClientRecord>();
		}

		public CustomerRecord GetCustomerRecordById(int customerId)
		{
			throw new NotImplementedException();
		}
	}
}
