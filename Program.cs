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
                byte[] bcode = rd.ReadBytes((int)rd.BaseStream.Length);
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
