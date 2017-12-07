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
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			Form newForm;
			switch (e.ClickedItem.Text)
			{
				case "Good":
					newForm = new FormGood();
					break;
				case "Order":
					newForm = new FormOrders();
					break;
				case "OrderStatus":
					newForm = new FormOrderStatus();
					break;
				case "Position":
					newForm = new FormPosition();
					break;
				case "StatusDictionary":
					newForm = new FormStatusDictionary();
					break;
				case "Table":
					newForm = new FormTable();
					break;
				default:
					newForm = new FormEmployee();
					break;
			}
			newForm.Show();
		}
	}
}
