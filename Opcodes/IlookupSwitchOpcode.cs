using CapPuccino.Util;
using System.Collections.Generic;

namespace CapPuccino.Opcodes
{
    public class IlookupSwitchOpcode : OpcodeBase
    {
        private ushort _default_offset;
        private ushort _pairs;
        private List<MatchOffset> _matchOffsets = new List<MatchOffset>();

        public struct MatchOffset
        {
            public uint Match;
            public ushort Offset;
        }

        public IlookupSwitchOpcode(StreamNavigator sn)
            : base(sn)
        {
            _default_offset = sn.GetUshort();
            _pairs = sn.GetUshort();

            ushort tmp = _pairs;
            while (tmp > 0)
            {
                _matchOffsets.Add(new MatchOffset() {Match = sn.GetUint(), Offset = sn.GetUshort() });
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