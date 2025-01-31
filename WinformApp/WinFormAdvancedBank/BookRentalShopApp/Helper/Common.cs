﻿using System;
using System.Net;

namespace BookRentalShopApp.Helper
{
    public class Common
    {
        public static string Connstring = "Data Source=127.0.0.1;" +
                                          "Initial Catalog=bookrentalshop;" +
                                          "Persist Security Info=True;" +
                                          "User ID=sa;" +
                                          "Password=mssql_p@ssw0rd!";

        public static string LoginUserId = string.Empty;

        /// <summary>
        /// 아이피주소 받아오는 메서드
        /// </summary>
        /// <returns></returns>
        internal static string GetLocalIp()
        {
            string localIP = "";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;

                }
            }

            return localIP;
        }

        internal static string ReplaceCmdText(string strSourece) // 들어오는 문자를 받아서 replace 보안부분 보완
        {
            var result = strSourece.Replace("'", "＇"); // 특수문자 홑따옴표로 수정
            result = result.Replace("--", ""); // -- 값은 없앰
            result = result.Replace(";", ""); // ; 값은 없앰

            return result;
        }
    }
}
