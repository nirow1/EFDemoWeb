using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; } = null!; 
        public string City { get; set; } = null!;
        public string Śtate { get; set; } = null!;
        public string ZipCode { get; set; } = null!;

    }
}
