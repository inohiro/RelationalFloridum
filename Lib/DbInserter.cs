using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Microsoft.SqlServer;

namespace RelationalFloridum_Lib
{
	public class DbInserter
	{
		public void Insert( string cntStr, string insertCmd )
		{
			using ( SqlConnection connection = new SqlConnection( cntStr ) )
			{
//                string inscmd = @"
//					BULK INSERT [dbo].[Table_2] 
//					FROM 'C:\build.csv'
//					WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',',ROWTERMINATOR = '\n', CODEPAGE= 65001 )";

				SqlCommand insertCommand = new SqlCommand( insertCmd, connection );

				connection.Open();

#if DEBUG
				Console.WriteLine( "ServerVersion: {0}", connection.ServerVersion );
				Console.WriteLine( "State: {0}", connection.State );
				Console.WriteLine( "Inserting Data..." );
#endif

				SqlDataReader reader = null;
				try
				{
					reader = insertCommand.ExecuteReader();
				}
				catch ( SqlException exception )
				{
#if DEBUG
					Console.WriteLine( exception.ToString() );
#endif
				}
				finally
				{
					reader.Close();
				}
			}
#if DEBUG
			Console.WriteLine( "Insert is over..." );
#endif
		}

		//static void Main( string[] args )
		//{
//			Insert();

			//CeekTestDataContext db = new CeekTestDataContext();
			//var s = from record in db.Table_2
			//        where record.Depth == 2
			//        select record.NodeType;

			//using( System.IO.StreamWriter writer = new System.IO.StreamWriter( @"outputs.txt" ) )
			//{
			//foreach ( var record in s )
			//{
			//    Console.WriteLine( record.ToString() );
			//}

			//        writer.WriteLine( record );
			//        Console.WriteLine( record );

			//        //if( i < 10 )
			//        //{
			//        //    //byte[] sjisByte = s_jis.GetBytes( record );
			//        //    //byte[] unicodeByte = Encoding.Convert( s_jis, unicode, sjisByte );
			//        //    //char[] unicodeChar = new char[unicode.GetCharCount( unicodeByte, 0, unicodeByte.Length )];
			//        //    //unicode.GetChars( unicodeByte, 0, unicodeByte.Length, unicodeChar, 0 );
			//        //    //Console.WriteLine( new string( unicodeChar ) );

			//        //    Console.WriteLine( record );

			//        //    i++;
			//        //}
			//        //else 
			//        //{ 
			//        //    break; 
			//        //}
			//    }

			//    writer.Close();
			//}

			//Console.WriteLine( "outputs is over..." );
		//    Console.ReadKey();
		//}

		//private static string GetConnectingString()
		//{
		//    return @"Data Source=HIROYUKI-6B2E33\SQLEXPRESS;Initial Catalog=FloridumDb;Integrated Security=True";
		//}
	}
}

