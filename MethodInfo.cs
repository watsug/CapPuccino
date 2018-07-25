using CapPuccino.Opcodes;
using CapPuccino.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapPuccino
{
    public class MethodInfo
    {
        private MethodHeaderInfo _mhi;
        private List<IOpcode> _bytecode;

        public static MethodInfo Factory(StreamNavigator sn)
        {
            MethodInfo mi = new MethodInfo();
            mi._mhi = MethodHeaderInfoFactory.Factory(sn);
            mi._bytecode = 
        }
    }
}
