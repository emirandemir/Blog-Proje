using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogReyting
    {
        public int ID { get; set; }
        public int BlogID { get; set; }
        public int BlogToplamPuan { get; set; }
        public int ToplamDeğerlendirmeSayısı { get; set; }

    }
}
