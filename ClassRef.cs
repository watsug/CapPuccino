using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ClassRef
    {
        [FieldOffset(0)] public ushort internal_class_ref;
        [FieldOffset(0)] public byte package_token;
        [FieldOffset(1)] public byte class_token;
    }
}