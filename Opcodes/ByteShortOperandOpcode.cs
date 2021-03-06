﻿using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class ByteShortOperandOpcode : OpcodeBase
    {
        private byte _operand1;
        private ushort _operand2;

        public ByteShortOperandOpcode(StreamNavigator sn)
            : base(sn)
        {
            _operand1 = sn.GetByte();
            _operand2 = sn.GetUshort();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": operand1={0} ({0:X}h), operand2={1} ({1:X}h)",
                _operand1, _operand2);
        }
    }
}