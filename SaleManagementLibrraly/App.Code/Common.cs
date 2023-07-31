﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;

namespace SaleManagementLibrraly.App.Code
{
    public class Common
    {
        /// <summary>
        /// Mã hóa chuỗi thành chuỗi MD5
        /// Input: sToEncrypt (Chuỗi cần mã hóa)
        /// Output: Chuỗi sau khi mã hóa
        /// </summary>
        public static string EncryptMD5(string sToEncrypt)
        {
            System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
            byte[] bytes = ue.GetBytes(sToEncrypt);

            // encrypt bytes
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashBytes = md5.ComputeHash(bytes);

            // Convert the encrypted bytes back to a string (base 16)
            string hashString = "";

            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashString += Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
            }

            return hashString.PadLeft(32, '0');
        }

        /// <summary>
        /// Ghi log lỗi và quy trình
        /// Input: sPage(Tên của trang cần Log), string sFunction(Tên của hàm cần Log), string sMessage(Nội dung Log)
        /// </summary>
        public static void WriteLog(string sPage, string sFunction, string sMessage)
        {
            try
            {
                string LogPath = Path.Combine(Environment.CurrentDirectory, "LogInfo");
                //string LogPath = HttpContext.Current.Server.MapPath("~/LogInfo");
                if (!System.IO.Directory.Exists(LogPath))
                {
                    System.IO.Directory.CreateDirectory(LogPath);
                }
                CLogger TestLogger = new CLogger();
                TestLogger.Initialize(LogPath, "DotNet.log", 2);
                TestLogger.LogInformation(sPage, sFunction, sMessage);
                TestLogger.Terminate();
            }
            catch (Exception)
            {
            }
        }
    }
}
