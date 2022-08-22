using MyTraining1121AngularDemo.Customers;
using MyTraining1121AngularDemo.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.Migrations.Seed.Host
{
    public class InitialCustomerCreator
    {
        private readonly MyTraining1121AngularDemoDbContext _context;

        public InitialCustomerCreator(MyTraining1121AngularDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            var douglas = _context.Customers.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.Customers.Add(
                    new Customer
                    {
                        CustomerName = "Douglas",
                        EmailAddress = "douglas.adams@fortytwo.com",
                        Address = "Pune",
                        RegistrationDate= DateTime.Now,
                    });
            }

            var asimov = _context.Customers.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            if (asimov == null)
            {
                _context.Customers.Add(
                    new Customer
                    {
                        CustomerName = "isaac",
                        EmailAddress = "isaac.adams@fortytwo.com",
                        Address = "Mumbai",
                        RegistrationDate = DateTime.Now,
                    });
            }
        }
    }
}
