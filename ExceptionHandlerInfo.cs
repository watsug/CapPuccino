using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public class ExceptionHandlerInfo
    {
        [FieldOffset(0)] public ushort start_offset;
        [FieldOffset(2)] public ushort bitfield;
        [FieldOffset(4)] public ushort handler_offset;
        [FieldOffset(6)] public ushort catch_type_index;
    }
}
