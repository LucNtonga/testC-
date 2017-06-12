using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
	public partial class EmployeeForm : Form
	{
		public EmployeeForm()
		{
			InitializeComponent();
		}

		private void EmployeeForm_Load(object sender, EventArgs e)
		{
			DateTime birthday = new DateTime(1999,5,1);
			Employee spongebob = new Employee("SpongeBob", birthday, 10.5m, "Burger Flipper");
			lblEmployee.Text = spongebob.ToString();

		}
	}
}
