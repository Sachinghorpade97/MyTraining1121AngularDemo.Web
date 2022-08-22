using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTraining1121AngularDemo.Customers.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.Customers
{
    public interface ICustomerAppService : IApplicationService
    {
        ListResultDto<CustomerListDto> GetCustomer(GetCustomerInput input);
        Task CreateCustomer(CreateCustomerInput input);
        Task DeleteCustomer(EntityDto input);
        Task DeleteUser(EntityDto<long> input);
        Task<UserInCustomerListDto> AddUser(AddUserInput input);

    }
}
