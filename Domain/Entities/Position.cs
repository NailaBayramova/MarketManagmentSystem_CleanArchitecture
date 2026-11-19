using RetailERP.Domain.Common;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RetailERP.Domain.Entities
{
    public class Position: BaseEntity
    {
        public bool  IsActive { get;private set; }
        public string Name { get;private set; }

        public Position()
        {
            
        }

        private Position(string name)
        {
            SetName(name);
            IsActive = true;
        }

        public static Position Create (string name)
        {
            return new Position (name);
        }
        
        public void Activate()
        {
            IsActive = true;
        }
        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name can not be empty");

            Name = name.Trim();
        }
    }
    
   
}
