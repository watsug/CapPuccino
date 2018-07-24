using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class UintOperandOpcode : OpcodeBase
    {
        private uint _operand1;

        public UintOperandOpcode(StreamNavigator sn)
            : base(sn)
        {
            _operand1 = sn.GetUint();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": operand1={0} ({0:X}h)", _operand1);
        }
    }
}