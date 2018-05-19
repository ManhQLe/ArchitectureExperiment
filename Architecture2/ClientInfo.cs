using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2
{
	public class ClientInfo
	{
		int ClientId;
		public string Name { get; set; }
		public IEnumerable<ReportInfo> Reports { get; set; }
		public string ScretKey { get; set; }
	}
}
