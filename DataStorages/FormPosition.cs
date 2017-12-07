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
	public partial class FormPosition : Form
	{
		public FormPosition()
		{
			InitializeComponent();
		}

		private void FormPosition_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_Position". При необходимости она может быть перемещена или удалена.
			this.view_PositionTableAdapter.Fill(this.vHBarDataSet.View_Position);

		}

		private void button_Click(object sender, EventArgs e)
		{
			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertPosition(positionTextBox.Text);
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_PositionBindingSource.Current);
				id = (int)row[0];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdatePosition(id, positionTextBox.Text);
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeletePosition(id);
				}
			}
			this.view_PositionTableAdapter.Fill(this.vHBarDataSet.View_Position);
		}
	}
}
