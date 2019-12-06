using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBC9Factory
{
    class Store
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Chocolate> chocolates;
        public List<Employee> Employees;
        public Organisation Owner;
        public Store(string name)
        {
            Name = name;
        }

        void SellChocolate(string chocolatename,int quantity)
        {

        }
    }
}
