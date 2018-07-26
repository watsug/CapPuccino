using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FieldDescriptorInfo
    {
        [FieldOffset(0)] public byte token;
        [FieldOffset(1)] public byte access_flags;
        [FieldOffset(2)] public FieldRef field_ref; // 6 bytes
        [FieldOffset(8)] public ushort primitive_type;
        [FieldOffset(8)] public ushort reference_type;
    }
}