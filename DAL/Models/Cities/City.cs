using DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.Cities
{
    public class City : BaseEntity
    {
        public Guid CountryId { get; set; }
    }
}
