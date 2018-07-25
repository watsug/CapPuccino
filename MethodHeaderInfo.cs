using CapPuccino.Util;

namespace CapPuccino
{
    public class MethodHeaderInfo
    {
        protected byte _bitfield;
        private byte _bitfield2;

        public static MethodHeaderInfo Factory(StreamNavigator sn)
        {
            MethodHeaderInfo mhi = new MethodHeaderInfo();
            mhi._bitfield = sn.GetByte();
            mhi._bitfield2 = sn.GetByte();
            return mhi;
        }

        public byte Flags => (byte)((_bitfield >> 4) & 0x0f);
        public virtual byte MaxStack => (byte)(_bitfield & 0x0f);
        public virtual byte NArgs => (byte)((_bitfield2 >> 4) & 0x0f);
        public virtual byte MaxLocals => (byte)(_bitfield2 & 0x0f);
    }
}
