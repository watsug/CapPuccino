using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class OpcodeBase : IOpcode
    {
        private int _pos;
        private JcOpcodes _opcode;

        public OpcodeBase(StreamNavigator sn)
        {
            _pos = sn.Position;
            _opcode = (JcOpcodes)sn.GetByte();
        }

        public int Position => _pos;
        public JcOpcodes Opcode => _opcode;

        public override string ToString()
        {
            string tmp = _opcode.ToString();
            if (tmp.StartsWith("_"))
            {
                tmp = tmp.Substring(1);
            }
            return tmp;
        }
    }
}