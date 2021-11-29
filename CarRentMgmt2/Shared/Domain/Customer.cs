using System.Collections.Generic;

namespace CarRentMgmt2.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string DrivingLicense { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual List<Booking> Bookings { get; set; }
    }
}