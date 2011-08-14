using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

/*
 * ToDo
 *	XPathをSQLへ
 * 
 */

namespace RelationalFloridum_Lib
{
	public class SaxModel
	{
		private int serialBaseNum = 0;
		private const int MAX_DEPTH = 100;
		private string OUTPUT_LOCATION;

		// ノード自体を格納するスタック
		Stack<Node> stack = new Stack<Node>();

		// Pathを作るためのスタック
		Stack<String> pathtack = new Stack<string>();

		// 階層関係を作る
		private int currentLevel = -1;
		private int[] numArray = new int[MAX_DEPTH];

		bool IsToXml = false;

		public SaxModel( bool isToXml ) 
		{
			if ( isToXml ) this.IsToXml = isToXml;
			this.OUTPUT_LOCATION = @"output\internal.xml";
			for ( int i = 0; i < MAX_DEPTH; i++ )
				numArray[i] = 0;
		}

		public SaxModel( string filepath ) 
		{
			this.OUTPUT_LOCATION = filepath;
			for( int i = 0; i < MAX_DEPTH; i++ )
				numArray[i] = 0;
		}

		public void StartDocument() 
		{ 
#if DEBUG
			Console.WriteLine( "Document Start" ); 
#endif
		}
		public void EndDocument() 
		{ 
#if DEBUG
			Console.WriteLine( "Document End" ); 
#endif
		}

		public void StartElement( string name, string value, bool isEmptyElement )
		{
			// 新しいNodeオブジェクトの生成と基本情報のセット
			Node node = new Node( OUTPUT_LOCATION );

			node.Type = Node.NodeType.StartElement;
			node.Name = name;
			node.Value = value;

			// 深さレベル
			node.Level = stack.Count;

			// シリアルナンバー（通し番号）
			node.SerialNumber = serialBaseNum;
			serialBaseNum++;

			currentLevel++;
			numArray[currentLevel] += 1;

			for( int i = 0; numArray[i] != 0; i++ )
				node.NodeNumber.Add( numArray[i] );

			// Pathを作る
			pathtack.Push( node.Name );
			foreach( string path in pathtack )
				node.Path.Add( path );

			// 自分自身をスタックにプッシュ（レベルを下げる）
			stack.Push( node );

			// 情報をアウトプット
			node.Output();

			// <Element /> タイプの処理
			if( isEmptyElement )
			{
				numArray[currentLevel + 1] = 0;
				currentLevel--;
				stack.Pop();
				pathtack.Pop();
			}

#if DEBUG
			if( node.SerialNumber % 10000 == 0 )
				Console.WriteLine( node.SerialNumber );
#endif
		}

		public void GetText( string name, string value )
		{
			Node node = new Node( OUTPUT_LOCATION );

			node.Type = Node.NodeType.Text;
			node.Name = name;
			node.Value = value;

			node.SerialNumber = serialBaseNum;
			serialBaseNum++;

			node.Level = stack.Count;

			currentLevel++;
			numArray[currentLevel] += 1;

			for( int i = 0; numArray[i] !=0; i++ )
				node.NodeNumber.Add( numArray[i] );

			// Path
			foreach( string path in pathtack ) 
				node.Path.Add( path );

			// 出力
			node.Output();

			// Textは単一ノードで完結していると考える（<Text />）
			numArray[currentLevel + 1] = 0;
			currentLevel--;
		}

		public void GetAttribute( string name, string value )
		{
			Node node = new Node( OUTPUT_LOCATION );

			node.Type = Node.NodeType.Attribute;
			node.Name = name;
			node.Value = value;

			node.Level = stack.Count - 1;

			// SerialNumber
			node.SerialNumber = serialBaseNum;
			serialBaseNum++;

			// NodeNumber（動かさない）
			for( int i = 0; numArray[i] != 0; i++ )
				node.NodeNumber.Add( numArray[i] );

			// Path
			foreach( string path in pathtack ) 
				node.Path.Add( path );
			
			node.Output();
		}

		public void EndElement( string name, string value )
		{
			pathtack.Pop();
			stack.Pop();

			numArray[currentLevel + 1] = 0;
			currentLevel--;
		}

		public void GetComment( string name, string value )
		{
			//Node node = new Node();
			//node.Type = Node.NodeType.Comment;

		}

		public void ProcessingInst( string name, string value )
		{
			//Node node = new Node();
			//node.Type = Node.NodeType.ProcessingInstructions;

		}
	}
}