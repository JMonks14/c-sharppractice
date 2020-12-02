using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkTest.Models
{
    public class Customer
    {

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
#nullable enable
        public string? Address { get; set; }
        public string? email { get; set; }
        public string? Phone { get; set; }
#nullable disable

        public ICollection<Order> Orders { get; set; }
    }
}
