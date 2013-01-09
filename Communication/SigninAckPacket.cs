namespace AFSP.Communication
{
    internal class SigninAckPacket : Packet
    {
        public SigninAckPacket(byte[] pseudonym)
            : base(Constants.SIGNIN_ACK, pseudonym)
        {
        }
    }
}