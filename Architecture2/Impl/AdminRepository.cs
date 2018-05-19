using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Architecture2;
using System.Data;
using Architecture2.Addon;
using Architecture2.Provider;

namespace Architecture2.Impl
{
	public class AdminRepository : SqlBaseRepository, ICentralRepository
	{
		readonly IConnectionStringProvider _connProvider;
		public AdminRepository(IConnectionStringProvider connProvider) {
			_connProvider = connProvider;
		}

		protected IDbConnection DbConnection {
			get {
				return OpenConnection(_connProvider.GetConnectionString());
			}
		}

		public ClientInfo GetClientById(int Id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ReportInfo> GetClientReportInfo(int clientId)
		{
			throw new NotImplementedException();
		}

		public ReportInfo GetClientReportInfo(Guid id)
		{
			throw new NotImplementedException();
		}

		public ReportInfo GetClientReportInfoByGroup(Guid groupId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ClientInfo> GetClients()
		{
			throw new NotImplementedException();
		}
	}
}
