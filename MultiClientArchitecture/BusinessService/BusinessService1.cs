using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MultiClientArchitecture.Repository.Client.Interface;

namespace MultiClientArchitecture.BusinessService
{
	public class BusinessService1:ClientIdentity, IBusinessService1
	{
		public BusinessService1(IClientRepository1 repo1) {

		}
	}
}
