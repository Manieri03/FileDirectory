using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndDirectoryLibrary
{
    public class File : FileAstratto
    {
        public long dimensione { get; set; }

        public File(string nome, Directory d) : base(nome, d) { }
    }
}
