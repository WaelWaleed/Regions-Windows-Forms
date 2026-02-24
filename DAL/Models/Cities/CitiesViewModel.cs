using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DAL.Models.Cities
{
    public class CitiesViewModel
    {
        [DisplayName("ID")]
        public Guid Id { get; set; }

        [DisplayName("City Name")]
        public string Name { get; set; }

        [DisplayName("Country")]
        public string CountryName { get; set; }

        [DisplayName("Country ID")]
        public Guid CountryId { get; set; }
    }
}
