namespace DataStorages
{
	partial class FormEmployee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
			this.vHBarDataSet = new DataStorages.VHBarDataSet();
			this.view_EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_EmployeeTableAdapter = new DataStorages.VHBarDataSetTableAdapters.View_EmployeeTableAdapter();
			this.tableAdapterManager = new DataStorages.VHBarDataSetTableAdapters.TableAdapterManager();
			this.positionTableAdapter = new DataStorages.VHBarDataSetTableAdapters.PositionTableAdapter();
			this.view_EmployeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.view_EmployeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.view_EmployeeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.positionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.queriesTableAdapter1 = new DataStorages.VHBarDataSetTableAdapters.QueriesTableAdapter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.phTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.nTextBox = new System.Windows.Forms.TextBox();
			this.posTextBox = new System.Windows.Forms.TextBox();
			this.discardFilterButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.applyFilterButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_EmployeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_EmployeeBindingNavigator)).BeginInit();
			this.view_EmployeeBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_EmployeeDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// vHBarDataSet
			// 
			this.vHBarDataSet.DataSetName = "VHBarDataSet";
			this.vHBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view_EmployeeBindingSource
			// 
			this.view_EmployeeBindingSource.DataMember = "View_Employee";
			this.view_EmployeeBindingSource.DataSource = this.vHBarDataSet;
			// 
			// view_EmployeeTableAdapter
			// 
			this.view_EmployeeTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeeTableAdapter = null;
			this.tableAdapterManager.GoodTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.OrderStatusTableAdapter = null;
			this.tableAdapterManager.PositionTableAdapter = this.positionTableAdapter;
			this.tableAdapterManager.StatusDictionaryTableAdapter = null;
			this.tableAdapterManager.TablesTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DataStorages.VHBarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// positionTableAdapter
			// 
			this.positionTableAdapter.ClearBeforeFill = true;
			// 
			// view_EmployeeBindingNavigator
			// 
			this.view_EmployeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.view_EmployeeBindingNavigator.BindingSource = this.view_EmployeeBindingSource;
			this.view_EmployeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.view_EmployeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.view_EmployeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.view_EmployeeBindingNavigatorSaveItem});
			this.view_EmployeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.view_EmployeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.view_EmployeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.view_EmployeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.view_EmployeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.view_EmployeeBindingNavigator.Name = "view_EmployeeBindingNavigator";
			this.view_EmployeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.view_EmployeeBindingNavigator.Size = new System.Drawing.Size(634, 25);
			this.view_EmployeeBindingNavigator.TabIndex = 0;
			this.view_EmployeeBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// view_EmployeeBindingNavigatorSaveItem
			// 
			this.view_EmployeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.view_EmployeeBindingNavigatorSaveItem.Enabled = false;
			this.view_EmployeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_EmployeeBindingNavigatorSaveItem.Image")));
			this.view_EmployeeBindingNavigatorSaveItem.Name = "view_EmployeeBindingNavigatorSaveItem";
			this.view_EmployeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.view_EmployeeBindingNavigatorSaveItem.Text = "Сохранить данные";
			// 
			// view_EmployeeDataGridView
			// 
			this.view_EmployeeDataGridView.AutoGenerateColumns = false;
			this.view_EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view_EmployeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
			this.view_EmployeeDataGridView.DataSource = this.view_EmployeeBindingSource;
			this.view_EmployeeDataGridView.Location = new System.Drawing.Point(0, 28);
			this.view_EmployeeDataGridView.Name = "view_EmployeeDataGridView";
			this.view_EmployeeDataGridView.Size = new System.Drawing.Size(445, 220);
			this.view_EmployeeDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn3.HeaderText = "id";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "first_name";
			this.dataGridViewTextBoxColumn1.HeaderText = "first_name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "position";
			this.dataGridViewTextBoxColumn4.HeaderText = "position";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "phone";
			this.dataGridViewTextBoxColumn2.HeaderText = "phone";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Controls.Add(this.buttonUpdate);
			this.panel1.Controls.Add(this.buttonInsert);
			this.panel1.Location = new System.Drawing.Point(12, 255);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(84, 93);
			this.panel1.TabIndex = 3;
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
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(344, 255);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.phoneTextBox.TabIndex = 4;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(111, 255);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.firstNameTextBox.TabIndex = 6;
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.positionBindingSource;
			this.comboBox1.DisplayMember = "position";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(217, 255);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.ValueMember = "id";
			// 
			// positionBindingSource
			// 
			this.positionBindingSource.DataMember = "Position";
			this.positionBindingSource.DataSource = this.vHBarDataSet;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.phTextBox);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.nTextBox);
			this.panel2.Controls.Add(this.posTextBox);
			this.panel2.Controls.Add(this.discardFilterButton);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.applyFilterButton);
			this.panel2.Location = new System.Drawing.Point(451, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(163, 163);
			this.panel2.TabIndex = 12;
			// 
			// phTextBox
			// 
			this.phTextBox.Location = new System.Drawing.Point(4, 108);
			this.phTextBox.Name = "phTextBox";
			this.phTextBox.Size = new System.Drawing.Size(155, 20);
			this.phTextBox.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Phone:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Look for:";
			// 
			// nTextBox
			// 
			this.nTextBox.Location = new System.Drawing.Point(4, 20);
			this.nTextBox.Name = "nTextBox";
			this.nTextBox.Size = new System.Drawing.Size(155, 20);
			this.nTextBox.TabIndex = 13;
			// 
			// posTextBox
			// 
			this.posTextBox.Location = new System.Drawing.Point(4, 59);
			this.posTextBox.Name = "posTextBox";
			this.posTextBox.Size = new System.Drawing.Size(155, 20);
			this.posTextBox.TabIndex = 8;
			// 
			// discardFilterButton
			// 
			this.discardFilterButton.Location = new System.Drawing.Point(85, 134);
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
			this.label1.Location = new System.Drawing.Point(3, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Position:";
			// 
			// applyFilterButton
			// 
			this.applyFilterButton.Location = new System.Drawing.Point(3, 134);
			this.applyFilterButton.Name = "applyFilterButton";
			this.applyFilterButton.Size = new System.Drawing.Size(75, 23);
			this.applyFilterButton.TabIndex = 9;
			this.applyFilterButton.Text = "Apply";
			this.applyFilterButton.UseVisualStyleBackColor = true;
			this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
			// 
			// FormEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 376);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.view_EmployeeDataGridView);
			this.Controls.Add(this.view_EmployeeBindingNavigator);
			this.Name = "FormEmployee";
			this.Text = "FormEmployee";
			this.Load += new System.EventHandler(this.FormEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_EmployeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_EmployeeBindingNavigator)).EndInit();
			this.view_EmployeeBindingNavigator.ResumeLayout(false);
			this.view_EmployeeBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_EmployeeDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.positionBindingSource)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VHBarDataSet vHBarDataSet;
		private System.Windows.Forms.BindingSource view_EmployeeBindingSource;
		private VHBarDataSetTableAdapters.View_EmployeeTableAdapter view_EmployeeTableAdapter;
		private VHBarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator view_EmployeeBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton view_EmployeeBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView view_EmployeeDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private VHBarDataSetTableAdapters.PositionTableAdapter positionTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.BindingSource positionBindingSource;
		private VHBarDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nTextBox;
		private System.Windows.Forms.TextBox posTextBox;
		private System.Windows.Forms.Button discardFilterButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button applyFilterButton;
		private System.Windows.Forms.TextBox phTextBox;
		private System.Windows.Forms.Label label3;
	}
}