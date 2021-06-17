using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Controls_Host
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label Label3;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Windows.Forms.Label Label2;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Windows.Forms.Label Label1;
		internal Controls_Host.DataSet1 DataSet11;
		private NumericTextBox numericTextBox1;
		private OrderItemControl orderItemControl1;
		private VerticalLabel verticalLabel1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Label3 = new System.Windows.Forms.Label();
			this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.Label2 = new System.Windows.Forms.Label();
			this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.Label1 = new System.Windows.Forms.Label();
			this.DataSet11 = new Controls_Host.DataSet1();
			this.numericTextBox1 = new NumericTextBox(this.components);
			this.orderItemControl1 = new OrderItemControl();
			this.verticalLabel1 = new VerticalLabel(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(8, 184);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(168, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Custom Control : Vertical Label";
			// 
			// SqlSelectCommand1
			// 
			this.SqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice FROM Products";
			this.SqlSelectCommand1.Connection = this.SqlConnection1;
			// 
			// SqlConnection1
			// 
			this.SqlConnection1.ConnectionString = "data source=(local)\\MOC;initial catalog=Northwind;integrated security=SSPI;persis" +
				"t security info=False;packet size=4096";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label2.Location = new System.Drawing.Point(8, 96);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(203, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Composite Control : OrderItemControl";
			// 
			// SqlDataAdapter1
			// 
			this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
			this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
																																																				  new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																				  new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
																																																				  new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice")})});
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(8, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(192, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Extended Control : NumericTextBox";
			// 
			// DataSet11
			// 
			this.DataSet11.DataSetName = "DataSet1";
			this.DataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			this.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// numericTextBox1
			// 
			this.numericTextBox1.Location = new System.Drawing.Point(24, 48);
			this.numericTextBox1.Name = "numericTextBox1";
			this.numericTextBox1.TabIndex = 6;
			this.numericTextBox1.Text = "";
			// 
			// orderItemControl1
			// 
			this.orderItemControl1.DiscountTextBox_ContextMenu = null;
			this.orderItemControl1.Location = new System.Drawing.Point(16, 128);
			this.orderItemControl1.Name = "orderItemControl1";
			this.orderItemControl1.OrderDiscount = "";
			this.orderItemControl1.OrderPrice = "";
			this.orderItemControl1.OrderProductName = "";
			this.orderItemControl1.OrderQuantity = "";
			this.orderItemControl1.OrderQuantityPerUnit = "";
			this.orderItemControl1.QuantityTextBox_ContextMenu = null;
			this.orderItemControl1.Size = new System.Drawing.Size(616, 24);
			this.orderItemControl1.TabIndex = 7;
			// 
			// verticalLabel1
			// 
			this.verticalLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.verticalLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.verticalLabel1.Location = new System.Drawing.Point(32, 224);
			this.verticalLabel1.Name = "verticalLabel1";
			this.verticalLabel1.Size = new System.Drawing.Size(32, 80);
			this.verticalLabel1.TabIndex = 8;
			this.verticalLabel1.Text = "verticalLabel1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 382);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.verticalLabel1,
																		  this.orderItemControl1,
																		  this.numericTextBox1,
																		  this.Label1,
																		  this.Label3,
																		  this.Label2});
			this.Name = "Form1";
			this.Text = "Controls";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//SqlDataAdapter1.Fill(DataSet11);
		//orderItemControl1.GetProductData(DataSet11.Products);
		}
	}
}
