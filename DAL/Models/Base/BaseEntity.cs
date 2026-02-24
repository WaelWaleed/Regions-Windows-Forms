using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
