using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Natification
    {
        public int ID { get; set; }
        public string NatificationType { get; set; }
        public string NatificationTypeSembol { get; set; }
        public string NatificationDetails { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}
