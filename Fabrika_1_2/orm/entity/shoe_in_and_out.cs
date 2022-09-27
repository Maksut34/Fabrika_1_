using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_1_2.orm.entity
{
    class shoe_in_and_out:BaseEntity
    {

        public string Colour { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Barcod_No { get; set; }
        public string shoes_delıvery_dates { get; set; }
        public string returned_shoe_sıze { get; set; }
    }
}
