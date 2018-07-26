using System;

namespace CapPuccino.Core
{
    [Flags]
    public enum MethodAccessFlags : byte
    {
        ACC_PUBLIC = 0x01,
        ACC_PRIVATE = 0x02,
        ACC_PROTECTED = 0x04,
        ACC_STATIC = 0x08,
        ACC_FINAL = 0x10,
        ACC_ABSTRACT = 0x40,
        ACC_INIT = 0x80
    }
}