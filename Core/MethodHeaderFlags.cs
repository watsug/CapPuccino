using System;

namespace CapPuccino.Core
{
    [Flags]
    public enum MethodHeaderFlags : byte
    {
        ACC_EXTENDED = 0x08,
        ACC_ABSTRACT = 0x04
    }
}