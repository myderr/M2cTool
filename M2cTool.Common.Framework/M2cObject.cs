using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace M2cTool.Common.Framework
{
    public class M2cObject
    {
        public static void InitializeConfig(string fileName)
        {
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();//文件不存在，创建它 并关闭文件流。
                IniFiles.Set("Settings", "MirServerDir", string.Empty, fileName);

            }
        }
        public static void Open(string path, string m2cconstString)
        {
            try
            {
                Process.Start(path + m2cconstString);
            }
            catch
            {
                throw new Exception($@"未能找到""{ path }{ m2cconstString}""");
            }
        }
        public static string GetVersion(string path, string text)
        {
            var FileMajorPart = FileVersionInfo.GetVersionInfo(path).FileMajorPart.ToString();
            var FileMinorPart = FileVersionInfo.GetVersionInfo(path).FileMinorPart.ToString();
            var FileBuildPart = FileVersionInfo.GetVersionInfo(path).FileBuildPart.ToString();
            return $"{FileMajorPart}.{FileMinorPart}.{FileBuildPart}({text})";
        }
        public static string GetMirServerDir(string fileName)
        {
            return IniFiles.Get("Settings", "MirServerDir", null, fileName);
        }
    }
    //public class Log
    //{
    //    private static readonly string l_LogFilesName = "Log_";
    //    private static string L_LogFilesPath { get; set; }

    //    public static void Add(string errorType, string logInfo)
    //    {
    //        try
    //        {
    //            L_LogFilesPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Log\\";
    //            if (!Directory.Exists(L_LogFilesPath))
    //            {
    //                Directory.CreateDirectory(L_LogFilesPath);
    //            }
    //            string t_time = DateTime.Now.ToString("HH:mm:ss");
    //            string x_time = DateTime.Now.ToString("yyyyMMdd");
    //            string i_text = string.Format("[{0}][{1}]:{2}", t_time, errorType, logInfo);
    //            File.AppendAllText(L_LogFilesPath + l_LogFilesName + x_time + ".log", i_text + "\r\n");



    //            //(m_LogDire + m_LogName + type + "_" + DateTime.Now.ToString("yyyyMMdd") + ".log",
    //            //    System.DateTime.Now.ToString("HH:mm:ss:fff") + "  " + logInfo + "\r\n",
    //            //    Encoding.Default);
    //        }
    //        catch
    //        {
    //        }
    //    }

    //}

    public class IniFiles
    {
        #region API函数声明

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key,
            string val, string filePath);

        [DllImport("kernel32")]
        private static extern long GetPrivateProfileString(string section, string key,
            string def, StringBuilder retVal, int size, string filePath);
        #endregion

        #region 读Ini文件
        public static string Get(string Section, string Key, string Value, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, Value, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        #endregion

        #region 写Ini文件
        public static bool Set(string Section, string Key, string Value, string iniFilePath)
        {
            if (File.Exists(iniFilePath))
            {
                long OpStation = WritePrivateProfileString(Section, Key, Value, iniFilePath);
                if (OpStation == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion

    }



    public class Envir
    {
        /// <summary>
        /// 关闭 Windows XP 平台
        /// </summary>
        public static bool PlatformCheck
        {

            get
            {
                switch (Environment.OSVersion.Version.Major)
                {
                    case 5 when Environment.OSVersion.Version.Minor == 1:
                        return true;
                    case 5 when Environment.OSVersion.Version.Minor == 2:
                        return false;
                    case 6 when Environment.OSVersion.Version.Minor == 0:
                        return false;
                    case 6 when Environment.OSVersion.Version.Minor == 1:
                        return false;
                    case 6 when Environment.OSVersion.Version.Minor == 2:
                        return false;
                    case 6 when Environment.OSVersion.Version.Minor == 3:
                        return false;
                    case 10 when Environment.OSVersion.Version.Minor == 0:
                        return false;
                    default:
                        return true;
                }
            }




        }


        //public static string PlatformCheck
        //{

        //    get
        //    {
        //        switch (Environment.OSVersion.Version.Major)
        //        {
        //            case 5 when Environment.OSVersion.Version.Minor == 1:
        //                return true;
        //            case 5 when Environment.OSVersion.Version.Minor == 2:
        //                return true;
        //            case 6 when Environment.OSVersion.Version.Minor == 0:
        //                return true;
        //            case 6 when Environment.OSVersion.Version.Minor == 1:
        //                return false;
        //            case 6 when Environment.OSVersion.Version.Minor == 2:
        //                return false;
        //            case 6 when Environment.OSVersion.Version.Minor == 3:
        //                return false;
        //            case 10 when Environment.OSVersion.Version.Minor == 0:
        //                return false;
        //            default:
        //                return true;
        //        }
        //    }

        //}}
    }
}
