using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace RelationalFloridum_Lib
{
	public enum Operator
	{ 
			Slash = 0,
			Slash2 = 1,
			Dot = 2,
			Dot2 = 3,
			Text = 4
	}

	public class Pack
	{
		public Pack() { } 
		public Pack( string text, Operator operetor ) 
		{
			this.Text = text;
			this.Operator = operetor;
		}
		public string Text { get; set; }
		public Operator Operator { get; set; }
	}

	public class XPathParser
	{
		public XPathParser() { }
		public List<Pack> Parse( string PathExpression )
		{
			List<Pack> queue = new List<Pack>();
			List<Char> buffer = new List<Char>();

			// 文字を1文字ずつ読んでって、Slashとかじゃなければ読み続ける
			// もしSlashに当たれば、その前までを文字列として格納
			// 見つかったSlashなどはOperatorとして格納

			bool slashFlag = false;	// 直前の文字がSlashかどうか

			CharEnumerator cenum = PathExpression.GetEnumerator();
			cenum.MoveNext();	// 最初にMoveNextしないといけない

			// 文字列の長さだけ処理を繰り返す
			for( int i = 0; i < PathExpression.Length; ++i )
			{
				Pack pack = new Pack();

				if( cenum.Current.Equals( '/' ) ) // Slash だったら
				{
					if( slashFlag == false )	// 直前がSlashでない
					{
						// slash フラグを立てて、現在の文字をバッファに追加
						slashFlag = true;
					}
					else // 直前がSlash
					{
						// Operator の確定
						pack.Operator = Operator.Slash2;
						pack.Text = null;
						queue.Add( pack );
						slashFlag = false;
						buffer.Clear();
					}

				}
				else // 文字だったら
				{
					if( slashFlag == false )	// 直前がSlashでない
					{
						// 現在の文字をバッファに追加
						buffer.Add( cenum.Current );
					}
					else
					{
						// OperatorがSlashに確定

						// バッファをTextとして追加
						if( buffer.Count > 0 )
						{
							pack.Operator = Operator.Text;
							pack.Text = new string( buffer.ToArray() );
							queue.Add( pack );
							buffer.Clear();
						}
						// Slash の追加
						pack = new Pack();
						pack.Operator = Operator.Slash;
						pack.Text = null;
						queue.Add( pack );
						slashFlag = false;

						// 現在の文字を追加
						buffer.Add( cenum.Current );
					}
				}

				cenum.MoveNext(); // 次の文字へ
			}

			// 残り物をTextとして追加
			if( buffer.Count > 0 )
			{
				Pack pack = new Pack();
				pack.Operator = Operator.Text;
				pack.Text = new string( buffer.ToArray() );
				queue.Add( pack );
			}

			return queue;
		}
	}
}
