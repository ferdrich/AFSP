using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSP.ApplicationLogic
{
    internal class FileList
    {
        public List<File> Files { get; set; }

        private FileList()
        {
            Files = null;
        }

        private FileList(List<File> files)
        {
            Files = files;
        }

        public void AddFile(File file)
        {
            Files.Add(file);
        }

        public bool DeleteFile(File file)
        {
            return Files.Remove(file);
        }
    }
}