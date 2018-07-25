using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StaticFieldRef
    {
        // internal_ref
        [FieldOffset(0)] byte padding;
        [FieldOffset(1)] ushort offset;

        // external_ref
        [FieldOffset(0)] byte package_token;
        [FieldOffset(1)] byte class_token;
        [FieldOffset(2)] byte token;
    }
}