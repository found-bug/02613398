using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.Models.Account
{
    public class RegisterBindingModel
    { 
        public string CustomerName { get; set; } 
        //public string PhoneNumber{ get; set; }  
        public string email_phoneNumber { get; set; }  
        public string Password { get; set; }
    }


    public class DetailsRegisterBindingModel
    {
        public string PhoneNumber_Email { get; set; }
         
        public string FatherName { get; set; }
         
        public string Address { get; set; }
         
        public string Village_Ward { get; set; }
         
        public string Panchayat_ULB { get; set; }
         
        public string Block { get; set; }
         
        public string District { get; set; } 
        public string State { get; set; }
    }


    public class aspNetUser
    {
        public string Id { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }

        public DateTime LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }
    }



    public class UserRegisterError
    {
        public string Message { get; set; }
        public string Error { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string IsSuccess { get; set; }
    }

}
