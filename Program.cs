using CapPuccino.Util;
using System;
using System.CodeDom.Compiler;
using System.IO;

namespace CapPuccino
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BinaryReader rd = new BinaryReader(File.OpenRead(args[0])))
            {
                byte[] method = rd.ReadBytes((int)rd.BaseStream.Length);

                StreamNavigator sn = new StreamNavigator(method, 0);

                MethodComponent c = MethodComponent.Factory(sn);
                if (c.Tag != 0x07)
                {
                    throw new Exception("Component type not supported: " + c.Tag.ToString("X"));
                }

                JcBytecodeDecoder dec = new JcBytecodeDecoder();
                dec.Decode(bcode, 0);

                using (TextWriter wr = new IndentedTextWriter(new StreamWriter(File.Create(args[1]))))
                {
                    foreach (var opcode in dec.Opcodes)
                    {
                        wr.WriteLine(opcode.ToString());
                    }
                }
            }
        }
    }
}
