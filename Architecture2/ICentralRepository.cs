using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2
{
	public interface ICentralRepository
	{
		IEnumerable<ClientInfo> GetClients();

		ClientInfo GetClientById(int Id);
		

		IEnumerable<ReportInfo> GetClientReportInfo(int clientId);

		ReportInfo GetClientReportInfo(Guid id);

		ReportInfo GetClientReportInfoByGroup(Guid groupId);

		
	}
}
