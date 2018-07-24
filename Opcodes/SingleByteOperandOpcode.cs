using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class SingleByteOperandOpcode : OpcodeBase
    {
        private byte _operand1;

        public SingleByteOperandOpcode(StreamNavigator sn)
            : base(sn)
        {
            _operand1 = sn.GetByte();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": operand1={0} ({0:X}h)", _operand1);
        }
    }
}