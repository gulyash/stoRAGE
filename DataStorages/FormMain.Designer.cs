namespace DataStorages
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.Employee = new System.Windows.Forms.ToolStripLabel();
			this.Good = new System.Windows.Forms.ToolStripLabel();
			this.Order = new System.Windows.Forms.ToolStripLabel();
			this.OrderStatus = new System.Windows.Forms.ToolStripLabel();
			this.Position = new System.Windows.Forms.ToolStripLabel();
			this.StatusDictionary = new System.Windows.Forms.ToolStripLabel();
			this.Table = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Employee,
            this.Good,
            this.Order,
            this.OrderStatus,
            this.Position,
            this.StatusDictionary,
            this.Table});
			this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(198, 156);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
			// 
			// Employee
			// 
			this.Employee.Name = "Employee";
			this.Employee.Size = new System.Drawing.Size(196, 15);
			this.Employee.Text = "Employee";
			// 
			// Good
			// 
			this.Good.Name = "Good";
			this.Good.Size = new System.Drawing.Size(196, 15);
			this.Good.Text = "Good";
			// 
			// Order
			// 
			this.Order.Name = "Order";
			this.Order.Size = new System.Drawing.Size(196, 15);
			this.Order.Text = "Order";
			// 
			// OrderStatus
			// 
			this.OrderStatus.Name = "OrderStatus";
			this.OrderStatus.Size = new System.Drawing.Size(196, 15);
			this.OrderStatus.Text = "OrderStatus";
			// 
			// Position
			// 
			this.Position.Name = "Position";
			this.Position.Size = new System.Drawing.Size(196, 15);
			this.Position.Text = "Position";
			// 
			// StatusDictionary
			// 
			this.StatusDictionary.Name = "StatusDictionary";
			this.StatusDictionary.Size = new System.Drawing.Size(196, 15);
			this.StatusDictionary.Text = "StatusDictionary";
			// 
			// Table
			// 
			this.Table.Name = "Table";
			this.Table.Size = new System.Drawing.Size(196, 15);
			this.Table.Text = "Table";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(198, 179);
			this.Controls.Add(this.toolStrip);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripLabel Employee;
		private System.Windows.Forms.ToolStripLabel Good;
		private System.Windows.Forms.ToolStripLabel Order;
		private System.Windows.Forms.ToolStripLabel OrderStatus;
		private System.Windows.Forms.ToolStripLabel Position;
		private System.Windows.Forms.ToolStripLabel StatusDictionary;
		private System.Windows.Forms.ToolStripLabel Table;
	}
}