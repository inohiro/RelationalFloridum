using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RelationalFloridum_GUI.Utils
{
	public static class inohiroUtil
	{
		public static string ObjArray2String( Object[] obj )
		{
			StringBuilder stbuilder = new StringBuilder();

			for ( int i = 0; i < obj.Length; i++ )
				stbuilder.Append( obj[i].ToString() );

			return stbuilder.ToString();
		}

		public static string ReadFile( string filepath )
		{
			using ( StreamReader reader = new StreamReader( filepath, Encoding.UTF8 ) )
			{
				StringBuilder strbuilder = new StringBuilder();
				while ( !reader.EndOfStream )
					strbuilder.AppendLine( reader.ReadLine() );
				return strbuilder.ToString();
			}
		}
	}
}
