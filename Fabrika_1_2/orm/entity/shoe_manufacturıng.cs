using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_1_2.orm.entity
{
    class shoe_manufacturıng:BaseEntity
    {
        public string Colour { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Barcod_No { get; set; }
        public string fınıshed_shoes_sıze { get; set; }
    }
}
