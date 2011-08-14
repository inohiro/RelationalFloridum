using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Data;

namespace RelationalFloridum_Lib
{
	public class XmlGenerator
	{
		public XmlGenerator()
		{
		}

		public string Generate( string sqlQuery, DataRowCollection records )
		{
			Stack<string> stack = new Stack<string>();
			string tmp = "";

			StringBuilder xml = new StringBuilder();
			xml.AppendLine( "<?xml version=\"1.0\" encoding=\"utf-8\"?>" );
			xml.AppendLine( "<Result>" );

			// add Parent
			// NodeType Check
			for ( int i = 0; i < records.Count; i++ )
			{
		//        SaxModel model = new SaxModel( true );
		////		model.StartDocument();
		//        switch ( records[i][2].ToString() )
		//        {
		//            case "StartElement":
		//                model.StartElement( records[i][3].ToString(), records[i][4].ToString(), false );
		//                break;

		//            case "Text":
		//                model.GetText( records[i][3].ToString(), records[i][4].ToString() );
		//                break;

		//            case "Attribute":
		//                model.GetAttribute( records[i][3].ToString(), records[i][4].ToString() );
		//                break;
		//        }

				//// Text -> Push
				if ( records[i][2].ToString() == "Text" )
				{
					xml.Append( string.Format( ">{0}",/* records[i][3].ToString(), */ records[i][4].ToString() ) );
					while ( stack.Count != 0 )
						xml.AppendLine( string.Format( "</{0}>", stack.Pop() ) );
				}
				else if ( records[i][2].ToString() == "Attribute" )
				{
					xml.Append( string.Format( " {0} = \"{1}\">", records[i][3].ToString(), records[i][4].ToString() ) );
				}
				else if ( records[i][2].ToString() == "StartElement" )
				{
					stack.Push( string.Format( records[i][3].ToString() ) );
					xml.Append( string.Format( "<{0}", records[i][3].ToString() ) );
				}
			}

			xml.AppendLine( "</Result>" );
			return xml.ToString();

			//3, 2, StartElement, Title, null, 1.1.1, /Books/Book/Title
			//1, 2, 3,            4,     5,    6,     7

			//for ( int i = 0; i < this.Level; i++ )
			//    Console.Write( "\t" );
			//if ( !this.Value.Equals( string.Empty, StringComparison.CurrentCulture ) )
			//{
			//    Console.WriteLine( "{0}, {1}, {2}, {3}, {4}, {5}, {6}",
			//        this.SerialNumber,
			//        this.Level,
			//        this.Type,
			//        this.Name,
			//        this.Value,
			//        outputNodeNumber.ToString(),
			//        path.ToString()
			//    );
			//}
		}
	}
}
