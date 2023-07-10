using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacrixSample.Shared.Dtos.Persons
{
    public class PersonToUpdateDto
    {
      //  [Required]
        public string FirstName { get; set; }
        //     [Required]
        public string LastName { get; set; }
        //   [Required]
        public string StreetName { get; set; }
        public string ApartmentNumber { get; set; }
        // [Required]
        public string PostalCode { get; set; }
        // [Required]
        public string Town { get; set; }
        // [Required]
        public string PhoneNumber { get; set; }
        // [Required]
        public DateTime DateOfBirth { get; set; }

    }
}
