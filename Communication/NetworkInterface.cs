using System;
using System.Net;

namespace AFSP.Communication
{
    internal class NetworkInterface
    {
        public void SendTcpPacket(IPAddress destAddr, Object pdu)
        {
            //IPEndPoint endpoint = new IPEndPoint(destAddr, Constants.PORT);
        }

        public void SendUdpBroadcast()
        {
        }

        public void ReceiveTcpPacket()
        {
        }

        public void ReceiveUdpBroadcast()
        {
        }
    }
}