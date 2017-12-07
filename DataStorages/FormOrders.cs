using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStorages
{
	public partial class FormOrders : Form
	{
		public FormOrders()
		{
			InitializeComponent();
		}

		private void FormOrders_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_Orders". При необходимости она может быть перемещена или удалена.
			this.view_OrdersTableAdapter.Fill(this.vHBarDataSet.View_Orders);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.Employee". При необходимости она может быть перемещена или удалена.
			this.employeeTableAdapter.Fill(this.vHBarDataSet.Employee);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet._Tables". При необходимости она может быть перемещена или удалена.
			this.tablesTableAdapter.Fill(this.vHBarDataSet._Tables);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.Good". При необходимости она может быть перемещена или удалена.
			this.goodTableAdapter.Fill(this.vHBarDataSet.Good);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_Orders". При необходимости она может быть перемещена или удалена.
			
		}

		private void button_Click(object sender, EventArgs e)
		{
			//table
			DataRowView table_row;
			int table_id;
			table_row = (DataRowView)(tablesBindingSource.Current);
			table_id = (int)table_row[0];
			//good
			DataRowView good_row;
			int good_id;
			good_row = (DataRowView)(goodBindingSource.Current);
			good_id = (int)good_row[0];
			//employee
			DataRowView employee_row;
			int employee_id;
			employee_row = (DataRowView)(employeeBindingSource.Current);
			employee_id = (int)employee_row[0];
			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertOrders(table_id, good_id, employee_id);
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_OrdersBindingSource.Current);
				id = (int)row["id"];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdateOrders(id, table_id, good_id, employee_id);
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeleteOrders(id);
				}
			}
			this.view_OrdersTableAdapter.Fill(this.vHBarDataSet.View_Orders);
		}

		private void applyFilterButton_Click(object sender, EventArgs e)
		{
			String filterString = "";
			if (!allTablesCheckBox.Checked)
			{
				//table
				DataRowView table_row;
				int table_number;
				table_row = (DataRowView)(tablesBindingSource.Current);
				table_number = (int)table_row[1];
				filterString += "number = " + table_number + " and ";
			}
			if (gTextBox.Text != "")
			{
				filterString += "name like '" + gTextBox.Text + "%' and ";
			}
			if (eTextBox.Text != "")
			{
				filterString += "first_name like '" + eTextBox.Text + "%' and ";
			}
			filterString += "true";
			view_OrdersBindingSource.Filter = filterString;
		}

		private void discardFilterButton_Click(object sender, EventArgs e)
		{
			view_OrdersBindingSource.Filter = null;
		}

		private void allTablesCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			tComboBox.Enabled = tComboBox.Enabled ? false : true;
		}
	}
}
