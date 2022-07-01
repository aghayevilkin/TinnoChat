using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tinno.Helpers.Mail
{
    public static class mailConfig
    {
        public static string BaseUrl = "http://aig.az/";
        public static string ProjectName = "AIG Managements";
        public static string ConfirmPath = BaseUrl + "account/ConfirmEmail";
        public static string ForgotPath = BaseUrl + "account/resetpassword";
        public static string MailFrom = "transxmanagement@gmail.com";
        public static string MailPasswrd = "lhieoyaivmdladfi";
    }
}
