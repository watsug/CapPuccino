using System.Collections.Generic;

using CapPuccino.Util;
using CapPuccino.Opcodes;

namespace CapPuccino.Core
{
    public class MethodInfo
    {
        private MethodHeaderInfo _mhi;
        private List<IOpcode> _bytecode;

        public static MethodInfo Factory(StreamNavigator sn)
        {
            MethodInfo mi = new MethodInfo {_mhi = MethodHeaderInfoFactory.Factory(sn)};
            //mi._bytecode = 
            return mi;
        }
    }
}
