using StarbucksandNeroProject.Abscract;
using StarbucksandNeroProject.Adapters;
using StarbucksandNeroProject.Concrete;
using StarbucksandNeroProject.Entities;

namespace StarbucksandNeroProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000, 12, 24), FirstName = "Caner", LastName = "Ay", NationalityId = "37315944668" });
            Console.ReadLine();
        }
    }
}