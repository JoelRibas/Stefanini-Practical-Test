using System;
using System.IO;

using Stefanini.Types;

namespace Stefanini.Business
{
    public class Util
    {

        #region GetExceptionFullMessageWithStackTrace

        public static string GetExceptionFullMessageWithStackTrace(Exception ex)
        {
            if (ex == null)
            {
                return null;
            }
            string msg = ex.Message;
            if (ex.InnerException != null)
            {
                msg += "\n" + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    msg += "\n" + ex.InnerException.InnerException.Message;
                    if (ex.InnerException.InnerException.InnerException != null)
                    {
                        msg += "\n" + ex.InnerException.InnerException.InnerException.Message;
                        if (ex.InnerException.InnerException.InnerException.InnerException != null)
                        {
                            msg += "\n" + ex.InnerException.InnerException.InnerException.InnerException.Message;
                        }
                    }
                }
            }
            msg += "\nSTACK TRACE:" + ex.StackTrace;
            return msg;
        }
        #endregion

        #region GetExceptionFullMessage

        public static string GetExceptionFullMessage(Exception ex)
        {
            if (ex == null)
            {
                return null;
            }
            string msg = ex.Message;
            if (ex.InnerException != null)
            {
                msg += "\n" + ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    msg += "\n" + ex.InnerException.InnerException.Message;
                    if (ex.InnerException.InnerException.InnerException != null)
                    {
                        msg += "\n" + ex.InnerException.InnerException.InnerException.Message;
                        if (ex.InnerException.InnerException.InnerException.InnerException != null)
                        {
                            msg += "\n" + ex.InnerException.InnerException.InnerException.InnerException.Message;
                        }
                    }
                }
            }
            return msg;
        }
        #endregion

        #region GetExceptionMessage

        public static string GetExceptionMessage(Exception ex)
        {
            if (ex == null)
            {
                return null;
            }
            string msg = ex.Message;
            if (ex.InnerException != null)
            {
                msg = ex.InnerException.Message;
                if (ex.InnerException.InnerException != null)
                {
                    msg = ex.InnerException.InnerException.Message;
                    if (ex.InnerException.InnerException.InnerException != null)
                    {
                        msg = ex.InnerException.InnerException.InnerException.Message;
                        if (ex.InnerException.InnerException.InnerException.InnerException != null)
                        {
                            msg = ex.InnerException.InnerException.InnerException.InnerException.Message;
                        }
                    }
                }
            }
            return msg;
        }

        #endregion

        #region Encrypt - MD5

        public static string MD5Encrypt(string source)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(source);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }

        #endregion

        #region GetDatabaseConnectionSettings

        public static DatabaseConnectionSettings GetDatabaseConnectionSettings(string fileName)
        {
            DatabaseConnectionSettings settings = null;
            string settingsString = Util.ReadTextFile(fileName);
            if (!settingsString.Contains("ERROR"))
            {
                settings = (DatabaseConnectionSettings)Util.Deserialize(typeof(DatabaseConnectionSettings), settingsString);
            }
            return settings;
        }

        #endregion
        
        #region ReadTextFile

        public static string ReadTextFile(string fileName)
        {
            string result = null;
            TextReader reader = null;
            try
            {
                reader = File.OpenText(fileName);
                result = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                if (reader != null)
                {
                    reader.Close();
                    reader.Dispose();
                }
                string message = "ERROR:" + GetExceptionMessage(ex);
            }
            return result;
        }

        #endregion

        #region Deserialize

        public static object Deserialize(Type type, string source)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(type);
                StringReader reader = new StringReader(source);
                object result = serializer.Deserialize(reader);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Exception in ->" + "Util.Deserialize()\n" + ex.Message, ex);
            }
        }

        #endregion

    }
}
