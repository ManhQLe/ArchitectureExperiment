using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace MultiClientArchitecture.Repository
{
	public abstract class SqlDbRepository
	{
		public virtual IDbConnection OpenConnection(string connectionString) {
			var conn = new SqlConnection(connectionString);			
			conn.Open();
			return conn;
		}
			
	}
}
