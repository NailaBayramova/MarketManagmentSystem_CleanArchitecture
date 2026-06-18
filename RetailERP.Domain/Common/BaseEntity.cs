using System;
using System.Collections.Generic;
using System.Text;

namespace RetailERP.Domain.Common
{
    public abstract class BaseEntity
    {
        public  int Id  { get; set; }
        public string  Name { get; set; }
    }
}
