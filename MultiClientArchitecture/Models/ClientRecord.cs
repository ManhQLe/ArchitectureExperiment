using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiClientArchitecture.Models
{
	public class ClientRecord
	{
		public int ClientId { get; set; }
		public string ClientName { get; set; }
		public string ConnectionString { get; set; }
	}
}
