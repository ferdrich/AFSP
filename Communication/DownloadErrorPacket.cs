namespace AFSP.Communication
{
    internal class DownloadErrorPacket : Packet
    {
        public DownloadErrorPacket(byte[] pseudonym)
            : base(Constants.DOWNLOAD_ERR, pseudonym)
        {
        }
    }
}