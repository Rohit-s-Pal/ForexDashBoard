using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Xml;

using Newtonsoft.Json;
using ForexAPI;
using NET.Shared;
using ForexINFOAPI;

namespace ForexAPI
{

    public class CommonUtility
    {
        public static string Serialize<T>(T obj, string v)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            string retVal = Encoding.UTF8.GetString(ms.ToArray());
            return retVal;
        }

        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            if (json == null)
                return obj;
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        internal string Encrypt(string valueToEncrypt)
        {
            Security security = new Security();
            valueToEncrypt = security.Encrypt256(security.EnCryKey, valueToEncrypt);
            security = null;
            return valueToEncrypt;
        }

        internal string EncryptData(string key, string valueToEncrypt)
        {
            Security security = new Security();
            valueToEncrypt = security.Encrypt256(key, valueToEncrypt);
            //valueToEncrypt = HttpContext.Current.Server.UrlEncode(valueToEncrypt);
            security = null;
            return valueToEncrypt;
        }

        internal string EncryptEncodeData(string key, string valueToEncrypt)
        {
            Security security = new Security();
            valueToEncrypt = security.Encrypt256(key, valueToEncrypt);
            //valueToEncrypt = HttpContext.Current.Server.UrlEncode(valueToEncrypt);
            valueToEncrypt = WebUtility.UrlEncode(valueToEncrypt);
            security = null;
            return valueToEncrypt;
        }

        internal string Decrypt(string valueToDecrypt)
        {
            Security security = new Security();
            valueToDecrypt = security.Decrypt256(security.EnCryKey, valueToDecrypt);
            security = null;
            return valueToDecrypt;
        }

        internal string Decrypt(string key, string valueToDecrypt)
        {
            Security security = new Security();
            valueToDecrypt = security.Decrypt256(key, valueToDecrypt);
            security = null;
            return valueToDecrypt;
        }

        public static string Serialize(LoginResponseInfo outputInfo)
        {
            return JsonConvert.SerializeObject(outputInfo);
        }
        public static string Serialize(PropertyPageResponseInfo responseInfo)
        {
            return JsonConvert.SerializeObject(responseInfo);
        }
        public static string Serialize(AgentPostPropertyResponseInfo responseInfo)
        {
            return JsonConvert.SerializeObject(responseInfo);
        }

        //internal static string Serialize(object value)
        //{
        //    throw new NotImplementedException();
        //}
    }
}