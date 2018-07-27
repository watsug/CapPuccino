using CapPuccino.Util;

namespace CapPuccino.Core
{
    public class MethodDescriptor
    {
        public MethodDescriptorInfo MethodDescriptorInfo { get; private set; }
        public MethodInfo MethodInfo { get; private set; }

        public MethodDescriptor(MethodDescriptorInfo mdi, MethodComponent methods)
        {
            this.MethodDescriptorInfo = mdi;
            if (null != methods)
            {
                StreamNavigator sn = new StreamNavigator(methods.Methods, mdi.method_offset - 1);
                this.MethodInfo = MethodInfo.Factory(sn, mdi.bytecode_count);
            }
        }

        public void Dump(TextDump dump, int ident)
        {
            dump.WriteLine(ident, $"Token: {MethodDescriptorInfo.token}");
            dump.WriteLine(ident, $"Access Flags: {MethodDescriptorInfo.access_flags}");
            dump.WriteLine(ident, $"Method Offset: {MethodDescriptorInfo.method_offset}");
            dump.WriteLine(ident, $"Bytecode Count: {MethodDescriptorInfo.bytecode_count}");
            dump.WriteLine(ident, $"Exception Handler Count: {MethodDescriptorInfo.exception_handler_count}");
            dump.WriteLine(ident, $"Exception Handler Index: {MethodDescriptorInfo.exception_handler_index}");

            dump.WriteLine(ident, "");
            dump.WriteLine(ident, "MethodInfo:");
            MethodInfo.Dump(dump, ident + 1);
        }
    }
}