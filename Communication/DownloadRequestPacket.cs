using System;

namespace AFSP.Communication
{
    internal class DownloadRequestPacket : Packet
    {
        public DownloadRequestPacket(byte[] pseudonym, byte[] hash)
            : base(Constants.DOWNLOAD_REQ, pseudonym, BitConverter.GetBytes(hash.Length), hash)
        {
        }
    }
}