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
	public partial class FormOrderStatus : Form
	{
		public FormOrderStatus()
		{
			InitializeComponent();
		}

		private void FormOrderStatus_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.StatusDictionary". При необходимости она может быть перемещена или удалена.
			this.statusDictionaryTableAdapter.Fill(this.vHBarDataSet.StatusDictionary);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.Orders". При необходимости она может быть перемещена или удалена.
			this.ordersTableAdapter.Fill(this.vHBarDataSet.Orders);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "vHBarDataSet.View_OrderStatus". При необходимости она может быть перемещена или удалена.
			this.view_OrderStatusTableAdapter.Fill(this.vHBarDataSet.View_OrderStatus);

		}

		private void button_Click(object sender, EventArgs e)
		{
			//order
			DataRowView order_row;
			int order_id;
			order_row = (DataRowView)(ordersBindingSource.Current);
			order_id = (int)order_row[0];

			//status_name
			DataRowView status_row;
			int status_id;
			status_row = (DataRowView)(statusDictionaryBindingSource.Current);
			status_id = (int)status_row[0];

			// insert position button
			if (sender.Equals(buttonInsert))
			{
				this.queriesTableAdapter1.InsertOrderStatus(order_id, status_id);
			}
			else
			{
				// if we are updating or deleting a row, we should know its ID
				DataRowView row;
				int id;
				row = (DataRowView)(view_OrderStatusBindingSource.Current);
				id = (int)row["id"];
				// then we check which operation we need:
				//update
				if (sender.Equals(buttonUpdate))
				{
					this.queriesTableAdapter1.UpdateOrderStatus(id, order_id, status_id);
				}
				// or delete
				else if (sender.Equals(buttonDelete))
				{
					this.queriesTableAdapter1.DeleteOrderStatus(id);
				}
			}
			this.view_OrderStatusTableAdapter.Fill(this.vHBarDataSet.View_OrderStatus);
		}
	}
}
