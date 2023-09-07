using StarbucksandNeroProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksandNeroProject.Abscract
{
    public class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer) //virtual ben bunu ezebilirim demek. Yani bu kuralı değiştirebilirim.
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
