using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace RelationalFloridum_GUI
{
	public partial class Form1 : Form
	{
		private string XML_FILE_PATH = "";
		private string CSV_FILE_PATH = "";
		private string OUTPUT_LOCATION = @"output/";

		public Form1()
		{
			InitializeComponent();
		}

		#region UI-Management
		private void xmlfile_tb_Leave( object sender, EventArgs e )
		{
			if ( !this.xmlfile_tb.Text.Equals( "読み込むXMLファイルを選択してください" ) )
			{
				this.xmlfile_tb.Text = "読み込むXMLファイルを選択してください";
				this.xmlfile_tb.TextAlign = HorizontalAlignment.Center;
				this.xmlfile_tb.ForeColor = Color.Gray;
			}
		}
		private void xmlfile_tb_Enter( object sender, EventArgs e )
		{
			if ( this.xmlfile_tb.Text.Equals( "読み込むXMLファイルを選択してください" ) )
			{
				this.xmlfile_tb.Text = "";
				this.xmlfile_tb.TextAlign = HorizontalAlignment.Left;
				this.xmlfile_tb.ForeColor = Color.Black;
			}
		}
		private void csvfile_tb_Enter( object sender, EventArgs e )
		{
			if ( this.csvfile_tb.Text.Equals( "CSVファイルの書き出し先を指定してください" ) )
			{
				this.csvfile_tb.Text = "";
				this.csvfile_tb.TextAlign = HorizontalAlignment.Left;
				this.csvfile_tb.ForeColor = Color.Black;
			}
		}
		private void csvfile_tb_Leave( object sender, EventArgs e )
		{
			if ( !this.csvfile_tb.Text.Equals( "CSVファイルの書き出し先を指定してください" ) )
			{
				this.csvfile_tb.Text = "CSVファイルの書き出し先を指定してください";
				this.csvfile_tb.TextAlign = HorizontalAlignment.Center;
				this.csvfile_tb.ForeColor = Color.Gray;
			}
		}
		private void button1_Click( object sender, EventArgs e )
		{
			this.openFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
			this.openFileDialog1.FileName = "input.xml";
			this.openFileDialog1.Filter = "XMLファイル(*.xml)|*.xml";
			this.openFileDialog1.Title = "XMLファイルを選択してください";
			if ( this.openFileDialog1.ShowDialog() == DialogResult.OK )
			{
				this.XML_FILE_PATH = this.openFileDialog1.FileName;
				this.xmlfile_tb.TextAlign = HorizontalAlignment.Left;
				this.xmlfile_tb.ForeColor = Color.Black;
				this.xmlfile_tb.Text = this.XML_FILE_PATH;

				// Load XML-Code to TextBox
				this.xmlbx.Text = Utils.inohiroUtil.ReadFile( this.XML_FILE_PATH );

				// Parse XML-Code to TreeStructure
				try
				{
					XmlDocument doc = new XmlDocument();
					doc.Load( this.XML_FILE_PATH );
					this.treeView1.Nodes.Clear();
					this.treeView1.Nodes.Add( new TreeNode( doc.DocumentElement.Name ) );
					TreeNode tNode = new TreeNode();
					tNode = this.treeView1.Nodes[0];
					AddNode( doc.DocumentElement, tNode );
					this.treeView1.ExpandAll();
				}
				catch ( XmlException xmlExp ) { MessageBox.Show( xmlExp.ToString() ); }
				catch ( Exception exp ) { MessageBox.Show( exp.ToString() ); }
			}
		}

		private void AddNode( XmlNode xmlNode, TreeNode treeNode )
		{
			foreach ( XmlNode node in xmlNode.ChildNodes )
			{
				TreeNode tNode = new TreeNode();
				if ( node.NodeType == XmlNodeType.Text )
				{
					tNode = treeNode.Nodes.Add( string.Format( "\"{0}\"", node.Value ) );
				}
				else
				{
					// Attribute をもっていれば
					if ( node.Attributes.Count > 0 )
						tNode = treeNode.Nodes.Add( string.Format( "{0}( {1}={2} )", node.Name, node.Attributes[0].Name, node.Attributes[0].Value ) );
					else
						tNode = treeNode.Nodes.Add( node.Name );
				}
				AddNode( node, tNode );
			}
		}

		private void button2_Click( object sender, EventArgs e )
		{
			this.saveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments.ToString();
			this.saveFileDialog1.FileName = "output.csv";
			this.saveFileDialog1.Filter = "CSVファイル(*.csv)|*.csv";
			this.openFileDialog1.Title = "書き出し先を指定してください";
			if ( this.saveFileDialog1.ShowDialog() == DialogResult.OK )
			{
				this.CSV_FILE_PATH = this.saveFileDialog1.FileName;
				this.csvfile_tb.TextAlign = HorizontalAlignment.Left;
				this.csvfile_tb.ForeColor = Color.Black;
				this.csvfile_tb.Text = this.CSV_FILE_PATH;
			}
		}
		#endregion

		private void Form1_Load( object sender, EventArgs e )
		{
			// テーブル一覧のゲット
			DataTable tmp = DbUtil.GetTables( "FloridumDb", "SELECT name FROM sys.tables" );
			foreach ( DataRow ele in tmp.Rows )
			{
				this.tablelist_bx.Items.Add( Utils.inohiroUtil.ObjArray2String( ele.ItemArray ) );
			}
		}

		/// <summary>
		/// 選択されているテーブルが変更されたらデータを読みに行く
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tablelist_bx_SelectedIndexChanged( object sender, EventArgs e )
		{
//			var table = ( ( DataRowView )this.tablelist_bx.SelectedItem ).Row[0];
			string table = this.tablelist_bx.SelectedItem.ToString();
			try
			{
				this.gridview.DataSource = DbUtil.GetTables( "FloridumDb", string.Format( "SELECT * FROM [{0}]", table ) );
			}
			catch ( Exception exp )
			{
				MessageBox.Show( exp.ToString() );
			}
			this.gridtab.Select();
		}

		/// <summary>
		/// XML to CSV
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void xml2csv_bt_Click( object sender, EventArgs e )
		{
			if ( xmlfile_tb.Text == "" || xmlfile_tb.Text == "読み込むXMLファイルを選択してください" )
			{
				MessageBox.Show( "読み込むXMLファイルを選択してください！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			else if ( csvfile_tb.Text == "" || csvfile_tb.Text == "CSVファイルの書き出し先を指定してください" )
			{
				MessageBox.Show( "CSVファイルの書き出し先を指定してください！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			else
			{
				RelationalFloridum_Lib.SaxParser parser = new RelationalFloridum_Lib.SaxParser();
				parser.Parse( XML_FILE_PATH, CSV_FILE_PATH );
				this.csvbx.Text = Utils.inohiroUtil.ReadFile( CSV_FILE_PATH );
			}
		}

		/// <summary>
		/// CSV to Database Table
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void csv2table_bt_Click( object sender, EventArgs e )
		{
			if ( tablelist_bx.SelectedIndex > 0 )
			{
				string tableName = this.tablelist_bx.SelectedItem.ToString();
				string cntStr = DbUtil.GetConnectionStr( "FloridumDb" );
				string insertCmd = string.Format( "BULK INSERT [dbo].[{0}] FROM \'{1}\' WITH ( FIRSTROW = 2, FIELDTERMINATOR = ',', ROWTERMINATOR = '\n', CODEPAGE = 65001 )", tableName, CSV_FILE_PATH );
				RelationalFloridum_Lib.DbInserter inserter = new RelationalFloridum_Lib.DbInserter();
				try
				{
					inserter.Insert( cntStr, insertCmd );
				}
				catch ( Exception exp )
				{
					MessageBox.Show( exp.ToString() );
				}
			}
	
		}

		/// <summary>
		/// XPath Executive
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void xpath_exebt_Click( object sender, EventArgs e )
		{
			// DB-Tableが選択されているかチェック
			if ( this.tablelist_bx.SelectedItem != null )
			{
				this.textBox1.Text = "";
				RelationalFloridum_Lib.XPathParser parser = new RelationalFloridum_Lib.XPathParser();
				List<RelationalFloridum_Lib.Pack> packs = parser.Parse( this.xpathbx.Text );

				RelationalFloridum_Lib.QueryBuilder builder = new RelationalFloridum_Lib.QueryBuilder();
				string query = builder.Create( packs, this.tablelist_bx.SelectedItem.ToString() );
				string cntStr = DbUtil.GetConnectionStr( "FloridumDb" );

				using ( SqlConnection connection = new SqlConnection( cntStr ) )
				{
					SqlCommand cmd = new SqlCommand( query, connection );
					connection.Open();
#if DEBUG
					Console.WriteLine( "ServerVersion: {0}\nState: {1}", connection.ServerVersion, connection.State );
#endif
					try
					{
						SqlDataAdapter adapter = new SqlDataAdapter();
						DataTable table = new DataTable();
						adapter.SelectCommand = cmd;
						adapter.Fill( table );
						this.gridview.DataSource = table;

						RelationalFloridum_Lib.XmlGenerator generator = new RelationalFloridum_Lib.XmlGenerator();
						string xml = generator.Generate( cmd.CommandText, table.Rows );

						//    foreach ( DataRow ele in table.Rows )
						//    {
						////		MessageBox.Show( Utils.inohiroUtil.ObjArray2String( ele.ItemArray ) );
						//    }

						this.textBox1.Text = cmd.CommandText;
						this.result_xml_bx.Text = xml;
						Stream stream = new FileStream( OUTPUT_LOCATION + "tmp.xml" , FileMode.Create, FileAccess.Write );
						using ( TextWriter writer = new StreamWriter( stream, Encoding.UTF8 ) )
						{
							writer.Write( xml );
						}
					}
					catch ( SqlException exp )
					{
						MessageBox.Show( exp.ToString() );
#if DEBUG
						Console.WriteLine( exp.ToString() );
#endif
					}
					finally
					{
						//		reader.Close();
					}
				}
			}
			else
			{
				MessageBox.Show( "Select DB Table", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}

		private void reload_result_tree_Click( object sender, EventArgs e )
		{
			try
			{
				XmlDocument doc = new XmlDocument();
				doc.Load( OUTPUT_LOCATION + "tmp.xml" );
				this.result_xml_tree.Nodes.Clear();
				this.result_xml_tree.Nodes.Add( new TreeNode( doc.DocumentElement.Name ) );
				TreeNode tNode = new TreeNode();
				tNode = this.result_xml_tree.Nodes[0];
				AddNode( doc.DocumentElement, tNode );
				this.result_xml_tree.ExpandAll();
			}
			catch ( XmlException xmlExp ) { MessageBox.Show( xmlExp.ToString() ); }
			catch ( Exception exp ) { MessageBox.Show( exp.ToString() ); }
		}
	}
}

/*
	XNamespace ns = "http://purl.org.atom/ns#";
	XDocument article = new XDocument(
		new XDeclaration( "1.0", "utf-8", "yes" ),
		new XElement( ns + "entry",
			new XElement( "title", "title2" ),
			new XElement( "content", new XAttribute( "type", "text/plain" ), "content2" ),
			new XElement( "updated", DateTime.Now.ToString( "o", new CultureInfo( "ja-jp" ) ) ) )
		); 
	 article.Declaration = new XDeclaration( "1.0", "utf-8", "no" );
*/
