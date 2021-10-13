using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models
{
    public class ProductModel
    { 
        public string ProductCode { get; set; }

        public string ProductCategory { get; set; }

        public int PorductPoint { get; set; }


        //public byte[] img1 { get; set; }
        //public byte[] img2 { get; set; }

        public string Productimg1 { get; set; }
        public string Productimg2 { get; set; }

        public string ProductName { get; set; }

        public string ProductWeight1 { get; set; }

        public string ProductWeight1Cost { get; set; }

        public string ProductWeight2 { get; set; }

        public string ProductWeight2Cost { get; set; }

        public string ProductWeight3 { get; set; }

        public string ProductWeight3Cost { get; set; }

        public string ProductWeight4 { get; set; }

        public string ProductWeight4Cost { get; set; }

         
        public string ProductDescription { get; set; }
         
        public bool IsAciveProduct { get; set; }
         
        public bool IsTodaySpecialProduct { get; set; }
         
        public DateTime ProductAddedDate { get; set; }
    }

    public class ProductBindingModel
    {
        public string ProductCode { get; set; }
    }


    public class ProductTable
    {
      
        public string ProductCode { get; set; }

        public string ProductCategory { get; set; }

        public int PorductPoint { get; set; }

        public string Productimg1 { get; set; }
        public string Productimg2 { get; set; }


        public string ProductName { get; set; }

        public string ProductWeight1 { get; set; }

        public string ProductWeight2 { get; set; }

        public string ProductWeight3 { get; set; }

        public string ProductWeight4 { get; set; }

        public string ProductWeight5 { get; set; }

        public int price { get; set; }

        public string ProductDescription { get; set; }

        public bool IsAciveProduct { get; set; }

        public bool IsTodaySpecialProduct { get; set; }


        public DateTime ProductAddedDate { get; set; }


        //[ForeignKey("PorductPointID")]
        //public virtual PointTable pointTable { get; set; }
    }
}
