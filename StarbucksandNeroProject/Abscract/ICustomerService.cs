using StarbucksandNeroProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarbucksandNeroProject.Abscract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
