using System;

namespace CapPuccino.Core
{
    [Flags]
    public enum ClassAccessFlags : byte
    {
        ACC_PUBLIC = 0x01,
        ACC_FINAL = 0x10,
        ACC_INTERFACE = 0x40,
        ACC_ABSTRACT = 0x80
    }
}