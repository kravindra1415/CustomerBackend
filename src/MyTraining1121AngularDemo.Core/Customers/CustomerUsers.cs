using Abp.Domain.Entities.Auditing;
using MyTraining1121AngularDemo.Authorization.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTraining1121AngularDemo.Customers
{
    public class CustomerUsers : CreationAuditedEntity<long>
    {
        public virtual long UserRefId { get; set; }
        [ForeignKey("UserRefId")]
        public virtual User user { get; set; }
        public virtual int CustomerRefId { get; set; }
        [ForeignKey("CustomerRefId")]
        public virtual Customer customer { get; set; }
        public virtual decimal TotalBillingAmount { get; set; }
    }
}
