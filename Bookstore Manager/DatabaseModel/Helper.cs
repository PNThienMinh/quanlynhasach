using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml;

namespace Data
{
    public class Helper
    {
        private static string ConnectionInformation = "Connection.xml";
        private static string DataLoction = "Location.xml";

        #region DatabaseConfig
        public static bool CheckConnection()
        {
            try
            {
                XmlDocument xmlDoc = XMLReader(ConnectionInformation);
                XmlElement xmlElement = xmlDoc.DocumentElement;
                var connectionString = "Data Source=" + xmlElement.SelectSingleNode("servname").InnerText +
                                       ";Initial Catalog=BM;Integrated Security=True;";
                using (var connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        Config.ConnectionString = connectionString;
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }

        }

        public static bool CheckConnection(string connStr)
        {
            using (var connection = new SqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public static void SaveServerName(string serverName)
        {
            XMLWriter(ConnectionInformation, serverName, "BM", "true");
        }

        public static XmlDocument XMLReader(String filename)
        {
            XmlDocument xmlR = new XmlDocument();
            xmlR.Load(filename);
            return xmlR;
        }

        public static void XMLWriter(String filename, String servname, String database, String costatus)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                              "Thong so co ban:\n\t" +
                              "costatus = true : quyen Windows\n\t" +
                              "costatus = false: quyen SQL Server\n\t" +
                              "servname: ten server\n\t" +
                              "username: ten dang nhap he thong\n\t" +
                              "password: mat khau dang nhap he thong\n\t" +
                              "database: ten co so du lieu\n");
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("costatus");
            xmlW.WriteString(costatus);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("servname");
            xmlW.WriteString(servname);
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("username");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("password");
            xmlW.WriteString("");
            xmlW.WriteEndElement();

            xmlW.WriteStartElement("database");
            xmlW.WriteString(database);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        #endregion

        #region DataLocation
        public static bool ExistDataLocation()
        {
            try
            {
                XmlDocument xmlDoc = XMLReader(DataLoction);
                XmlElement xmlElement = xmlDoc.DocumentElement;
                var location = xmlElement.SelectSingleNode("disk").InnerText;
                if (Directory.Exists(location))
                {
                    Config.DataLocation = Config.DataLocation.Insert(0, location);
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public static void XMLWriter(String filename, String disk)
        {
            XmlTextWriter xmlW = new XmlTextWriter(filename, null);
            xmlW.Formatting = Formatting.Indented;

            xmlW.WriteStartDocument();
            xmlW.WriteComment("\nKhong duoc thay doi noi dung file nay!\n" +
                              "Thong so co ban:\n\t" +
                              "disk: o dia cung dang hoat dong\n"
                              );
            xmlW.WriteStartElement("config");

            xmlW.WriteStartElement("disk");
            xmlW.WriteString(disk);
            xmlW.WriteEndElement();

            xmlW.WriteEndElement();
            xmlW.WriteEndDocument();

            xmlW.Close();
        }

        public static void SaveDataLocation(string disk)
        {
            Config.DataLocation.Insert(0, DataLoction);
            XMLWriter(DataLoction, disk);
        }

        #endregion


    }
}
