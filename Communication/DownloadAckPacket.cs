namespace AFSP.Communication
{
    internal class DownloadAckPacket : Packet
    {
        public DownloadAckPacket(byte[] pseudonym)
            : base(Constants.DOWNLOAD_ACK, pseudonym)
        {
        }
    }
}