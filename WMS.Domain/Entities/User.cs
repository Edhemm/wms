using System;
using System.Collections.Generic;
using System.Text;

namespace WMS.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }

    }
}
