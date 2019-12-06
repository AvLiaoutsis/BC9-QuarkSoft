using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBC9Factory
{
    class Factory
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double rawMaterial;

        public double RawMaterial
        {
            get { return rawMaterial; }
            set { rawMaterial = value; }
        }
        public List<Employee> employees;
        public Organisation owner;

        public Factory(string name,double rawmaterial)
        {
            Name =name;
            RawMaterial = rawmaterial;
        }

        void ChocolateCreation()
        {
            rawMaterial--;
        }
    }
}
