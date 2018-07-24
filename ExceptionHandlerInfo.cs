using CapPuccino.Util;

namespace CapPuccino
{
    public class ExceptionHandlerInfo
    {
        private ushort _start_offset;
        private ushort _bitfield;
        private ushort _handler_offset;
        private ushort _catch_type_index;

        private ExceptionHandlerInfo()
        {
        }

        public static ExceptionHandlerInfo Factory(StreamNavigator sn)
        {
            ExceptionHandlerInfo exHandlerInfo = new ExceptionHandlerInfo();
            exHandlerInfo._start_offset = sn.GetUshort();
            exHandlerInfo._bitfield = sn.GetUshort();
            exHandlerInfo._handler_offset = sn.GetUshort();
            exHandlerInfo._catch_type_index = sn.GetUshort();
            return exHandlerInfo;
        }
    }
}
