using System.Collections.Generic;
using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class SlookupSwitchOpcode : OpcodeBase
    {
        private ushort _default_offset;
        private ushort _pairs;
        private List<MatchOffset> _matchOffsets = new List<MatchOffset>();

        public struct MatchOffset
        {
            public ushort Match;
            public ushort Offset;
        }

        public SlookupSwitchOpcode(StreamNavigator sn)
            : base(sn)
        {
            _default_offset = sn.GetUshort();
            _pairs = sn.GetUshort();

            ushort tmp = _pairs;
            while (tmp > 0)
            {
                _matchOffsets.Add(new MatchOffset() { Match = sn.GetUshort(), Offset = sn.GetUshort() });
                tmp--;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": default_offset={0} ({0:X}h), pairs={1} ({1:X}h)",
                       _default_offset, _pairs);
        }
    }
}