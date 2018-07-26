using System;
using System.Runtime.InteropServices;

namespace CapPuccino.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ClassRef
    {
        [FieldOffset(0)] public ushort internal_class_ref;
        [FieldOffset(0)] public byte package_token;
        [FieldOffset(1)] public byte class_token;

        public void CorrectEndianness()
        {
            if (BitConverter.IsLittleEndian)
            {
                internal_class_ref = Util.Util.SwapUInt16(internal_class_ref);
            }
        }
    }
}