namespace AFSP.Communication
{
    internal class Packet
    {
        private byte[] _dataLength;
        private byte _opcode;
        private byte[] _pseudonym;

        public Packet()
        {
            _pseudonym = new byte[25];
            _dataLength = new byte[6];
        }

        public Packet(byte opCode, byte[] pseudonym)
        {
            //Assertions hinzufügen?
            _opcode = opCode;
            _pseudonym = pseudonym;
            _dataLength = null;
            Data = null;
        }

        public Packet(byte opCode, byte[] pseudonym, byte[] dataLength, byte[] Data)
        {
            //Assertions hinzufügen?
            _opcode = opCode;
            _pseudonym = pseudonym;
            _dataLength = dataLength;
            this.Data = Data;
        }

        public byte[] Data { get; set; }
    }
}