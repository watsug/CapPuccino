using System;
using System.IO;
using CapPuccino.Util;

namespace CapPuccino.Core
{
    public class DescriptorComponent
    {
        private byte _tag;
        private ushort _size;
        private byte _classCount;
        private ClassDescriptorInfo[] _classes;
        private TypeDescriptorInfo _types;

        public static DescriptorComponent Factory(StreamNavigator sn, MethodComponent methods)
        {
            DescriptorComponent c = new DescriptorComponent();
            c._tag = sn.GetByte();
            c._size = sn.GetUshort();
            c._classCount = sn.GetByte();

            c._classes = new ClassDescriptorInfo[c._classCount];
            for (int i = 0; i < c._classCount; i++)
            {
                c._classes[i] = ClassDescriptorInfo.Factory(sn, methods);
            }
            // TODO:
            // c._types = ...
            return c;
        }

        public void Dump(TextDump dump, int ident)
        {
            dump.WriteLine(ident, $"Class count: {_classCount}");

            dump.WriteLine(ident, "");
            dump.WriteLine(ident, "Classes:");
            foreach (var cdi in _classes)
            {
                cdi.Dump(dump, ident + 1);
            }
        }
    }
}