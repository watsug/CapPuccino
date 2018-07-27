using CapPuccino.Util;

namespace CapPuccino.Core
{
    public class ClassDescriptorInfo
    {
        private byte _token;
        private ClassAccessFlags _accessFlags;
        private ClassRef _thisClassRef;
        private byte _interfaceCount;
        private ushort _fieldCount;
        private ushort _methodCount;
        private ClassRef[] _interfaces;
        private FieldDescriptorInfo[] _fields;
        private MethodDescriptor[] _methods;

        public static ClassDescriptorInfo Factory(StreamNavigator sn, MethodComponent methods)
        {
            ClassDescriptorInfo cdi = new ClassDescriptorInfo
            {
                _token = sn.GetByte(),
                _accessFlags = (ClassAccessFlags)sn.GetByte(),
                _thisClassRef = sn.GetStruct<ClassRef>(),
                _interfaceCount = sn.GetByte(),
                _fieldCount = sn.GetUshort(),
                _methodCount = sn.GetUshort()
            };

            cdi._thisClassRef.CorrectEndianness();

            cdi._interfaces = new ClassRef[cdi._interfaceCount];
            cdi._fields = new FieldDescriptorInfo[cdi._fieldCount];
            cdi._methods = new MethodDescriptor[cdi._methodCount];

            int i = 0;
            for (i = 0; i < cdi._interfaceCount; i++)
            {
                cdi._interfaces[i] = sn.GetStruct<ClassRef>();
                cdi._interfaces[i].CorrectEndianness();
            }
            for (i = 0; i < cdi._fieldCount; i++)
            {
                cdi._fields[i] = sn.GetStruct<FieldDescriptorInfo>();
                cdi._fields[i].CorrectEndianness();
            }
            for (i = 0; i < cdi._methodCount; i++)
            {
                var mdi = sn.GetStruct<MethodDescriptorInfo>();
                mdi.CorrectEndianness();
                cdi._methods[i] = new MethodDescriptor(mdi, cdi._accessFlags.HasFlag(ClassAccessFlags.ACC_INTERFACE) ? null : methods);
            }
            return cdi;
        }

        public void Dump(TextDump dump, int ident)
        {
            dump.WriteLine(ident, $"Token: {_token}");
            dump.WriteLine(ident, $"Access Flags: {_accessFlags}");
            dump.WriteLine(ident, $"Method Count: {_methodCount}");

            dump.WriteLine(ident, "");
            dump.WriteLine(ident, "Methods:");
            foreach (var method in _methods)
            {
                dump.WriteLine(ident + 1, "");
                method.Dump(dump, ident + 1);
            }
        }
    }
}