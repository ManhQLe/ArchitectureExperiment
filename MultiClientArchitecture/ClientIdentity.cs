using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiClientArchitecture.Models;

namespace MultiClientArchitecture
{
	public class ClientIdentity : IClientIdentity
	{
		public ClientRecord OfClient { get; set; }
	}
}
