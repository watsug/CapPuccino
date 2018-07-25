using CapPuccino.Util;

namespace CapPuccino
{
    public class ExtendedMethodHeaderInfo : MethodHeaderInfo
    {
        private byte _max_stack;
        private byte _nargs;
        private byte _max_locals;

        public static MethodHeaderInfo Factory(StreamNavigator sn)
        {
            ExtendedMethodHeaderInfo emhi = new ExtendedMethodHeaderInfo();
            emhi._bitfield = sn.GetByte();
            emhi._max_stack = sn.GetByte();
            emhi._nargs = sn.GetByte();
            emhi._max_locals = sn.GetByte();
            return emhi;
        }

        public override byte MaxStack => _max_stack;
        public override byte NArgs => _nargs;
        public override byte MaxLocals => _max_locals;
    }
}
