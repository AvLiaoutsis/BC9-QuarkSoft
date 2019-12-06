using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBC9Factory
{
    class Organisation
    {
        public List<Factory> factories;
        public List<Store> stores;
        public Contract contract;

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double moneyBalance;
        public double MoneyBalance
        {
            get { return moneyBalance; }
            set { moneyBalance = value; }
        }
        public Organisation(string name,double moneybalance)
        {
            Name = name;
            MoneyBalance = moneybalance;
        }
        public void NewOrder(Factory factoryRelated)
        {
           // factoryRelated.RawMaterial +=
            MoneyBalance--;
        }
        public void NewOrder(Store storeRelate)
        {
           // storeRelate.chocolates.Add();
           
        }
        public void EvaluateOffers(List<Offer> offers)
        {
           
        }
    }
}
