namespace DataStorages
{
	partial class FormOrders
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.employeeComboBox = new System.Windows.Forms.ComboBox();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vHBarDataSet = new DataStorages.VHBarDataSet();
			this.goodComboBox = new System.Windows.Forms.ComboBox();
			this.goodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableComboBox = new System.Windows.Forms.ComboBox();
			this.tablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tableAdapterManager = new DataStorages.VHBarDataSetTableAdapters.TableAdapterManager();
			this.employeeTableAdapter = new DataStorages.VHBarDataSetTableAdapters.EmployeeTableAdapter();
			this.goodTableAdapter = new DataStorages.VHBarDataSetTableAdapters.GoodTableAdapter();
			this.tablesTableAdapter = new DataStorages.VHBarDataSetTableAdapters.TablesTableAdapter();
			this.queriesTableAdapter1 = new DataStorages.VHBarDataSetTableAdapters.QueriesTableAdapter();
			this.view_OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_OrdersTableAdapter = new DataStorages.VHBarDataSetTableAdapters.View_OrdersTableAdapter();
			this.view_OrdersDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel2 = new System.Windows.Forms.Panel();
			this.allTablesCheckBox = new System.Windows.Forms.CheckBox();
			this.eTextBox = new System.Windows.Forms.TextBox();
			this.gTextBox = new System.Windows.Forms.TextBox();
			this.tComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.discardFilterButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.applyFilterButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrdersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrdersDataGridView)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Controls.Add(this.buttonUpdate);
			this.panel1.Controls.Add(this.buttonInsert);
			this.panel1.Location = new System.Drawing.Point(12, 356);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(84, 93);
			this.panel1.TabIndex = 4;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(4, 64);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 2;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.button_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(4, 34);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
			this.buttonUpdate.TabIndex = 1;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.button_Click);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Location = new System.Drawing.Point(4, 4);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(75, 23);
			this.buttonInsert.TabIndex = 0;
			this.buttonInsert.Text = "Insert";
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.button_Click);
			// 
			// employeeComboBox
			// 
			this.employeeComboBox.DataSource = this.employeeBindingSource;
			this.employeeComboBox.DisplayMember = "first_name";
			this.employeeComboBox.FormattingEnabled = true;
			this.employeeComboBox.Location = new System.Drawing.Point(356, 355);
			this.employeeComboBox.Name = "employeeComboBox";
			this.employeeComboBox.Size = new System.Drawing.Size(121, 21);
			this.employeeComboBox.TabIndex = 5;
			this.employeeComboBox.ValueMember = "id";
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataMember = "Employee";
			this.employeeBindingSource.DataSource = this.vHBarDataSet;
			// 
			// vHBarDataSet
			// 
			this.vHBarDataSet.DataSetName = "VHBarDataSet";
			this.vHBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// goodComboBox
			// 
			this.goodComboBox.DataSource = this.goodBindingSource;
			this.goodComboBox.DisplayMember = "name";
			this.goodComboBox.FormattingEnabled = true;
			this.goodComboBox.Location = new System.Drawing.Point(229, 355);
			this.goodComboBox.Name = "goodComboBox";
			this.goodComboBox.Size = new System.Drawing.Size(121, 21);
			this.goodComboBox.TabIndex = 6;
			this.goodComboBox.ValueMember = "id";
			// 
			// goodBindingSource
			// 
			this.goodBindingSource.DataMember = "Good";
			this.goodBindingSource.DataSource = this.vHBarDataSet;
			// 
			// tableComboBox
			// 
			this.tableComboBox.DataSource = this.tablesBindingSource;
			this.tableComboBox.DisplayMember = "number";
			this.tableComboBox.FormattingEnabled = true;
			this.tableComboBox.Location = new System.Drawing.Point(102, 355);
			this.tableComboBox.Name = "tableComboBox";
			this.tableComboBox.Size = new System.Drawing.Size(121, 21);
			this.tableComboBox.TabIndex = 7;
			this.tableComboBox.ValueMember = "id";
			// 
			// tablesBindingSource
			// 
			this.tablesBindingSource.DataMember = "Tables";
			this.tablesBindingSource.DataSource = this.vHBarDataSet;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
			this.tableAdapterManager.GoodTableAdapter = this.goodTableAdapter;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.OrderStatusTableAdapter = null;
			this.tableAdapterManager.PositionTableAdapter = null;
			this.tableAdapterManager.StatusDictionaryTableAdapter = null;
			this.tableAdapterManager.TablesTableAdapter = this.tablesTableAdapter;
			this.tableAdapterManager.UpdateOrder = DataStorages.VHBarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// employeeTableAdapter
			// 
			this.employeeTableAdapter.ClearBeforeFill = true;
			// 
			// goodTableAdapter
			// 
			this.goodTableAdapter.ClearBeforeFill = true;
			// 
			// tablesTableAdapter
			// 
			this.tablesTableAdapter.ClearBeforeFill = true;
			// 
			// view_OrdersBindingSource
			// 
			this.view_OrdersBindingSource.DataMember = "View_Orders";
			this.view_OrdersBindingSource.DataSource = this.vHBarDataSet;
			// 
			// view_OrdersTableAdapter
			// 
			this.view_OrdersTableAdapter.ClearBeforeFill = true;
			// 
			// view_OrdersDataGridView
			// 
			this.view_OrdersDataGridView.AutoGenerateColumns = false;
			this.view_OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view_OrdersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.view_OrdersDataGridView.DataSource = this.view_OrdersBindingSource;
			this.view_OrdersDataGridView.Location = new System.Drawing.Point(12, 12);
			this.view_OrdersDataGridView.Name = "view_OrdersDataGridView";
			this.view_OrdersDataGridView.Size = new System.Drawing.Size(449, 337);
			this.view_OrdersDataGridView.TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "number";
			this.dataGridViewTextBoxColumn2.HeaderText = "Table number";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn3.HeaderText = "Good name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "first_name";
			this.dataGridViewTextBoxColumn4.HeaderText = "Employee";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.allTablesCheckBox);
			this.panel2.Controls.Add(this.eTextBox);
			this.panel2.Controls.Add(this.gTextBox);
			this.panel2.Controls.Add(this.tComboBox);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.discardFilterButton);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.applyFilterButton);
			this.panel2.Location = new System.Drawing.Point(467, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(163, 153);
			this.panel2.TabIndex = 13;
			// 
			// allTablesCheckBox
			// 
			this.allTablesCheckBox.AutoSize = true;
			this.allTablesCheckBox.Location = new System.Drawing.Point(85, 25);
			this.allTablesCheckBox.Name = "allTablesCheckBox";
			this.allTablesCheckBox.Size = new System.Drawing.Size(68, 17);
			this.allTablesCheckBox.TabIndex = 20;
			this.allTablesCheckBox.Text = "All tables";
			this.allTablesCheckBox.UseVisualStyleBackColor = true;
			this.allTablesCheckBox.CheckedChanged += new System.EventHandler(this.allTablesCheckBox_CheckedChanged);
			// 
			// eTextBox
			// 
			this.eTextBox.Location = new System.Drawing.Point(3, 101);
			this.eTextBox.Name = "eTextBox";
			this.eTextBox.Size = new System.Drawing.Size(155, 20);
			this.eTextBox.TabIndex = 19;
			// 
			// gTextBox
			// 
			this.gTextBox.Location = new System.Drawing.Point(3, 61);
			this.gTextBox.Name = "gTextBox";
			this.gTextBox.Size = new System.Drawing.Size(155, 20);
			this.gTextBox.TabIndex = 18;
			// 
			// tComboBox
			// 
			this.tComboBox.DataSource = this.tablesBindingSource;
			this.tComboBox.DisplayMember = "number";
			this.tComboBox.FormattingEnabled = true;
			this.tComboBox.Location = new System.Drawing.Point(3, 21);
			this.tComboBox.Name = "tComboBox";
			this.tComboBox.Size = new System.Drawing.Size(75, 21);
			this.tComboBox.TabIndex = 17;
			this.tComboBox.ValueMember = "id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(2, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Served by:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Table:";
			// 
			// discardFilterButton
			// 
			this.discardFilterButton.Location = new System.Drawing.Point(85, 123);
			this.discardFilterButton.Name = "discardFilterButton";
			this.discardFilterButton.Size = new System.Drawing.Size(75, 23);
			this.discardFilterButton.TabIndex = 10;
			this.discardFilterButton.Text = "Discard";
			this.discardFilterButton.UseVisualStyleBackColor = true;
			this.discardFilterButton.Click += new System.EventHandler(this.discardFilterButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(2, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Order:";
			// 
			// applyFilterButton
			// 
			this.applyFilterButton.Location = new System.Drawing.Point(3, 123);
			this.applyFilterButton.Name = "applyFilterButton";
			this.applyFilterButton.Size = new System.Drawing.Size(75, 23);
			this.applyFilterButton.TabIndex = 9;
			this.applyFilterButton.Text = "Apply";
			this.applyFilterButton.UseVisualStyleBackColor = true;
			this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
			// 
			// FormOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 453);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.view_OrdersDataGridView);
			this.Controls.Add(this.tableComboBox);
			this.Controls.Add(this.goodComboBox);
			this.Controls.Add(this.employeeComboBox);
			this.Controls.Add(this.panel1);
			this.Name = "FormOrders";
			this.Text = "FormOrders";
			this.Load += new System.EventHandler(this.FormOrders_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.goodBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrdersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrdersDataGridView)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.ComboBox employeeComboBox;
		private System.Windows.Forms.ComboBox goodComboBox;
		private System.Windows.Forms.ComboBox tableComboBox;
		private VHBarDataSet vHBarDataSet;
		private VHBarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private VHBarDataSetTableAdapters.GoodTableAdapter goodTableAdapter;
		private System.Windows.Forms.BindingSource goodBindingSource;
		private VHBarDataSetTableAdapters.TablesTableAdapter tablesTableAdapter;
		private System.Windows.Forms.BindingSource tablesBindingSource;
		private VHBarDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private VHBarDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
		private System.Windows.Forms.BindingSource view_OrdersBindingSource;
		private VHBarDataSetTableAdapters.View_OrdersTableAdapter view_OrdersTableAdapter;
		private System.Windows.Forms.DataGridView view_OrdersDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox tComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button discardFilterButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button applyFilterButton;
		private System.Windows.Forms.TextBox eTextBox;
		private System.Windows.Forms.TextBox gTextBox;
		private System.Windows.Forms.CheckBox allTablesCheckBox;
	}
}