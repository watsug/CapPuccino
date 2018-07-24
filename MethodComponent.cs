using CapPuccino.Util;
using System.Collections.Generic;

namespace CapPuccino
{
    public class MethodComponent
    {
        private byte _tag;
        private ushort _size;
        private byte _handlerCount;
        private ExceptionHandlerInfo[] _exceptionHandlers;
        private List<MethodInfo> _methods = new List<MethodInfo>();

        private MethodComponent()
        {
        }

        public byte Tag => _tag;
        public ushort Size => _size;
        public ExceptionHandlerInfo[] ExceptionHandlers => _exceptionHandlers;
        public List<MethodInfo> Methods => _methods;

        public static MethodComponent Factory(StreamNavigator sn)
        {
            MethodComponent c = new MethodComponent();
            c._tag = sn.GetByte();
            c._size = sn.GetUshort();
            byte handler_count = sn.GetByte();
            c._exceptionHandlers = new ExceptionHandlerInfo[handler_count];
            for (int i = 0; i <  handler_count; i++)
            {
                c._exceptionHandlers[i] = ExceptionHandlerInfo.Factory(sn);
            }
            return c;
        }
    }
}
