using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture2.Provider
{
	public interface IConnectionStringProvider
	{
		string GetConnectionString();
	}
}
