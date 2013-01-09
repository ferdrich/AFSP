namespace AFSP.Communication
{
    internal class ExchangeFilelistReqPacket : Packet
    {
        public ExchangeFilelistReqPacket(byte[] Pseudonym)
            : base(Constants.EXCHANGE_FILELIST_REQ, Pseudonym)
        {
        }
    }
}