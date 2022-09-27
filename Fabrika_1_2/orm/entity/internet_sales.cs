using Fabrika_1_2.orm.context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabrika_1_2.orm.entity
{
    class internet_sales:BaseEntity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Number { get; set; }
        public string pıece { get; set; }
        public string prıce { get; set; }
        public string barcod_No { get; set; }
    }
    class BaseEntity
    {

        public int ID { get; set; }

        private DateTime? _addDate = DateTime.Now;

        public DateTime? AddDate
        {
            get { return _addDate; }
            set { _addDate = value; }
        }

        private DateTime? _updateDate = DateTime.Now;

        public DateTime? UpdateDate
        {
            get { return _updateDate; }
            set { _updateDate = value; }
        }

        [Column(Order = 3, TypeName = "datetime2")]

        private DateTime? _deletedDate = DateTime.Now;

        public DateTime? DeletdDate
        {
            get { return _deletedDate; }
            set { _deletedDate = value; }
        }

        private bool _isdeleted = false;

        public bool İsdeleted
        {
            get { return _isdeleted; }
            set { _isdeleted = value; }
        }
    }
}
