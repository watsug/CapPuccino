using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FieldRef
    {
        [FieldOffset(0)] public StaticFieldRef static_field;
        [FieldOffset(0)] public ClassRef @class;
        [FieldOffset(2)] public byte token;
    }
}