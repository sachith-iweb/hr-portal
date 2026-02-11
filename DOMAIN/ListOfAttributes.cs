using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DOMAIN
{
   public class ListOfAttributes
    {
        public int Id { get; set; }
        public int DetailId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public string DisplayValue { get; set; }
        public string BoundValue { get; set; }
        public int HeaderId { get; set; }
    }
}
