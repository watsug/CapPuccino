using CapPuccino.Util;

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
        public byte[] Methods { get; private set; }

        public static MethodComponent Factory(StreamNavigator sn)
        {
            MethodComponent c = new MethodComponent
            {
                Tag = sn.GetByte(),
                Size = sn.GetUshort()
            };

            int start = sn.Position;

            byte handlerCount = sn.GetByte();
            c.ExceptionHandlers = new ExceptionHandlerInfo[handlerCount];
            for (int i = 0; i <  handlerCount; i++)
            {
                c.ExceptionHandlers[i] = sn.GetStruct<ExceptionHandlerInfo>();
                c.ExceptionHandlers[i].CorrectEndianness();
            }

            c.Methods = sn.GetData(c.Size - (sn.Position - start));
            return c;
        }
    }
}
