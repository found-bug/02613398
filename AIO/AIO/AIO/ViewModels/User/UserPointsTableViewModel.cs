using System;
using System.Collections.Generic;
using System.Text;

namespace ANV.ViewModels.User
{

    public class UserPointsTable
    { 
        public int UserPointsID { get; set; }
         
        public string AspNetUserID { get; set; }

        public int AmountTotalSpent { get; set; }

        public int TotalPoints { get; set; }
          
    }

}
