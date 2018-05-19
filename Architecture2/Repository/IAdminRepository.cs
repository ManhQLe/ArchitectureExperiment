using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.Repository
{
	public interface IAdminRepository
	{
		ClientIdentifier GetClientIdentifierByUserId(int UserId);
	}
}
