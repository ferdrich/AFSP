namespace AFSP.Communication
{
    internal class SigninPacket : Packet
    {
        public SigninPacket(byte[] pseudonym)
            : base(Constants.SIGNIN, pseudonym)
        {
        }
    }
}