using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using File = AFSP.ApplicationLogic.File;

namespace AFSP.Communication
{
    internal class ExchangeFilelistPacket : Packet
    {
        private readonly byte[] _dataList;

        public ExchangeFilelistPacket(byte[] pseudonym, byte[] dataLength, List<File> fileList, byte[] dataList)
            : base(Constants.EXCHANGE_FILELIST, pseudonym, dataLength, null)
        {
            _dataList = new byte[1];
            Data = CreateData(fileList);
        }

        private byte[] CreateData(List<File> fileList)
        {
            //Offsets überprüfen in Write()!

            foreach (File file in fileList)
            {
                var entry = new MemoryStream();
                entry.Write(BitConverter.GetBytes(file.Size), 0, 5);
                entry.Write(BitConverter.GetBytes(file.Name.Length), 6, 7);
                entry.Write(file.Hash, 8, 23);

                var enc = new UTF8Encoding();
                entry.Write(enc.GetBytes(file.Name), 24, file.Name.Length - 1);

                _dataList.Concat(entry.ToArray());
            }
            return _dataList;
        }
    }
}