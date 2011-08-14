using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace RelationalFloridum_Lib
{
	public class SaxParser
	{
		public void Parse( string input_filepath, string output_filepath )
		{
			string INPUT_FILEPATH = input_filepath;
			string OUTPUT_FILEPATH = output_filepath;

			XmlReaderSettings setting = new XmlReaderSettings();
			setting.IgnoreComments = true;					// コメントの無視
			setting.IgnoreProcessingInstructions = true;			// 処理命令の無視
			setting.IgnoreWhitespace = true;				// 空白の無視

			XmlReader reader = XmlReader.Create( INPUT_FILEPATH, setting );

			SaxModel sax = new SaxModel( OUTPUT_FILEPATH );

			while( reader.Read() )
			{
				switch( reader.NodeType )
				{
					case XmlNodeType.Element:
						sax.StartElement( reader.Name, reader.Value, reader.IsEmptyElement );
						if( reader.MoveToFirstAttribute() )
						{
							do { sax.GetAttribute( reader.Name, reader.Value ); }
							while( reader.MoveToNextAttribute() );
						}
						break;

					case XmlNodeType.EndElement:
						sax.EndElement( reader.Name, reader.Value );
						break;

					case XmlNodeType.Text:
						sax.GetText( reader.Name, reader.Value );
						break;

					case XmlNodeType.Comment:
						sax.ProcessingInst( reader.Name, reader.Value );
						break;

					case XmlNodeType.ProcessingInstruction:
						sax.ProcessingInst( reader.Name, reader.Value );
						break;
				}
			}

			sax.EndDocument();
		}
	}
}