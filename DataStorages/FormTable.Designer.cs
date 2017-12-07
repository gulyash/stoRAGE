namespace DataStorages
{
	partial class FormTable
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
			this.vHBarDataSet = new DataStorages.VHBarDataSet();
			this.view_TablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_TablesTableAdapter = new DataStorages.VHBarDataSetTableAdapters.View_TablesTableAdapter();
			this.tableAdapterManager = new DataStorages.VHBarDataSetTableAdapters.TableAdapterManager();
			this.view_TablesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.view_TablesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.view_TablesDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.queriesTableAdapter1 = new DataStorages.VHBarDataSetTableAdapters.QueriesTableAdapter();
			this.seatsTextBox = new System.Windows.Forms.TextBox();
			this.numberTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_TablesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_TablesBindingNavigator)).BeginInit();
			this.view_TablesBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_TablesDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// vHBarDataSet
			// 
			this.vHBarDataSet.DataSetName = "VHBarDataSet";
			this.vHBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view_TablesBindingSource
			// 
			this.view_TablesBindingSource.DataMember = "View_Tables";
			this.view_TablesBindingSource.DataSource = this.vHBarDataSet;
			// 
			// view_TablesTableAdapter
			// 
			this.view_TablesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.EmployeeTableAdapter = null;
			this.tableAdapterManager.GoodTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.OrderStatusTableAdapter = null;
			this.tableAdapterManager.PositionTableAdapter = null;
			this.tableAdapterManager.StatusDictionaryTableAdapter = null;
			this.tableAdapterManager.TablesTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = DataStorages.VHBarDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// view_TablesBindingNavigator
			// 
			this.view_TablesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.view_TablesBindingNavigator.BindingSource = this.view_TablesBindingSource;
			this.view_TablesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.view_TablesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.view_TablesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_TablesBindingNavigatorSaveItem});
			this.view_TablesBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.view_TablesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.view_TablesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.view_TablesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.view_TablesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.view_TablesBindingNavigator.Name = "view_TablesBindingNavigator";
			this.view_TablesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.view_TablesBindingNavigator.Size = new System.Drawing.Size(451, 25);
			this.view_TablesBindingNavigator.TabIndex = 0;
			this.view_TablesBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// view_TablesBindingNavigatorSaveItem
			// 
			this.view_TablesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.view_TablesBindingNavigatorSaveItem.Enabled = false;
			this.view_TablesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_TablesBindingNavigatorSaveItem.Image")));
			this.view_TablesBindingNavigatorSaveItem.Name = "view_TablesBindingNavigatorSaveItem";
			this.view_TablesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.view_TablesBindingNavigatorSaveItem.Text = "Сохранить данные";
			// 
			// view_TablesDataGridView
			// 
			this.view_TablesDataGridView.AutoGenerateColumns = false;
			this.view_TablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view_TablesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.view_TablesDataGridView.DataSource = this.view_TablesBindingSource;
			this.view_TablesDataGridView.Location = new System.Drawing.Point(0, 28);
			this.view_TablesDataGridView.Name = "view_TablesDataGridView";
			this.view_TablesDataGridView.Size = new System.Drawing.Size(347, 220);
			this.view_TablesDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "number";
			this.dataGridViewTextBoxColumn2.HeaderText = "number";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "seats";
			this.dataGridViewTextBoxColumn3.HeaderText = "seats";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Controls.Add(this.buttonUpdate);
			this.panel1.Controls.Add(this.buttonInsert);
			this.panel1.Location = new System.Drawing.Point(353, 28);
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
			// seatsTextBox
			// 
			this.seatsTextBox.Location = new System.Drawing.Point(246, 255);
			this.seatsTextBox.Name = "seatsTextBox";
			this.seatsTextBox.Size = new System.Drawing.Size(100, 20);
			this.seatsTextBox.TabIndex = 4;
			// 
			// numberTextBox
			// 
			this.numberTextBox.Location = new System.Drawing.Point(140, 255);
			this.numberTextBox.Name = "numberTextBox";
			this.numberTextBox.Size = new System.Drawing.Size(100, 20);
			this.numberTextBox.TabIndex = 5;
			// 
			// FormTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 323);
			this.Controls.Add(this.numberTextBox);
			this.Controls.Add(this.seatsTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.view_TablesDataGridView);
			this.Controls.Add(this.view_TablesBindingNavigator);
			this.Name = "FormTable";
			this.Text = "FormTable";
			this.Load += new System.EventHandler(this.FormTable_Load);
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_TablesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_TablesBindingNavigator)).EndInit();
			this.view_TablesBindingNavigator.ResumeLayout(false);
			this.view_TablesBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_TablesDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VHBarDataSet vHBarDataSet;
		private System.Windows.Forms.BindingSource view_TablesBindingSource;
		private VHBarDataSetTableAdapters.View_TablesTableAdapter view_TablesTableAdapter;
		private VHBarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator view_TablesBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton view_TablesBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView view_TablesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonInsert;
		private VHBarDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
		private System.Windows.Forms.TextBox seatsTextBox;
		private System.Windows.Forms.TextBox numberTextBox;
	}
}