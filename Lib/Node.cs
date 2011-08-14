using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RelationalFloridum_Lib
{
	public class Node
	{
		private string OUTPUT_LOCATION;
		private bool IsToXml = false;

		public Node( bool isToXml ) 
		{
			this.IsToXml = isToXml;
			this.OUTPUT_LOCATION = @"output/internal.xml";
		}
		public Node( string filepath )
		{
			this.OUTPUT_LOCATION = filepath;
			this.Path = new List<string>();
			this.NodeNumber = new List<int>();
		}

		public enum NodeType
		{
			StartElement,
			EndElement,
			Comment,
			Attribute,
			Text,
			ProcessingInstructions
		}

		public string Name { get; set; }
		public string Value { get; set; }
		public List<String> Path { get; set; }
		public int DocumentId { get; set; }
		public string Prefix { get; set; }
		public string NamespaceURI { get; set; }
		public NodeType Type { get; set; }

		// 深さレベル
		public int Level { get; set; }

		// Nodeの通し番号
		public int SerialNumber { get; set; }

		// 階層関係を表現
		public List<Int32> NodeNumber { get; set; }

		public void Output()
		{
			if ( IsToXml ) // to XML for Result Outputs
			{ 
				Stream stream = new FileStream( OUTPUT_LOCATION, FileMode.Create, FileAccess.Write );
				using ( TextWriter writer = new StreamWriter( stream, Encoding.UTF8 ) )
				{
					if ( this.Type == NodeType.StartElement )
						writer.WriteLine( string.Format( "<{0}>", this.Value ) );
					else if( this.Type == NodeType.Attribute )
						writer.WriteLine( string.Format( "{0} = {1}", this.Name, this.Value ) );
					else if( this.Type == NodeType.Text )
						writer.WriteLine( string.Format( "{0}", this.Value ) );
				}
			}
			else
			{
				// Path を組み立てる
				StringBuilder path = new StringBuilder();
				this.Path.Reverse();
				foreach ( string node in this.Path )
				{
					path.Append( "/" + node );
				}

				//List<int> rNodeNum = new List<int>();
				this.NodeNumber.Reverse();

				// NodeNumber を組み立てる
				StringBuilder outputNodeNumber = new StringBuilder();
				for ( int i = 0; i < this.NodeNumber.Count; i++ )
				{
					// 最後の要素の時はピリオドをくっつけない
					if ( i == this.NodeNumber.Count - 1 )
					{
						outputNodeNumber.Append( this.NodeNumber[this.NodeNumber.Count - 1 - i] );
						break;
					}
					outputNodeNumber.Append( this.NodeNumber[this.NodeNumber.Count - 1 - i] + "." );
				}

				// 要素の中身が空だったらnullと書く
				if ( this.Value.Equals( "" ) ) this.Value = "null";
				if ( this.Name.Equals( "" ) ) this.Name = "null";

				// ファイルに出力（FileModeを変更する必要がある
				Stream stream = new FileStream( OUTPUT_LOCATION, FileMode.Append, FileAccess.Write );
				using ( TextWriter writer = new StreamWriter( stream, Encoding.UTF8 ) )
				{
					// , check <- 効いてない
					CharEnumerator cenum = this.Value.GetEnumerator();
					cenum.MoveNext();
					bool cmFlg = false;
					bool rtFlg = false;
					bool tbFlg = false;

					for ( int i = 0; i < this.Value.Length; i++ )
					{
						if ( cenum.Current.Equals( ',' ) )
							cmFlg = true;
						if ( cenum.Current.Equals( '\n' ) )
							rtFlg = true;
						if ( cenum.Current.Equals( '\t' ) )
							tbFlg = true;

						cenum.MoveNext();
					}

					if ( cmFlg || rtFlg || tbFlg )
						this.Value = string.Format( "\"{0}\"", this.Value );

					writer.WriteLine( "{0},{1},{2},{3},{4},{5},{6}",
						this.SerialNumber,
						this.Level,
						this.Type,
						this.Name,
						this.Value,
						outputNodeNumber.ToString(),
						path.ToString()
					);
				}
			}
		}
	}
}
