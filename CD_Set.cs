using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using dataStructs;
using nsDataTracker;
// using testdata;
using FileSystem;
using StructsInit;





namespace AppStart
{
	
	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCDnumber;
        private FolderBrowserDialog folderBrws_diskDevice;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.Container components = null;

		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			 InitializeComponent();

			


			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCDnumber = new System.Windows.Forms.TextBox();
            this.folderBrws_diskDevice = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CD Number:";
            // 
            // txtCDnumber
            // 
            this.txtCDnumber.Location = new System.Drawing.Point(104, 72);
            this.txtCDnumber.Name = "txtCDnumber";
            this.txtCDnumber.Size = new System.Drawing.Size(100, 20);
            this.txtCDnumber.TabIndex = 1;
            this.txtCDnumber.Text = "textBox1";
            this.txtCDnumber.TextChanged += new System.EventHandler(this.txtCDnumber_TextChanged);
            // 
            // folderBrws_diskDevice
            // 
            this.folderBrws_diskDevice.SelectedPath = "C:\\Users\\Acer\\Desktop";
            this.folderBrws_diskDevice.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.txtCDnumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

							
				
		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void dataCDnumber_Click(object sender, System.EventArgs e)
		{
		
		}
		 	
		/// <summary>
		/// *********************  MAIN ********************
		/// </summary>
		
	//	[STAThread]
		static void Main() 
		{		

			
		 
     Application.Run(new DataTracker());  // Initializes Main Form -- DATATRACKER  added STATIC to definition



            // DataTracker();
	
			
			
			


		
		}

        private void txtCDnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }		
		 
		
	}
	
}
