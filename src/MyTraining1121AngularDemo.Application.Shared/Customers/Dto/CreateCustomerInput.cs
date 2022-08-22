using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1121AngularDemo.Customers.Dto
{
    public class CreateCustomerInput
    {
        [Required]
        [MaxLength(CustomerConsts.MaxNameLength)]
        public string CustomerName { get; set; }

        [EmailAddress]
        [MaxLength(CustomerConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string Address { get; set; }
        public List<long> UserRefId { get; set; }


    }

}
