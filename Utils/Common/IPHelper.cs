using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Common
{
    public class IPHelper
    {
        public static string GetIpAddress()
        {
            IPHostEntry SystemAC = Dns.GetHostEntry(Dns.GetHostName());
            string ipAddress = string.Empty;
            foreach (var address in SystemAC.AddressList)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = address.ToString();
                }
            }
            return ipAddress;
        }
    }
}
