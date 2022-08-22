using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTraining1121AngularDemo.Customers.Dto
{
    public class UserInCustomerListDto : CreationAuditedEntityDto<long>
    {
        public long UserRefId { get; set; }
        public decimal TotalBillingAmount { get; set; }
    }
}
