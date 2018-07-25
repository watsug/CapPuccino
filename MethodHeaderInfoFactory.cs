using CapPuccino.Util;

namespace CapPuccino
{
    public abstract class MethodHeaderInfoFactory
    {
        public static MethodHeaderInfo Factory(StreamNavigator sn)
        {
            byte flags = sn.PeakByte();
            return ((flags & 0x80) != 0)
                ? ExtendedMethodHeaderInfo.Factory(sn)
                : MethodHeaderInfo.Factory(sn);
        }
    }
}
