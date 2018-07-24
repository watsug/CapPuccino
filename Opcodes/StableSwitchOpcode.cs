using System.Collections.Generic;
using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class StableSwitchOpcode : OpcodeBase
    {
        private ushort _default_offset;
        private ushort _low;
        private ushort _high;
        private List<ushort> _jumpOffsets = new List<ushort>();

        public StableSwitchOpcode(StreamNavigator sn)
            : base(sn)
        {
            _default_offset = sn.GetUshort();
            _low = sn.GetUshort();
            _high = sn.GetUshort();

            int tmp = _high - _low;
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