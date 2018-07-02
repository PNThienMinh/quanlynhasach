using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Data;

namespace Services
{
    public class Ultilities
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
            List<string> ch = new List<string>() { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+", "=", "[", "]", @"\", "|", ";", ":", "'", "<", ">", ",", ".", "/", "?" };
            if (!name.Contains(' ') || name.Length < 7)
                return false;
            if (ch.Any(name.Contains))
                return false;
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                return true;
            return true;
        }

        public static bool IsValidPhoneNumber(string phoneNum)
        {
            if (phoneNum.Length > 11 || phoneNum.Length < 10)
                return false;
            if (!phoneNum.StartsWith("0"))
                return false;
            if (phoneNum.StartsWith("00"))
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

        public static bool IsValidDistrict(string dis)
        {
            if (IsDigitsOnly(dis))
                return false;
            if (dis.Length < 6)
                return false;
            return true;
        }


        public static bool IsDatabaseConnected()
        {
            return Helper.CheckConnection();
        }

        public static bool IsValidConnection(string connStr)
        {
            return Helper.CheckConnection(connStr);
        }

        public static void SaveConnectionInformation(string serverName)
        {
            Helper.SaveServerName(serverName);
        }

        public static void SetupDataLocation()
        {
            if (!Helper.ExistDataLocation())
            {
                string disk = GetLocalDiskAvailable();
                SaveDataLocation(disk);
            }
        }

        public static string GetLocalDiskAvailable()
        {
            string diskC = @"C:\";
            string diskD = @"D:\";
            string diskE = @"E:\";
            string diskF = @"F:\";
            string diskG = @"G:\";
            string diskH = @"H:\";

            if (Directory.Exists(diskD))
                return diskD;
            if (Directory.Exists(diskE))
                return diskE;
            if (Directory.Exists(diskF))
                return diskF;
            if (Directory.Exists(diskG))
                return diskG;
            if (Directory.Exists(diskH))
                return diskH;
            return diskC;
        }

        public static void SaveDataLocation(string disk)
        {
            Helper.SaveDataLocation(disk);
        }

    }
}
