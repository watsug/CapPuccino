using CapPuccino.Util;
using System.Collections.Generic;

namespace CapPuccino.Opcodes
{
    public class ItableSwitchOpcode : OpcodeBase
    {
        private ushort _default_offset;
        private uint _low;
        private uint _high;
        private List<ushort> _jumpOffsets = new List<ushort>();

        public ItableSwitchOpcode(StreamNavigator sn)
            : base(sn)
        {
            _default_offset = sn.GetUshort();
            _low = sn.GetUint();
            _high = sn.GetUint();

            uint tmp = _high - _low;
            while (tmp > 0)
            {
                _jumpOffsets.Add(sn.GetUshort());
                tmp--;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": default_offset={0} ({0:X}h), low={1} ({1:X}h), high={2} ({2:X}h)",
                _default_offset, _low, _high);
        }
    }
}