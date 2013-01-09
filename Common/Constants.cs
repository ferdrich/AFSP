using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSP
{
    internal class Constants
    {
        public static string BroadCastAdr = "255.255.255.0"; //TBD

        public static int PORT = 24711;

        //OpCodes
        public static byte SIGNIN = 0x01;
        public static byte SIGNIN_ACK = 0x02;
        public static byte SIGNOUT = 0x03;
        public static byte EXCHANGE_FILELIST = 0x04;
        public static byte EXCHANGE_FILELIST_REQ = 0x05;
        public static byte DOWNLOAD_REQ = 0x06;
        public static byte DOWNLOAD_RPL = 0x07;
        public static byte DOWNLOAD_ERR = 0x08;
        public static byte DOWNLOAD_ACK = 0x09;
        public static byte HEARTBEAT = 0x0A;
    }
}