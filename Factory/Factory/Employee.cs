using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBC9Factory
{
    class Employee
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string sirName;

		public string SirName
		{
			get { return sirName; }
			set { sirName = value; }
		}
		public Employee(string name,string sirname)
		{
			Name = name;
			SirName = sirname;
		}
	}
}
