﻿using System.Runtime.InteropServices;

namespace CapPuccino
{
    [StructLayout(LayoutKind.Explicit)]
    public struct StaticFieldRef
    {
        // internal_ref
        [FieldOffset(0)] public byte padding;
        [FieldOffset(1)] public ushort offset;

        // external_ref
        [FieldOffset(0)] public byte package_token;
        [FieldOffset(1)] public byte class_token;
        [FieldOffset(2)] public byte token;
    }
}