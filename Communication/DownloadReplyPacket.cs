using System;

namespace AFSP.Communication
{
    internal class DownloadReplyPacket : Packet
    {
        //DataContent = Inhalt der zu übertragenden Datei
        public DownloadReplyPacket(byte[] pseudonym, byte[] dataContent)
            : base(Constants.DOWNLOAD_RPL, pseudonym, BitConverter.GetBytes(dataContent.Length), dataContent)
        {
        }
    }
}