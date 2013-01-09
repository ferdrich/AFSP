namespace AFSP.Communication
{
    internal class SignoutPacket : Packet
    {
        public SignoutPacket(byte[] pseudonym)
            : base(Constants.SIGNOUT, pseudonym)
        {
        }
    }
}