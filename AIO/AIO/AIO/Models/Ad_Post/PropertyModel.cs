using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.Ad_Post
{
    class Property_is_on
    {
        public string Property_Is_for_sale_or_purchase { get; set; }
    }

    class Property_Category_Model
    {
        public int ID { get; set; }
        public string Property_Category{ get; set; }
    }

    class Property_Type_Model
    {
        public string Property_Type { get; set; }
    }
    class bedroom_Model
    {
        public string bedroom_count { get; set; }
    }
    class furnishing_Model
    {
        public string furnishing_type { get; set; }
    }
    class construction_status_Model
    {
        public string construction_type { get; set; }
    }
}
