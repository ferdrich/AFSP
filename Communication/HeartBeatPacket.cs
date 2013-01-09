namespace AFSP.Communication
{
    internal class HeartBeatPacket : Packet
    {
        public HeartBeatPacket(byte[] pseudonym)
            : base(Constants.HEARTBEAT, pseudonym)
        {
        }
    }
}