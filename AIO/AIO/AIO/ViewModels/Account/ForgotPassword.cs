using System;
using System.Collections.Generic;
using System.Text;

namespace AIO.ViewModels.Account
{
    public class ChangePassworApidBindingModel
    {
        public string NewPassword { get; set; }

        public string UserName { get; set; }
    }

    public class ForgotPasswordBindingModel
    {
        public string UserName { get; set; }
    }
}
