﻿using MyTraining1121AngularDemo.Dto;

namespace MyTraining1121AngularDemo.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
