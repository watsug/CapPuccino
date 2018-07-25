using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FieldRef
    {
        [FieldOffset(0)] byte padding;

    }
}