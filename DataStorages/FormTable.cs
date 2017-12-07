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
	public partial class FormTable : Form
	{
		public FormTable()
		{
			InitializeComponent();
		}

		private void FormTable_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_Tables". При необходимости она может быть перемещена или удалена.
			this.view_TablesTableAdapter.Fill(this.vHBarDataSet.View_Tables);

		}

		private void button_Click(object sender, EventArgs e)
		{
			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertTables(Int32.Parse(numberTextBox.Text), Int32.Parse(seatsTextBox.Text));
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_TablesBindingSource.Current);
				id = (int)row[0];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdateTables(id, Int32.Parse(numberTextBox.Text), Int32.Parse(seatsTextBox.Text));
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeleteTables(id);
				}
			}
			this.view_TablesTableAdapter.Fill(this.vHBarDataSet.View_Tables);
		}
	}
}
