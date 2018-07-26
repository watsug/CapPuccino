using CapPuccino.Util;
using System.Collections.Generic;

namespace CapPuccino.Core
{
    public class MethodComponent
    {
        private MethodComponent()
        {
        }

        public byte Tag { get; private set; }
        public ushort Size { get; private set; }
        public ExceptionHandlerInfo[] ExceptionHandlers { get; private set; }
        public MethodInfo[] Methods { get; }

        public static MethodComponent Factory(StreamNavigator sn)
        {
            MethodComponent c = new MethodComponent
            {
                Tag = sn.GetByte(),
                Size = sn.GetUshort()
            };

            byte handlerCount = sn.GetByte();
            c.ExceptionHandlers = new ExceptionHandlerInfo[handlerCount];
            for (int i = 0; i <  handlerCount; i++)
            {
                c.ExceptionHandlers[i] = sn.GetStruct<ExceptionHandlerInfo>();
                c.ExceptionHandlers[i].CorrectEndianness();
            }

            // TODO:
            // c._methods = ...
            return c;
        }
    }
}
