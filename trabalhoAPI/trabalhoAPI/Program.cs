using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace trabalhoAPI
{
    //CLiente
    class Program
    {

        enum FileType
        {
            TXT,
            JPG,
            PNG

        }
        class Pdu
        {
            public header h = new header();
            public FileContent u = new FileContent();
        }


        class header
        {
            public FileType fileType;
            public string filename;
        }


        class FileContent
        {
            public BinaryFormatter formatter;

        }



        static void Main(string[] args)
        {
            Pdu p = new Pdu();
            p.h.fileType = FileType.TXT;
            FileStream fs = new FileStream(@"C: \Users\joao\Desktop\Trabalho CM\WebApplication1\User.txt", FileMode.Open);
            p.u.formatter.Serialize

        }

    }
}
