using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using Architecture2.Provider;

namespace Web2.Plugins
{
	public class WebConfigProvider : IConnectionStringProvider
	{
		public string GetConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["CENTRALDB"].ConnectionString;			
		}
	}
}