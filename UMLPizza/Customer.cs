using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPizza
{
    public class Customer
    {
        private static int counter = 0;

        public int CID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer(string name, string email, string address)
        {
            counter++;
            CID = counter;
            Name = name;
            Email = email;
            Address = address;

        }

        public override string ToString()
        {
            return $"Customer ID: {CID} \nName: {Name} \nEmail: {Email} \nAddress: {Address}";
        }
    }
}
