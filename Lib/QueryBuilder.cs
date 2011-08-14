using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//要素名->SQL

//WHERE nodetable.path LIKE '/bib/#/title'

//# は *

//１、パーサジェネレータで単純なXPathの文法（/**/**, /**//** )を定義
//２、SQLの生成

namespace RelationalFloridum_Lib
{
	/// <summary>
	/// Packのリスト(XPathパース後）からSQLコマンドを生成する
	/// </summary>
	public class QueryBuilder
	{
		public QueryBuilder() { }

		private string CreateString( List<Pack> packs )
		{
			StringBuilder builder = new StringBuilder();
			foreach ( var element in packs )
			{
				builder.Append( element.Text );
				if (! element.Operator.Equals( Operator.Text ) )
				{ 

				}
			}
			return builder.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="packs"></param>
		/// <param name="tablename"></param>
		/// <returns></returns>
		public string Create( List<Pack> packs, string tablename )
		{
			StringBuilder expRoot = new StringBuilder();
			string query = "";
			switch ( packs[0].Operator )
			{
				case Operator.Slash2: // 後で実装する

//					string exp = CreateString( packs.Remove( packs[0] ) );
					packs.RemoveAt( 0 ); // delete Slash2 
					string exp = CreateString( packs );

					// 文字列の結合
					foreach ( var element in packs )
					{
						if ( element.Operator.Equals( Operator.Text ) )
						{
							expRoot.Append( element.Text );
						}
						else
						{
							if ( element.Operator.Equals( Operator.Slash ) )
								expRoot.Append( "/" );
						}
					}

					query = string.Format( "SELECT * FROM [dbo].[{0}] AS [t0] WHERE ( [t0].[Path] LIKE '/%/{1}%' )", tablename, expRoot.ToString() );
					break;

				case Operator.Slash:
					foreach ( var element in packs )
					{
						if ( element.Operator.Equals( Operator.Text ) )
						{
							expRoot.Append( element.Text );
						}
						else
						{
							if ( element.Operator.Equals( Operator.Slash ) )
								expRoot.Append( "/" );
						}
					}

					// SELECT [t0].[NodeType]
					// FROM [dbo].[Table_2] AS [t0]
					// WHERE [t0].[Depth] = 2

					//--SELECT	*
					//--FROM	Table_3
					//--WHERE	( Path LIKE '/Title%' )
					//SELECT * 
					//FROM [dbo].[Table_3] 
					//--AS [t0] 
					//WHERE ( Path LIKE '/Books%' )

					query = string.Format( "SELECT * FROM [dbo].[{0}] AS [t0] WHERE ( [t0].[Path] LIKE '{1}/%' )", tablename, expRoot.ToString() );
					break;

				case Operator.Dot2:
					break;

				case Operator.Dot:
					break;

				case Operator.Text:
					break;
			}
			return query;
		}


		/// <summary>
		/// 文字列を元にSQLコマンドを組み立てる
		/// </summary>
		/// <param name="xpath">XPath式</param>
		/// <returns>SQLコマンド</returns>
		public string Create( string xpath )
		{
			string query;
			query = "Hello";
			return query;
		}
	}
}
