using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MethodDescriptorInfo
    {
        [FieldOffset(0)] public byte token;
        [FieldOffset(1)] public byte access_flags;
        [FieldOffset(2)] public ushort method_offset;
        [FieldOffset(4)] public ushort type_offset;
        [FieldOffset(6)] public ushort bytecode_count;
        [FieldOffset(8)] public ushort exception_handler_count;
        [FieldOffset(10)] public ushort exception_handler_index;
    }
}