using System.Collections.Generic;

using CapPuccino.Util;
using CapPuccino.Opcodes;

namespace CapPuccino.Core
{
    public class MethodInfo
    {
        private MethodHeaderInfo _mhi;
        private IList<IOpcode> _bytecode;

        public static MethodInfo Factory(StreamNavigator sn, int bcodeLen)
        {
            MethodInfo mi = new MethodInfo {_mhi = MethodHeaderInfoFactory.Factory(sn)};
            if (bcodeLen > 0)
            {
                byte[] bcode = sn.GetData(bcodeLen);
                JcBytecodeDecoder dec = new JcBytecodeDecoder();
                dec.Decode(bcode, 0);
                mi._bytecode = dec.Opcodes;
            }
            return mi;
        }

        public void Dump(TextDump dump, int ident)
        {
            dump.WriteLine(ident, $"Flags: {_mhi.Flags}");
            dump.WriteLine(ident, $"MaxStack: {_mhi.MaxStack}");
            dump.WriteLine(ident, $"NArgs: {_mhi.NArgs}");
            dump.WriteLine(ident, $"MaxLocals: {_mhi.MaxLocals}");

            if (null != _bytecode)
            {
                dump.WriteLine(ident, "Opcodes:");
                foreach (var opcode in _bytecode)
                {
                    dump.WriteLine(ident + 1, opcode.ToString());
                }
            }
        }
    }
}
