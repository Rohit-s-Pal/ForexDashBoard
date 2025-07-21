using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace ForexAPI
{

    public class WebAPILog
    {

        #region : Properties :
        public static string appPath = "";
        public static string DirName = "";
        public static string fileName = "", ErrfileName = "", DirErrPath = "", DirPath = "";
        #endregion
        public static void MscreateLog(string foldername)
        {
            //appPath = ConfigurationManager.AppSettings["WebApiLog"];
            appPath = Configuration.GetWebApiLogPath();

            DirName = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            if (string.IsNullOrEmpty(foldername))
            {
                appPath = appPath + "\\" + DirName;
            }
            else
            {
                appPath = appPath + "\\" + DirName + "\\" + foldername;
            }
            string time = DateTime.Now.ToString("hh:mm:ss:FF");
            time = time.Replace(":", "");
            fileName = "MSLog_" + time.ToString() + ".txt";
            ErrfileName = "PGErr_" + time.ToString() + ".txt";
            DirErrPath = appPath + "\\" + ErrfileName;

            if (FileOrDirectoryExists(appPath) == true)
            {
                DirPath = appPath + "\\" + fileName;
                WriteLog(DirPath, "Process Started at " + DateTime.Now.ToString());
            }
            else
            {
                Directory.CreateDirectory(appPath);
                DirPath = appPath + "\\" + fileName;
                WriteLog(DirPath, "Process Started at " + DateTime.Now.ToString());
            }
            //appPath = ConfigurationManager.AppSettings["WebApiLog"];
            appPath = Configuration.GetWebApiLogPath();
        }

        internal static bool FileOrDirectoryExists(string name)
        {
            return (Directory.Exists(name) || File.Exists(name));
        }

        public static void WriteLog(string logFileName, string logMessage)
        {
            using (StreamWriter logFile = new StreamWriter(logFileName, true))
            {
                logFile.WriteLine(logMessage);
            }
        }
    }
}

