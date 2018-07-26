namespace CapPuccino.Util
{
    public class Util
    {
        public static ushort SwapUInt16(ushort val)
        {
            ushort tmp = 0;
            tmp = (ushort)(val >> 8);
            tmp = (ushort)(tmp | ((val & 0xff) << 8));
            return (ushort)tmp;
        }

        public static uint SwapUInt32(uint val)
        {
            uint tmp = 0;
            tmp = val >> 24;
            tmp = tmp | ((val & 0xff0000) >> 8);
            tmp = tmp | ((val & 0xff00) << 8);
            tmp = tmp | ((val & 0xff) << 24);
            return tmp;
        }
    }
}