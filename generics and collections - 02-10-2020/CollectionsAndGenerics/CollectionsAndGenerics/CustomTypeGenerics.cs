using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsAndGenerics
{
    class CustomTypeGenerics
    {
        public void CustomTypeGenericsMethod() 
        {
            List<Customer> listOfcustomers = new List<Customer>();
            Customer c1 = new Customer() { CustId = 123, CustName = "Messi" };
            Customer c2 = new Customer() { CustId = 321, CustName = "Neymer" };

            listOfcustomers.Add(c1);
            listOfcustomers.Add(c2);

            foreach (Customer cust in listOfcustomers)
            {
                Console.WriteLine(cust.CustId + "  " + cust.CustName);
            }
        }
    }
    public class Customer
    {
        public int CustId { get; set; }
        public string CustName { get; set; }
    }
}

