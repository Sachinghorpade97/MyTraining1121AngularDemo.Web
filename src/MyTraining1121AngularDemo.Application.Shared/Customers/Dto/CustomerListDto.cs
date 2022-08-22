using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MyTraining1121AngularDemo.Customers.Dto
{
    public class CustomerListDto : FullAuditedEntityDto
    {
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }

        public bool Selected { get; set; }

        public Collection<UserInCustomerListDto> CustUsers { get; set; }
    }
    public class CustomerDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
        public Collection<UserInCustomerListDto> CustUsers { get; set; }
    }
    public class CustomerUsersDropDownDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

    }
}
