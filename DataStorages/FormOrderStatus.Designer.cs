namespace DataStorages
{
	partial class FormOrderStatus
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderStatus));
			this.vHBarDataSet = new DataStorages.VHBarDataSet();
			this.view_OrderStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_OrderStatusTableAdapter = new DataStorages.VHBarDataSetTableAdapters.View_OrderStatusTableAdapter();
			this.tableAdapterManager = new DataStorages.VHBarDataSetTableAdapters.TableAdapterManager();
			this.ordersTableAdapter = new DataStorages.VHBarDataSetTableAdapters.OrdersTableAdapter();
			this.statusDictionaryTableAdapter = new DataStorages.VHBarDataSetTableAdapters.StatusDictionaryTableAdapter();
			this.view_OrderStatusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.view_OrderStatusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.view_OrderStatusDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.statusDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.queriesTableAdapter1 = new DataStorages.VHBarDataSetTableAdapters.QueriesTableAdapter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.discardFilterButton = new System.Windows.Forms.Button();
			this.applyFilterButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.statusComboBox = new System.Windows.Forms.ComboBox();
			this.orderComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrderStatusBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrderStatusBindingNavigator)).BeginInit();
			this.view_OrderStatusBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_OrderStatusDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusDictionaryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// vHBarDataSet
			// 
			this.vHBarDataSet.DataSetName = "VHBarDataSet";
			this.vHBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view_OrderStatusBindingSource
			// 
			this.view_OrderStatusBindingSource.DataMember = "View_OrderStatus";
			this.view_OrderStatusBindingSource.DataSource = this.vHBarDataSet;
			// 
			// view_OrderStatusTableAdapter
			// 
			this.view_OrderStatusTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.EmployeeTableAdapter = null;
			this.tableAdapterManager.GoodTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
			this.tableAdapterManager.OrderStatusTableAdapter = null;
			this.tableAdapterManager.PositionTableAdapter = null;
			this.tableAdapterManager.StatusDictionaryTableAdapter = this.statusDictionaryTableAdapter;
			this.tableAdapterManager.TablesTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DataStorages.VHBarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// ordersTableAdapter
			// 
			this.ordersTableAdapter.ClearBeforeFill = true;
			// 
			// statusDictionaryTableAdapter
			// 
			this.statusDictionaryTableAdapter.ClearBeforeFill = true;
			// 
			// view_OrderStatusBindingNavigator
			// 
			this.view_OrderStatusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.view_OrderStatusBindingNavigator.BindingSource = this.view_OrderStatusBindingSource;
			this.view_OrderStatusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.view_OrderStatusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.view_OrderStatusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_OrderStatusBindingNavigatorSaveItem});
			this.view_OrderStatusBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.view_OrderStatusBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.view_OrderStatusBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.view_OrderStatusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.view_OrderStatusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.view_OrderStatusBindingNavigator.Name = "view_OrderStatusBindingNavigator";
			this.view_OrderStatusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.view_OrderStatusBindingNavigator.Size = new System.Drawing.Size(632, 25);
			this.view_OrderStatusBindingNavigator.TabIndex = 0;
			this.view_OrderStatusBindingNavigator.Text = "bindingNavigator1";
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
			// view_OrderStatusBindingNavigatorSaveItem
			// 
			this.view_OrderStatusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.view_OrderStatusBindingNavigatorSaveItem.Enabled = false;
			this.view_OrderStatusBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_OrderStatusBindingNavigatorSaveItem.Image")));
			this.view_OrderStatusBindingNavigatorSaveItem.Name = "view_OrderStatusBindingNavigatorSaveItem";
			this.view_OrderStatusBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.view_OrderStatusBindingNavigatorSaveItem.Text = "Сохранить данные";
			// 
			// view_OrderStatusDataGridView
			// 
			this.view_OrderStatusDataGridView.AutoGenerateColumns = false;
			this.view_OrderStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view_OrderStatusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
			this.view_OrderStatusDataGridView.DataSource = this.view_OrderStatusBindingSource;
			this.view_OrderStatusDataGridView.Location = new System.Drawing.Point(6, 24);
			this.view_OrderStatusDataGridView.Name = "view_OrderStatusDataGridView";
			this.view_OrderStatusDataGridView.Size = new System.Drawing.Size(449, 220);
			this.view_OrderStatusDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "id_order";
			this.dataGridViewTextBoxColumn4.HeaderText = "order_id";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "status_name";
			this.dataGridViewTextBoxColumn3.HeaderText = "status_name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "order_time";
			this.dataGridViewTextBoxColumn2.HeaderText = "order_time";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Controls.Add(this.buttonUpdate);
			this.panel1.Controls.Add(this.buttonInsert);
			this.panel1.Location = new System.Drawing.Point(12, 250);
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
			// comboBox1
			// 
			this.comboBox1.DataSource = this.statusDictionaryBindingSource;
			this.comboBox1.DisplayMember = "status_name";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(248, 250);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 5;
			this.comboBox1.ValueMember = "id";
			// 
			// statusDictionaryBindingSource
			// 
			this.statusDictionaryBindingSource.DataMember = "StatusDictionary";
			this.statusDictionaryBindingSource.DataSource = this.vHBarDataSet;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.ordersBindingSource;
			this.comboBox2.DisplayMember = "id";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(121, 250);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 6;
			this.comboBox2.ValueMember = "id";
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this.vHBarDataSet;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.orderComboBox);
			this.panel2.Controls.Add(this.statusComboBox);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.discardFilterButton);
			this.panel2.Controls.Add(this.applyFilterButton);
			this.panel2.Location = new System.Drawing.Point(461, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(163, 119);
			this.panel2.TabIndex = 14;
			// 
			// discardFilterButton
			// 
			this.discardFilterButton.Location = new System.Drawing.Point(85, 88);
			this.discardFilterButton.Name = "discardFilterButton";
			this.discardFilterButton.Size = new System.Drawing.Size(75, 23);
			this.discardFilterButton.TabIndex = 10;
			this.discardFilterButton.Text = "Discard";
			this.discardFilterButton.UseVisualStyleBackColor = true;
			// 
			// applyFilterButton
			// 
			this.applyFilterButton.Location = new System.Drawing.Point(3, 88);
			this.applyFilterButton.Name = "applyFilterButton";
			this.applyFilterButton.Size = new System.Drawing.Size(75, 23);
			this.applyFilterButton.TabIndex = 9;
			this.applyFilterButton.Text = "Apply";
			this.applyFilterButton.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Status:";
			// 
			// statusComboBox
			// 
			this.statusComboBox.DisplayMember = "number";
			this.statusComboBox.FormattingEnabled = true;
			this.statusComboBox.Location = new System.Drawing.Point(3, 21);
			this.statusComboBox.Name = "statusComboBox";
			this.statusComboBox.Size = new System.Drawing.Size(157, 21);
			this.statusComboBox.TabIndex = 17;
			this.statusComboBox.ValueMember = "id";
			// 
			// orderComboBox
			// 
			this.orderComboBox.DisplayMember = "number";
			this.orderComboBox.FormattingEnabled = true;
			this.orderComboBox.Location = new System.Drawing.Point(3, 61);
			this.orderComboBox.Name = "orderComboBox";
			this.orderComboBox.Size = new System.Drawing.Size(157, 21);
			this.orderComboBox.TabIndex = 18;
			this.orderComboBox.ValueMember = "id";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Order:";
			// 
			// FormOrderStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 348);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.view_OrderStatusDataGridView);
			this.Controls.Add(this.view_OrderStatusBindingNavigator);
			this.Name = "FormOrderStatus";
			this.Text = "FormOrderStatus";
			this.Load += new System.EventHandler(this.FormOrderStatus_Load);
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrderStatusBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_OrderStatusBindingNavigator)).EndInit();
			this.view_OrderStatusBindingNavigator.ResumeLayout(false);
			this.view_OrderStatusBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_OrderStatusDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusDictionaryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VHBarDataSet vHBarDataSet;
		private System.Windows.Forms.BindingSource view_OrderStatusBindingSource;
		private VHBarDataSetTableAdapters.View_OrderStatusTableAdapter view_OrderStatusTableAdapter;
		private VHBarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator view_OrderStatusBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton view_OrderStatusBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView view_OrderStatusDataGridView;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonInsert;
		private VHBarDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.BindingSource ordersBindingSource;
		private VHBarDataSetTableAdapters.StatusDictionaryTableAdapter statusDictionaryTableAdapter;
		private System.Windows.Forms.BindingSource statusDictionaryBindingSource;
		private VHBarDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox orderComboBox;
		private System.Windows.Forms.ComboBox statusComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button discardFilterButton;
		private System.Windows.Forms.Button applyFilterButton;
	}
}