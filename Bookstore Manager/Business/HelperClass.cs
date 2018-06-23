using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HelperClass
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static string ToTitleCase(string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidName(string name)
        {
            if (!name.Contains(' ') || name.Length < 7)
                return false;
            return true;
        }

        public static bool IsValidPhoneNumber(string phoneNum)
        {
            if (phoneNum.Length > 11 || phoneNum.Length < 10)
                return false;
            if (!phoneNum.StartsWith("0"))
                return false;
            if (phoneNum.StartsWith("01"))
            {
                if (phoneNum.Length == 11)
                    return true;
                return false;
            }

            if (phoneNum.Length == 10)
            {
                return true;
            }
            return false;
        }
    }
}
