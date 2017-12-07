namespace DataStorages
{
	partial class FormGood
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGood));
			this.vHBarDataSet = new DataStorages.VHBarDataSet();
			this.view_GoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.view_GoodTableAdapter = new DataStorages.VHBarDataSetTableAdapters.View_GoodTableAdapter();
			this.tableAdapterManager = new DataStorages.VHBarDataSetTableAdapters.TableAdapterManager();
			this.view_GoodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.view_GoodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.view_GoodDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.forAdultsCheckBox = new System.Windows.Forms.CheckBox();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.queriesTableAdapter1 = new DataStorages.VHBarDataSetTableAdapters.QueriesTableAdapter();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.maxPriceTextBox = new System.Windows.Forms.TextBox();
			this.applyFilterButton = new System.Windows.Forms.Button();
			this.discardFilterButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.nTextBox = new System.Windows.Forms.TextBox();
			this.underageCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_GoodBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.view_GoodBindingNavigator)).BeginInit();
			this.view_GoodBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_GoodDataGridView)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// vHBarDataSet
			// 
			this.vHBarDataSet.DataSetName = "VHBarDataSet";
			this.vHBarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// view_GoodBindingSource
			// 
			this.view_GoodBindingSource.DataMember = "View_Good";
			this.view_GoodBindingSource.DataSource = this.vHBarDataSet;
			// 
			// view_GoodTableAdapter
			// 
			this.view_GoodTableAdapter.ClearBeforeFill = true;
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
			// view_GoodBindingNavigator
			// 
			this.view_GoodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.view_GoodBindingNavigator.BindingSource = this.view_GoodBindingSource;
			this.view_GoodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.view_GoodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.view_GoodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.view_GoodBindingNavigatorSaveItem});
			this.view_GoodBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.view_GoodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.view_GoodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.view_GoodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.view_GoodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.view_GoodBindingNavigator.Name = "view_GoodBindingNavigator";
			this.view_GoodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.view_GoodBindingNavigator.Size = new System.Drawing.Size(658, 25);
			this.view_GoodBindingNavigator.TabIndex = 0;
			this.view_GoodBindingNavigator.Text = "bindingNavigator1";
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
			// view_GoodBindingNavigatorSaveItem
			// 
			this.view_GoodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.view_GoodBindingNavigatorSaveItem.Enabled = false;
			this.view_GoodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("view_GoodBindingNavigatorSaveItem.Image")));
			this.view_GoodBindingNavigatorSaveItem.Name = "view_GoodBindingNavigatorSaveItem";
			this.view_GoodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.view_GoodBindingNavigatorSaveItem.Text = "Сохранить данные";
			// 
			// view_GoodDataGridView
			// 
			this.view_GoodDataGridView.AutoGenerateColumns = false;
			this.view_GoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.view_GoodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
			this.view_GoodDataGridView.DataSource = this.view_GoodBindingSource;
			this.view_GoodDataGridView.Location = new System.Drawing.Point(0, 28);
			this.view_GoodDataGridView.Name = "view_GoodDataGridView";
			this.view_GoodDataGridView.Size = new System.Drawing.Size(457, 220);
			this.view_GoodDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn2.HeaderText = "name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
			this.dataGridViewTextBoxColumn3.HeaderText = "price";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "for_adults";
			this.dataGridViewCheckBoxColumn1.HeaderText = "for_adults";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Controls.Add(this.buttonUpdate);
			this.panel1.Controls.Add(this.buttonInsert);
			this.panel1.Location = new System.Drawing.Point(463, 182);
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
			// forAdultsCheckBox
			// 
			this.forAdultsCheckBox.AutoSize = true;
			this.forAdultsCheckBox.Location = new System.Drawing.Point(376, 255);
			this.forAdultsCheckBox.Name = "forAdultsCheckBox";
			this.forAdultsCheckBox.Size = new System.Drawing.Size(69, 17);
			this.forAdultsCheckBox.TabIndex = 4;
			this.forAdultsCheckBox.Text = "for adults";
			this.forAdultsCheckBox.UseVisualStyleBackColor = true;
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(270, 255);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(100, 20);
			this.priceTextBox.TabIndex = 5;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(164, 255);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(100, 20);
			this.nameTextBox.TabIndex = 6;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Max Price:";
			// 
			// maxPriceTextBox
			// 
			this.maxPriceTextBox.Location = new System.Drawing.Point(4, 59);
			this.maxPriceTextBox.Name = "maxPriceTextBox";
			this.maxPriceTextBox.Size = new System.Drawing.Size(155, 20);
			this.maxPriceTextBox.TabIndex = 8;
			// 
			// applyFilterButton
			// 
			this.applyFilterButton.Location = new System.Drawing.Point(3, 108);
			this.applyFilterButton.Name = "applyFilterButton";
			this.applyFilterButton.Size = new System.Drawing.Size(75, 23);
			this.applyFilterButton.TabIndex = 9;
			this.applyFilterButton.Text = "Apply";
			this.applyFilterButton.UseVisualStyleBackColor = true;
			this.applyFilterButton.Click += new System.EventHandler(this.applyFilterButton_Click);
			// 
			// discardFilterButton
			// 
			this.discardFilterButton.Location = new System.Drawing.Point(85, 108);
			this.discardFilterButton.Name = "discardFilterButton";
			this.discardFilterButton.Size = new System.Drawing.Size(75, 23);
			this.discardFilterButton.TabIndex = 10;
			this.discardFilterButton.Text = "Discard";
			this.discardFilterButton.UseVisualStyleBackColor = true;
			this.discardFilterButton.Click += new System.EventHandler(this.discardFilterButton_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.nTextBox);
			this.panel2.Controls.Add(this.underageCheckBox);
			this.panel2.Controls.Add(this.maxPriceTextBox);
			this.panel2.Controls.Add(this.discardFilterButton);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.applyFilterButton);
			this.panel2.Location = new System.Drawing.Point(463, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(163, 136);
			this.panel2.TabIndex = 11;
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
			// underageCheckBox
			// 
			this.underageCheckBox.AutoSize = true;
			this.underageCheckBox.Location = new System.Drawing.Point(4, 85);
			this.underageCheckBox.Name = "underageCheckBox";
			this.underageCheckBox.Size = new System.Drawing.Size(103, 17);
			this.underageCheckBox.TabIndex = 12;
			this.underageCheckBox.Text = "Underage Menu";
			this.underageCheckBox.UseVisualStyleBackColor = true;
			// 
			// FormGood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 289);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.forAdultsCheckBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.view_GoodDataGridView);
			this.Controls.Add(this.view_GoodBindingNavigator);
			this.Name = "FormGood";
			this.Text = "FormGood";
			this.Load += new System.EventHandler(this.FormGood_Load);
			((System.ComponentModel.ISupportInitialize)(this.vHBarDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_GoodBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.view_GoodBindingNavigator)).EndInit();
			this.view_GoodBindingNavigator.ResumeLayout(false);
			this.view_GoodBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.view_GoodDataGridView)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private VHBarDataSet vHBarDataSet;
		private System.Windows.Forms.BindingSource view_GoodBindingSource;
		private VHBarDataSetTableAdapters.View_GoodTableAdapter view_GoodTableAdapter;
		private VHBarDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator view_GoodBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton view_GoodBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView view_GoodDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.CheckBox forAdultsCheckBox;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private VHBarDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox maxPriceTextBox;
		private System.Windows.Forms.Button applyFilterButton;
		private System.Windows.Forms.Button discardFilterButton;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nTextBox;
		private System.Windows.Forms.CheckBox underageCheckBox;
	}
}