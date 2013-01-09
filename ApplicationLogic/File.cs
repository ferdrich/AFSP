using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSP.ApplicationLogic
{
    internal class File
    {
        public byte[] Hash { get; set; } //MD5
        public string Name { get; set; }
        public int Size { get; set; } //in kByte
        public string Path { get; set; } //Typ?
        public string Owner { get; set; } //Pseudonym
    }
}