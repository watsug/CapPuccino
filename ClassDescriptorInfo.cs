using CapPuccino.Util;

namespace CapPuccino
{
    public class ClassDescriptorInfo
    {
        private byte _token;
        private byte _accessFlags;
        private ClassRef _thisClassRef;
        private byte _interfaceCount;
        private ushort _fieldCount;
        private ushort _methodCount;
        private ClassRef[] _interfaces;
        private FieldDescriptorInfo[] _fields;
        private MethodDescriptorInfo[] _methods;

        public static ClassDescriptorInfo Factory(StreamNavigator sn)
        {
            ClassDescriptorInfo cdi = new ClassDescriptorInfo
            {
                _token = sn.GetByte(),
                _accessFlags = sn.GetByte(),
                _thisClassRef = sn.GetStruct<ClassRef>(),
                _interfaceCount = sn.GetByte(),
                _fieldCount = sn.GetUshort(),
                _methodCount = sn.GetUshort()
            };

            cdi._interfaces = new ClassRef[cdi._interfaceCount];
            cdi._fields = new FieldDescriptorInfo[cdi._fieldCount];
            cdi._methods = new MethodDescriptorInfo[cdi._methodCount];

            int i = 0;
            for (i = 0; i < cdi._interfaceCount; i++)
            {
                cdi._interfaces[i] = sn.GetStruct<ClassRef>();
            }
            for (i = 0; i < cdi._fieldCount; i++)
            {
                cdi._fields[i] = sn.GetStruct<FieldDescriptorInfo>();
            }
            for (i = 0; i < cdi._methodCount; i++)
            {
                cdi._methods[i] = sn.GetStruct<MethodDescriptorInfo>();
            }
            return cdi;
        }


    }
}