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
	public partial class FormGood : Form
	{
		public FormGood()
		{
			InitializeComponent();
		}

		private void FormGood_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_Good". При необходимости она может быть перемещена или удалена.
			this.view_GoodTableAdapter.Fill(this.vHBarDataSet.View_Good);

		}

		private void button_Click(object sender, EventArgs e)
		{
			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertGood(nameTextBox.Text, Int32.Parse(priceTextBox.Text), forAdultsCheckBox.Checked);
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_GoodBindingSource.Current);
				id = (int)row[0];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdateGood(id, nameTextBox.Text, Int32.Parse(priceTextBox.Text), forAdultsCheckBox.Checked);
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeleteGood(id);
				}
			}
			this.view_GoodTableAdapter.Fill(this.vHBarDataSet.View_Good);
		}

		private void applyFilterButton_Click(object sender, EventArgs e)
		{
			String filterString = "";
			if (nTextBox.Text!="")
			{
				filterString += "name like '" + nTextBox.Text + "%' and ";
			}
			if (maxPriceTextBox.Text != "") {
				filterString += "price <= " + maxPriceTextBox.Text + " and ";
			}
			if (underageCheckBox.Checked)
			{
				filterString += "for_adults = false and ";
			}
			filterString += "true";
			view_GoodBindingSource.Filter = filterString;
		}

		private void discardFilterButton_Click(object sender, EventArgs e)
		{
			view_GoodBindingSource.Filter = null;
		}
	}
}
