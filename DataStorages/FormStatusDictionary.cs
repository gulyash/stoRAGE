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
	public partial class FormStatusDictionary : Form
	{
		public FormStatusDictionary()
		{
			InitializeComponent();
		}

		private void FormStatusDictionary_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_StatusDictionary". При необходимости она может быть перемещена или удалена.
			this.view_StatusDictionaryTableAdapter.Fill(this.vHBarDataSet.View_StatusDictionary);

		}

		private void button_Click(object sender, EventArgs e)
		{
			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertPosition(statusNameTextBox.Text);
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_StatusDictionaryBindingSource.Current);
				id = (int)row[0];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdateStatusDictionary(id, statusNameTextBox.Text);
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeleteStatusDictionary(id);
				}
			}
			this.view_StatusDictionaryTableAdapter.Fill(this.vHBarDataSet.View_StatusDictionary);
		}
	}
}
