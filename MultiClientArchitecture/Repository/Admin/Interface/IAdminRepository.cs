using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Models;

namespace MultiClientArchitecture.Repository.Admin.Interface
{
	public interface IAdminRepository
	{
		ClientRecord GetClientRecordById(int clientId);
		CustomerRecord GetCustomerRecordById(int customerId);
	}
}
