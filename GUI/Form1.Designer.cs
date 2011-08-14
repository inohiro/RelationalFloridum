namespace RelationalFloridum_GUI
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナで生成されたコード

		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.xmlfile_tb = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.csvfile_tb = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.xmltab = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.xmlbx = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.xml2csv_bt = new System.Windows.Forms.Button();
			this.csvtab = new System.Windows.Forms.TabPage();
			this.csv2table_bt = new System.Windows.Forms.Button();
			this.csvbx = new System.Windows.Forms.TextBox();
			this.gridtab = new System.Windows.Forms.TabPage();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.gridviewtab = new System.Windows.Forms.TabPage();
			this.gridview = new System.Windows.Forms.DataGridView();
			this.resultxmltab = new System.Windows.Forms.TabPage();
			this.tabControl4 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.result_xml_bx = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.reload_result_tree = new System.Windows.Forms.Button();
			this.result_xml_tree = new System.Windows.Forms.TreeView();
			this.xpath_exebt = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.xpathbx = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tablelist_bx = new System.Windows.Forms.ComboBox();
			this.floridumDbDataSet = new RelationalFloridum_GUI.FloridumDbDataSet();
			this.floridumDbDataSetBindingSource = new System.Windows.Forms.BindingSource( this.components );
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.xmltab.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.csvtab.SuspendLayout();
			this.gridtab.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.gridviewtab.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.gridview ) ).BeginInit();
			this.resultxmltab.SuspendLayout();
			this.tabControl4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.floridumDbDataSet ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.floridumDbDataSetBindingSource ) ).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 12, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 38, 18 );
			this.label1.TabIndex = 0;
			this.label1.Text = "XML:";
			// 
			// xmlfile_tb
			// 
			this.xmlfile_tb.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.xmlfile_tb.ForeColor = System.Drawing.Color.Gray;
			this.xmlfile_tb.Location = new System.Drawing.Point( 60, 6 );
			this.xmlfile_tb.Name = "xmlfile_tb";
			this.xmlfile_tb.Size = new System.Drawing.Size( 613, 25 );
			this.xmlfile_tb.TabIndex = 1;
			this.xmlfile_tb.Text = "読み込むXMLファイルを選択してください";
			this.xmlfile_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.xmlfile_tb.Leave += new System.EventHandler( this.xmlfile_tb_Leave );
			this.xmlfile_tb.Enter += new System.EventHandler( this.xmlfile_tb_Enter );
			// 
			// button1
			// 
			this.button1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.button1.Location = new System.Drawing.Point( 679, 7 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size( 75, 23 );
			this.button1.TabIndex = 2;
			this.button1.Text = "参照";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler( this.button1_Click );
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 12, 40 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 37, 18 );
			this.label2.TabIndex = 3;
			this.label2.Text = "CSV:";
			// 
			// csvfile_tb
			// 
			this.csvfile_tb.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.csvfile_tb.ForeColor = System.Drawing.Color.Gray;
			this.csvfile_tb.Location = new System.Drawing.Point( 60, 37 );
			this.csvfile_tb.Name = "csvfile_tb";
			this.csvfile_tb.Size = new System.Drawing.Size( 613, 25 );
			this.csvfile_tb.TabIndex = 4;
			this.csvfile_tb.Text = "CSVファイルの書き出し先を指定してください";
			this.csvfile_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.csvfile_tb.Leave += new System.EventHandler( this.csvfile_tb_Leave );
			this.csvfile_tb.Enter += new System.EventHandler( this.csvfile_tb_Enter );
			// 
			// button2
			// 
			this.button2.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.button2.Location = new System.Drawing.Point( 679, 38 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size( 75, 23 );
			this.button2.TabIndex = 5;
			this.button2.Text = "選択";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler( this.button2_Click );
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tabControl1.Controls.Add( this.xmltab );
			this.tabControl1.Controls.Add( this.csvtab );
			this.tabControl1.Controls.Add( this.gridtab );
			this.tabControl1.Location = new System.Drawing.Point( 15, 100 );
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size( 742, 604 );
			this.tabControl1.TabIndex = 6;
			// 
			// xmltab
			// 
			this.xmltab.Controls.Add( this.tabControl2 );
			this.xmltab.Controls.Add( this.xml2csv_bt );
			this.xmltab.Location = new System.Drawing.Point( 4, 27 );
			this.xmltab.Name = "xmltab";
			this.xmltab.Padding = new System.Windows.Forms.Padding( 3 );
			this.xmltab.Size = new System.Drawing.Size( 734, 573 );
			this.xmltab.TabIndex = 0;
			this.xmltab.Text = "XML";
			this.xmltab.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tabControl2.Controls.Add( this.tabPage1 );
			this.tabControl2.Controls.Add( this.tabPage2 );
			this.tabControl2.Location = new System.Drawing.Point( 6, 35 );
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size( 722, 532 );
			this.tabControl2.TabIndex = 10;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add( this.xmlbx );
			this.tabPage1.Location = new System.Drawing.Point( 4, 27 );
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage1.Size = new System.Drawing.Size( 714, 501 );
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Code";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// xmlbx
			// 
			this.xmlbx.AcceptsReturn = true;
			this.xmlbx.AcceptsTab = true;
			this.xmlbx.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.xmlbx.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.xmlbx.Location = new System.Drawing.Point( 6, 6 );
			this.xmlbx.Multiline = true;
			this.xmlbx.Name = "xmlbx";
			this.xmlbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.xmlbx.Size = new System.Drawing.Size( 702, 489 );
			this.xmlbx.TabIndex = 0;
			this.xmlbx.WordWrap = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add( this.treeView1 );
			this.tabPage2.Location = new System.Drawing.Point( 4, 27 );
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage2.Size = new System.Drawing.Size( 714, 501 );
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Tree Structure";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.treeView1.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.treeView1.Location = new System.Drawing.Point( 6, 6 );
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size( 702, 489 );
			this.treeView1.TabIndex = 0;
			// 
			// xml2csv_bt
			// 
			this.xml2csv_bt.Location = new System.Drawing.Point( 6, 6 );
			this.xml2csv_bt.Name = "xml2csv_bt";
			this.xml2csv_bt.Size = new System.Drawing.Size( 152, 23 );
			this.xml2csv_bt.TabIndex = 9;
			this.xml2csv_bt.Text = "XMLからCSVに変換";
			this.xml2csv_bt.UseVisualStyleBackColor = true;
			this.xml2csv_bt.Click += new System.EventHandler( this.xml2csv_bt_Click );
			// 
			// csvtab
			// 
			this.csvtab.Controls.Add( this.csv2table_bt );
			this.csvtab.Controls.Add( this.csvbx );
			this.csvtab.Location = new System.Drawing.Point( 4, 27 );
			this.csvtab.Name = "csvtab";
			this.csvtab.Padding = new System.Windows.Forms.Padding( 3 );
			this.csvtab.Size = new System.Drawing.Size( 734, 573 );
			this.csvtab.TabIndex = 1;
			this.csvtab.Text = "CSV";
			this.csvtab.UseVisualStyleBackColor = true;
			// 
			// csv2table_bt
			// 
			this.csv2table_bt.Location = new System.Drawing.Point( 6, 6 );
			this.csv2table_bt.Name = "csv2table_bt";
			this.csv2table_bt.Size = new System.Drawing.Size( 215, 23 );
			this.csv2table_bt.TabIndex = 1;
			this.csv2table_bt.Text = "CSVからTableに挿入";
			this.csv2table_bt.UseVisualStyleBackColor = true;
			this.csv2table_bt.Click += new System.EventHandler( this.csv2table_bt_Click );
			// 
			// csvbx
			// 
			this.csvbx.AcceptsReturn = true;
			this.csvbx.AcceptsTab = true;
			this.csvbx.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.csvbx.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.csvbx.Location = new System.Drawing.Point( 6, 36 );
			this.csvbx.Multiline = true;
			this.csvbx.Name = "csvbx";
			this.csvbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.csvbx.Size = new System.Drawing.Size( 722, 531 );
			this.csvbx.TabIndex = 0;
			// 
			// gridtab
			// 
			this.gridtab.Controls.Add( this.textBox1 );
			this.gridtab.Controls.Add( this.label5 );
			this.gridtab.Controls.Add( this.tabControl3 );
			this.gridtab.Controls.Add( this.xpath_exebt );
			this.gridtab.Controls.Add( this.label4 );
			this.gridtab.Controls.Add( this.xpathbx );
			this.gridtab.Location = new System.Drawing.Point( 4, 27 );
			this.gridtab.Name = "gridtab";
			this.gridtab.Padding = new System.Windows.Forms.Padding( 3 );
			this.gridtab.Size = new System.Drawing.Size( 734, 573 );
			this.gridtab.TabIndex = 2;
			this.gridtab.Text = "Database";
			this.gridtab.UseVisualStyleBackColor = true;
			// 
			// tabControl3
			// 
			this.tabControl3.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tabControl3.Controls.Add( this.gridviewtab );
			this.tabControl3.Controls.Add( this.resultxmltab );
			this.tabControl3.Location = new System.Drawing.Point( 16, 87 );
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size( 722, 480 );
			this.tabControl3.TabIndex = 3;
			// 
			// gridviewtab
			// 
			this.gridviewtab.Controls.Add( this.gridview );
			this.gridviewtab.Location = new System.Drawing.Point( 4, 27 );
			this.gridviewtab.Name = "gridviewtab";
			this.gridviewtab.Padding = new System.Windows.Forms.Padding( 3 );
			this.gridviewtab.Size = new System.Drawing.Size( 714, 449 );
			this.gridviewtab.TabIndex = 0;
			this.gridviewtab.Text = "DataGrid";
			this.gridviewtab.UseVisualStyleBackColor = true;
			// 
			// gridview
			// 
			this.gridview.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridview.Location = new System.Drawing.Point( 6, 6 );
			this.gridview.Name = "gridview";
			this.gridview.RowTemplate.Height = 21;
			this.gridview.Size = new System.Drawing.Size( 702, 437 );
			this.gridview.TabIndex = 3;
			// 
			// resultxmltab
			// 
			this.resultxmltab.Controls.Add( this.tabControl4 );
			this.resultxmltab.Location = new System.Drawing.Point( 4, 27 );
			this.resultxmltab.Name = "resultxmltab";
			this.resultxmltab.Padding = new System.Windows.Forms.Padding( 3 );
			this.resultxmltab.Size = new System.Drawing.Size( 714, 449 );
			this.resultxmltab.TabIndex = 1;
			this.resultxmltab.Text = "Result XML";
			this.resultxmltab.UseVisualStyleBackColor = true;
			// 
			// tabControl4
			// 
			this.tabControl4.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tabControl4.Controls.Add( this.tabPage3 );
			this.tabControl4.Controls.Add( this.tabPage4 );
			this.tabControl4.Location = new System.Drawing.Point( 6, 6 );
			this.tabControl4.Name = "tabControl4";
			this.tabControl4.SelectedIndex = 0;
			this.tabControl4.Size = new System.Drawing.Size( 702, 437 );
			this.tabControl4.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add( this.result_xml_bx );
			this.tabPage3.Location = new System.Drawing.Point( 4, 27 );
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage3.Size = new System.Drawing.Size( 694, 406 );
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Code";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// result_xml_bx
			// 
			this.result_xml_bx.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.result_xml_bx.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.result_xml_bx.Location = new System.Drawing.Point( 6, 6 );
			this.result_xml_bx.Multiline = true;
			this.result_xml_bx.Name = "result_xml_bx";
			this.result_xml_bx.Size = new System.Drawing.Size( 682, 394 );
			this.result_xml_bx.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add( this.reload_result_tree );
			this.tabPage4.Controls.Add( this.result_xml_tree );
			this.tabPage4.Location = new System.Drawing.Point( 4, 27 );
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding( 3 );
			this.tabPage4.Size = new System.Drawing.Size( 694, 406 );
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Tree Structure";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// reload_result_tree
			// 
			this.reload_result_tree.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.reload_result_tree.Location = new System.Drawing.Point( 613, 376 );
			this.reload_result_tree.Name = "reload_result_tree";
			this.reload_result_tree.Size = new System.Drawing.Size( 75, 23 );
			this.reload_result_tree.TabIndex = 1;
			this.reload_result_tree.Text = "Reload";
			this.reload_result_tree.UseVisualStyleBackColor = true;
			this.reload_result_tree.Click += new System.EventHandler( this.reload_result_tree_Click );
			// 
			// result_xml_tree
			// 
			this.result_xml_tree.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
						| System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.result_xml_tree.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.result_xml_tree.Location = new System.Drawing.Point( 6, 6 );
			this.result_xml_tree.Name = "result_xml_tree";
			this.result_xml_tree.Size = new System.Drawing.Size( 682, 364 );
			this.result_xml_tree.TabIndex = 0;
			// 
			// xpath_exebt
			// 
			this.xpath_exebt.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.xpath_exebt.Location = new System.Drawing.Point( 640, 6 );
			this.xpath_exebt.Name = "xpath_exebt";
			this.xpath_exebt.Size = new System.Drawing.Size( 88, 31 );
			this.xpath_exebt.TabIndex = 2;
			this.xpath_exebt.Text = "実行";
			this.xpath_exebt.UseVisualStyleBackColor = true;
			this.xpath_exebt.Click += new System.EventHandler( this.xpath_exebt_Click );
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.label4.Location = new System.Drawing.Point( 6, 9 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 63, 24 );
			this.label4.TabIndex = 1;
			this.label4.Text = "XPath:";
			// 
			// xpathbx
			// 
			this.xpathbx.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.xpathbx.Location = new System.Drawing.Point( 75, 6 );
			this.xpathbx.Name = "xpathbx";
			this.xpathbx.Size = new System.Drawing.Size( 559, 31 );
			this.xpathbx.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 12, 71 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 30, 18 );
			this.label3.TabIndex = 7;
			this.label3.Text = "DB:";
			// 
			// tablelist_bx
			// 
			this.tablelist_bx.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.tablelist_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tablelist_bx.FormattingEnabled = true;
			this.tablelist_bx.Location = new System.Drawing.Point( 60, 68 );
			this.tablelist_bx.Name = "tablelist_bx";
			this.tablelist_bx.Size = new System.Drawing.Size( 694, 26 );
			this.tablelist_bx.TabIndex = 8;
			this.tablelist_bx.SelectedIndexChanged += new System.EventHandler( this.tablelist_bx_SelectedIndexChanged );
			// 
			// floridumDbDataSet
			// 
			this.floridumDbDataSet.DataSetName = "FloridumDbDataSet";
			this.floridumDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// floridumDbDataSetBindingSource
			// 
			this.floridumDbDataSetBindingSource.DataSource = this.floridumDbDataSet;
			this.floridumDbDataSetBindingSource.Position = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.label5.Location = new System.Drawing.Point( 6, 45 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 137, 24 );
			this.label5.TabIndex = 4;
			this.label5.Text = "実行されたSQL文";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.textBox1.Font = new System.Drawing.Font( "メイリオ", 12F );
			this.textBox1.Location = new System.Drawing.Point( 149, 42 );
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size( 579, 31 );
			this.textBox1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 18F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 766, 716 );
			this.Controls.Add( this.tablelist_bx );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.tabControl1 );
			this.Controls.Add( this.button2 );
			this.Controls.Add( this.csvfile_tb );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.button1 );
			this.Controls.Add( this.xmlfile_tb );
			this.Controls.Add( this.label1 );
			this.Font = new System.Drawing.Font( "メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 128 ) ) );
			this.Margin = new System.Windows.Forms.Padding( 3, 4, 3, 4 );
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler( this.Form1_Load );
			this.tabControl1.ResumeLayout( false );
			this.xmltab.ResumeLayout( false );
			this.tabControl2.ResumeLayout( false );
			this.tabPage1.ResumeLayout( false );
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout( false );
			this.csvtab.ResumeLayout( false );
			this.csvtab.PerformLayout();
			this.gridtab.ResumeLayout( false );
			this.gridtab.PerformLayout();
			this.tabControl3.ResumeLayout( false );
			this.gridviewtab.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.gridview ) ).EndInit();
			this.resultxmltab.ResumeLayout( false );
			this.tabControl4.ResumeLayout( false );
			this.tabPage3.ResumeLayout( false );
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.floridumDbDataSet ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.floridumDbDataSetBindingSource ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox xmlfile_tb;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox csvfile_tb;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage xmltab;
		private System.Windows.Forms.TabPage csvtab;
		private System.Windows.Forms.TabPage gridtab;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox tablelist_bx;
		private System.Windows.Forms.BindingSource floridumDbDataSetBindingSource;
		private FloridumDbDataSet floridumDbDataSet;
		private System.Windows.Forms.TextBox xmlbx;
		private System.Windows.Forms.TextBox csvbx;
		private System.Windows.Forms.DataGridView gridview;
		private System.Windows.Forms.Button xpath_exebt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox xpathbx;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button xml2csv_bt;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TabControl tabControl3;
		private System.Windows.Forms.TabPage gridviewtab;
		private System.Windows.Forms.TabPage resultxmltab;
		private System.Windows.Forms.TabControl tabControl4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Button csv2table_bt;
		private System.Windows.Forms.TreeView result_xml_tree;
		private System.Windows.Forms.TextBox result_xml_bx;
		private System.Windows.Forms.Button reload_result_tree;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
	}
}

