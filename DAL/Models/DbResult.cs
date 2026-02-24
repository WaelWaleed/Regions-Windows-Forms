using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class DbResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Guid? Id { get; set; }
    }
}
