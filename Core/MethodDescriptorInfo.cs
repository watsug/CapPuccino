using System;
using System.Runtime.InteropServices;

namespace CapPuccino.Core
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MethodDescriptorInfo
    {
        [FieldOffset(0)] public byte token;
        [FieldOffset(1)] public MethodAccessFlags access_flags;
        [FieldOffset(2)] public ushort method_offset;
        [FieldOffset(4)] public ushort type_offset;
        [FieldOffset(6)] public ushort bytecode_count;
        [FieldOffset(8)] public ushort exception_handler_count;
        [FieldOffset(10)] public ushort exception_handler_index;

        public void CorrectEndianness()
        {
            if (BitConverter.IsLittleEndian)
            {
                method_offset = Util.Util.SwapUInt16(method_offset);
                type_offset = Util.Util.SwapUInt16(type_offset);
                bytecode_count = Util.Util.SwapUInt16(bytecode_count);
                exception_handler_count = Util.Util.SwapUInt16(exception_handler_count);
                exception_handler_index = Util.Util.SwapUInt16(exception_handler_index);
            }
        }
    }
}