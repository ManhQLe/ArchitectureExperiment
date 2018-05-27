using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Architecture2.Addon;

namespace Architecture2.Impl
{
	public class MySampleClientRepo : SqlBaseRepository, 
		IClientEntity, 
		IMySampleRepo
	{
		public ClientInfo Client { get; set; }

		public IEnumerable<string> GetListOfSample()
		{
			return new List<String>() { "A", "B", "C" };
		}
	}
}
