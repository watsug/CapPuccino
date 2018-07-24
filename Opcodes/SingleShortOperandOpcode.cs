using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class SingleShortOperandOpcode : OpcodeBase
    {
        private ushort _operand1;

        public SingleShortOperandOpcode(StreamNavigator sn)
            : base(sn)
        {
            _operand1 = sn.GetUshort();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": operand1={0} ({0:X}h)", _operand1);
        }
    }
}