using System;
using System.IO;
using System.IO.Compression;

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
                foreach (var entry in  arch.Entries)
                {
                    switch (entry.Name.ToLower())
                    {
                        case "descriptor.cap":
                        {
                            using (BinaryReader rd = new BinaryReader(entry.Open()))
                            {
                                StreamNavigator sn = new StreamNavigator(rd.ReadBytes((int)rd.BaseStream.Length), 0);
                                desc = DescriptorComponent.Factory(sn);
                            }
                        } break;
                        case "method.cap":
                        {
                            using (BinaryReader rd = new BinaryReader(entry.Open()))
                            {
                                StreamNavigator sn = new StreamNavigator(rd.ReadBytes((int)rd.BaseStream.Length), 0);
                                methods = MethodComponent.Factory(sn);
                            }
                        } break;
                    }
                }
                using (BinaryReader rd = new BinaryReader(File.OpenRead(args[0])))
                {
                    byte[] method = rd.ReadBytes((int) rd.BaseStream.Length);

                    StreamNavigator sn = new StreamNavigator(method, 0);

                    MethodComponent c = MethodComponent.Factory(sn);
                    if (c.Tag != 0x07)
                    {
                        throw new Exception("Component type not supported: " + c.Tag.ToString("X"));
                    }

                    JcBytecodeDecoder dec = new JcBytecodeDecoder();
                    //dec.Decode(bcode, 0);

                    //using (TextWriter wr = new IndentedTextWriter(new StreamWriter(File.Create(args[1]))))
                    //{
                    //    foreach (var opcode in dec.Opcodes)
                    //    {
                    //        wr.WriteLine(opcode.ToString());
                    //    }
                    //}
                }
            }
        }
    }
}
