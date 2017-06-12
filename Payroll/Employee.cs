using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
	class Employee
	{
		private string name;
		private DateTime birthday;
		private decimal hourlySalary;
		private string jobTitle;
		private decimal taxRate;

		public Employee(string name, DateTime birthday, decimal hourlySalary, string jobTitle)
		{
			this.name = name;
			this.birthday = birthday;
			this.hourlySalary = hourlySalary;
			this.jobTitle = jobTitle;
			this.taxRate = 0.25m;
		}

		public override string ToString()
		{
			return string.Format("Name:{0}, Birthday:{1:d}, Hourly Salary: {2:c}, Job Title:{3}", name, birthday, hourlySalary, jobTitle);
		}
	}
}
