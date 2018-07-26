using System;
using System.Runtime.InteropServices;

namespace CapPuccino.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public class ExceptionHandlerInfo
    {
        [FieldOffset(0)] public ushort start_offset;
        [FieldOffset(2)] public ushort bitfield;
        [FieldOffset(4)] public ushort handler_offset;
        [FieldOffset(6)] public ushort catch_type_index;

        public void CorrectEndianness()
        {
            if (BitConverter.IsLittleEndian)
            {
                start_offset = Util.Util.SwapUInt16(start_offset);
                bitfield = Util.Util.SwapUInt16(bitfield);
                handler_offset = Util.Util.SwapUInt16(handler_offset);
                catch_type_index = Util.Util.SwapUInt16(catch_type_index);
            }
        }
    }
}
