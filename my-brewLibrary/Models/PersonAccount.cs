using System;
using System.ComponentModel.DataAnnotations;

namespace my_brewLibrary.Models
{
    public class PersonAccount
    {
    
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        [DataType(DataType.Date)]
        public DateTime Lastoneline { get; set; }
    }
}