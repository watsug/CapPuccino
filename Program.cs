using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

using CapPuccino.Util;
using CapPuccino.Core;

namespace CapPuccino
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var arch = ZipFile.OpenRead(args[0]))
            {
                DescriptorComponent desc = null;
                MethodComponent methods = null;

                var methodCap = arch.Entries.Where(v => v.Name.ToLower() == "method.cap").SingleOrDefault();
                using (BinaryReader rd = new BinaryReader(methodCap.Open()))
                {
                    StreamNavigator sn = new StreamNavigator(rd.ReadBytes((int)rd.BaseStream.Length), 0);
                    methods = MethodComponent.Factory(sn);
                }

                var descriptorCap = arch.Entries.Where(v => v.Name.ToLower() == "descriptor.cap").SingleOrDefault();
                using (BinaryReader rd = new BinaryReader(descriptorCap.Open()))
                {
                    StreamNavigator sn = new StreamNavigator(rd.ReadBytes((int)rd.BaseStream.Length), 0);
                    desc = DescriptorComponent.Factory(sn, methods);
                }

                using (TextWriter wr = new StreamWriter(File.Create(args[0] + ".txt")))
                {
                    TextDump dump = new TextDump(wr);
                    desc.Dump(dump, 0);
                    wr.Flush();
                }
            }
        }
    }
}
