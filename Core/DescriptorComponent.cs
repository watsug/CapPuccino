using System;
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

        public static DescriptorComponent Factory(StreamNavigator sn)
        {
            DescriptorComponent c = new DescriptorComponent();
            c._tag = sn.GetByte();
            c._size = sn.GetUshort();
            c._classCount = sn.GetByte();

            c._classes = new ClassDescriptorInfo[c._classCount];
            for (int i = 0; i < c._classCount; i++)
            {
                c._classes[i] = ClassDescriptorInfo.Factory(sn);
            }
            // TODO:
            // c._types = ...
            return c;
        }
    }
}