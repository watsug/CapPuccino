using System;
using System.Runtime.InteropServices;

namespace CapPuccino.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FieldRef
    {
        [FieldOffset(0)] public StaticFieldRef static_field;
        [FieldOffset(0)] public ClassRef @class;
        [FieldOffset(2)] public byte token;

        public void CorrectEndianness()
        {
            if (BitConverter.IsLittleEndian)
            {
                static_field.CorrectEndianness();
                @class.CorrectEndianness();
            }
        }
    }
}