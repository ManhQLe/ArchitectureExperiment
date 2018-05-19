using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.Factory
{
	public interface IClientEntityFactory
	{
		Task<T> FabricateClientEntity<T>(int clientId) where T : IClientEntity;
	}
}
