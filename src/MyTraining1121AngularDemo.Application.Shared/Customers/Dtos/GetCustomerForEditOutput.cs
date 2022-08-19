using System;

namespace MyTraining1121AngularDemo.Customers.Dtos
{
    public class GetCustomerForEditOutput
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Address { get; set; }
    }
}
