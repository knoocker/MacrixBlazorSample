using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MacrixSample.Shared.Dtos.Persons
{
    public class PersonToAddDto
    {
        /// <summary>
        /// First Name (TODO add validations)
        /// </summary>
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
