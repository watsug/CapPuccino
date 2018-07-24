using CapPuccino.Util;

namespace CapPuccino.Opcodes
{
    public class InvokeInterfaceOpcode : OpcodeBase
    {
        private byte _args;
        private ushort _index;
        private byte _method;

        public InvokeInterfaceOpcode(StreamNavigator sn)
            : base(sn)
        {
            _args = sn.GetByte();
            _index = sn.GetUshort();
            _method = sn.GetByte();
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(": args={0} ({0:X}h), index={1} ({1:X}h), method={2} ({2:X}h)",
                _args, _index, _method);
        }
    }
}