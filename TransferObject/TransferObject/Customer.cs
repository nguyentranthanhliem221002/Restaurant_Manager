using System.ComponentModel.DataAnnotations;
using TransferObject.Security;

namespace TransferObject.TransferObject
{
    public class Customer : User
    {
        public Customer() { }
        public int LoyaltyPoints { get; set; } // Điểm thưởng

    }
}
