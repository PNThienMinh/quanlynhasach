using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
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

        public static bool IsDatabaseConnected()
        {
            return Helper.CheckConnection();
        }

        public static bool IsValidConnection(string connStr)
        {
            return Helper.CheckConnection(connStr);
        }

        public static void SetupConnectionString(string connStr)
        {
            Config.ConnectionString = connStr;
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

            if (Directory.Exists(diskD))
                return diskD;
            if (Directory.Exists(diskE))
                return diskE;
            return diskC;
        }

        public static void SaveDataLocation(string disk)
        {
            Helper.SaveDataLocation(disk);
        }

    }
}
