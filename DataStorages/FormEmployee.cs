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
	public partial class FormEmployee : Form
	{
		public FormEmployee()
		{
			InitializeComponent();
		}

		private void FormEmployee_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.Position". При необходимости она может быть перемещена или удалена.
			this.positionTableAdapter.Fill(this.vHBarDataSet.Position);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_Employee". При необходимости она может быть перемещена или удалена.
			this.view_EmployeeTableAdapter.Fill(this.vHBarDataSet.View_Employee);

		}

		private void button_Click(object sender, EventArgs e)
		{
			DataRowView pos_row;
			int pos_id;
			pos_row = (DataRowView)(positionBindingSource.Current);
			pos_id = (int)pos_row[0];
			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertEmployee(firstNameTextBox.Text, pos_id, phoneTextBox.Text);
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_EmployeeBindingSource.Current);
				id = (int)row["id"];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdateEmployee(id, firstNameTextBox.Text, pos_id, phoneTextBox.Text);
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeleteEmployee(id);
				}
			}
			this.view_EmployeeTableAdapter.Fill(this.vHBarDataSet.View_Employee);
		}

		private void applyFilterButton_Click(object sender, EventArgs e)
		{
			String filterString = "";
			if (nTextBox.Text != "")
			{
				filterString += "first_name like '" + nTextBox.Text + "%' and ";
			}
			if (posTextBox.Text != "")
			{
				filterString += "position like '" + posTextBox.Text + "%' and ";
			}
			if (phTextBox.Text != "")
			{
				filterString += "phone like '" + phTextBox.Text + "%' and ";
			}
			filterString += "true";
			view_EmployeeBindingSource.Filter = filterString;
		}
		private void discardFilterButton_Click(object sender, EventArgs e)
		{
			view_EmployeeBindingSource.Filter = null;
		}
	}
}
