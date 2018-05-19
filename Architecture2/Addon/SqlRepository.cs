using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Architecture2.Addon
{
	public class SqlBaseRepository
	{
		protected IDbConnection _conn;

		public IDbConnection OpenConnection(string connStr)
		{
			if (_conn==null || _conn.State != ConnectionState.Open) {
				_conn = new SqlConnection(connStr);
				_conn.Open();
			}
			return _conn;
		}
	}
}
