using Abp.Application.Services.Dto;

namespace MyTraining1121AngularDemo.Customers.Dtos
{
    public class UserInCustomerListDto : CreationAuditedEntityDto<long>
    {
        public long UserRefId { get; set; }
        public decimal TotalBillingAmount { get; set; }
    }
}
