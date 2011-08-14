using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RelationalFloridum_GUI
{
	public static class DbUtil
	{
		public static DataTable GetTables( string database, string query )
		{
			SqlDataAdapter adapter = new SqlDataAdapter( query, GetConnectionStr( database ) );
			DataTable datatables = new DataTable();
			adapter.Fill( datatables );
			return datatables;
		}

		public static string GetConnectionStr( string database )
		{
			// Data Source=inohiro-vmwin\SQLEXPRESS;Initial Catalog=FloridumDb;Integrated Security=True
			return string.Format( "Data Source={0}; Integrated Security=True; Trusted_Connection=yes; Initial Catalog={1}", "inohiro-vmwin\\SQLEXPRESS", database );
		}
	}
}
