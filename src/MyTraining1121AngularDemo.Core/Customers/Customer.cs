using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.Customers
{
    [Table("PbCustomers")]
    public class Customer : FullAuditedEntity, IMustHaveTenant
    {
        public const int MaxNameLength = 32;
        public const int MaxEmailAddressLength = 255;


        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string CustomerName { get; set; }

        [Required]
        [MaxLength(MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual DateTime RegistrationDate { get; set; }

        public virtual string Address { get; set; }
        public virtual int TenantId { get; set; }
        public virtual ICollection<CustomerUsers> CustomersUsers { get; set; }
    }
}
