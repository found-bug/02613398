using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.Ad_Post
{
    class Commercial_Vehicles_Ad_Type
    {
        public int ID { get; set; }
        public string Category_Name { get; set; }
    }

    class Commercial_Vehicles_Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }


    class Commercial_Vehicles_Model_Type
    {
        public int ID { get; set; }
        public int ID_Commercial_Vehicles_Category { get; set; }
        public string ModelName { get; set; }
    }


    class Spare_Parts_Type
    {
        public int ID { get; set; }
        public string Spare_Parts_Type_ { get; set; }
    }
}
