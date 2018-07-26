using System.Collections.Generic;
using CapPuccino.Util;
using CapPuccino.Opcodes;
using System;

namespace CapPuccino.Core
{
    public class JcBytecodeDecoder
    {
        private List<IOpcode> _opcodes;

        public JcBytecodeDecoder()
        {
        }

        public void Decode(byte[] buff, int off, int len = -1)
        {
            StreamNavigator sn = new StreamNavigator(buff, off, len);
            _opcodes = new List<IOpcode>();
            while (!sn.EoB)
            {
                _opcodes.Add(DecodeInsAndAdvance(sn));
            }
        }

        public void Decode(StreamNavigator sn)
        {
            _opcodes = new List<IOpcode>();
            while (!sn.EoB)
            {
                _opcodes.Add(DecodeInsAndAdvance(sn));
            }
        }


        public IList<IOpcode> Opcodes => _opcodes.AsReadOnly();

        #region private methods
        private IOpcode DecodeInsAndAdvance(StreamNavigator sn)
        {
            // peak-only, full advance is made on an opcode class side!
            JcOpcodes op = (JcOpcodes)sn.PeakByte();
            switch (op)
            {
                case JcOpcodes.aaload:
                case JcOpcodes.aastore:
                case JcOpcodes.aconst_null:
                case JcOpcodes.aload_0:
                case JcOpcodes.aload_1:
                case JcOpcodes.aload_2:
                case JcOpcodes.aload_3:
                case JcOpcodes.areturn:
                case JcOpcodes.arraylength:
                case JcOpcodes.astore_0:
                case JcOpcodes.astore_1:
                case JcOpcodes.astore_2:
                case JcOpcodes.astore_3:
                case JcOpcodes.athrow:
                case JcOpcodes.baload:
                case JcOpcodes.bastore:
                case JcOpcodes.dup:
                case JcOpcodes.dup2:
                case JcOpcodes.i2b:
                case JcOpcodes.i2s:
                case JcOpcodes.iadd:
                case JcOpcodes.iaload:
                case JcOpcodes.iand:
                case JcOpcodes.iastore:
                case JcOpcodes.icmp:
                case JcOpcodes.iconst_m1:
                case JcOpcodes.iconst_0:
                case JcOpcodes.iconst_1:
                case JcOpcodes.iconst_2:
                case JcOpcodes.iconst_3:
                case JcOpcodes.iconst_4:
                case JcOpcodes.iconst_5:
                case JcOpcodes.idiv:
                case JcOpcodes.iload_0:
                case JcOpcodes.iload_1:
                case JcOpcodes.iload_2:
                case JcOpcodes.iload_3:
                case JcOpcodes.imul:
                case JcOpcodes.ineg:
                case JcOpcodes.ior:
                case JcOpcodes.irem:
                case JcOpcodes.ireturn:
                case JcOpcodes.ishl:
                case JcOpcodes.ishr:
                case JcOpcodes.istore_0:
                case JcOpcodes.istore_1:
                case JcOpcodes.istore_2:
                case JcOpcodes.istore_3:
                case JcOpcodes.isub:
                case JcOpcodes.iushr:
                case JcOpcodes.ixor:
                case JcOpcodes.nop:
                case JcOpcodes.pop:
                case JcOpcodes.pop2:
                case JcOpcodes.Return:
                case JcOpcodes.s2b:
                case JcOpcodes.s2i:
                case JcOpcodes.sadd:
                case JcOpcodes.saload:
                case JcOpcodes.sand:
                case JcOpcodes.sastore:
                case JcOpcodes.sconst_m1:
                case JcOpcodes.sconst_0:
                case JcOpcodes.sconst_1:
                case JcOpcodes.sconst_2:
                case JcOpcodes.sconst_3:
                case JcOpcodes.sconst_4:
                case JcOpcodes.sconst_5:
                case JcOpcodes.sdiv:
                case JcOpcodes.sload_0:
                case JcOpcodes.sload_1:
                case JcOpcodes.sload_2:
                case JcOpcodes.sload_3:
                case JcOpcodes.smul:
                case JcOpcodes.sneg:
                case JcOpcodes.sor:
                case JcOpcodes.srem:
                case JcOpcodes.sreturn:
                case JcOpcodes.sshl:
                case JcOpcodes.sshr:
                case JcOpcodes.sstore_0:
                case JcOpcodes.sstore_1:
                case JcOpcodes.sstore_2:
                case JcOpcodes.sstore_3:
                case JcOpcodes.ssub:
                case JcOpcodes.sushr:
                case JcOpcodes.sxor:
                    return new NoOperandsOpcode(sn);

                case JcOpcodes.aload:
                case JcOpcodes.astore:
                case JcOpcodes.bipush:
                case JcOpcodes.bspush:
                case JcOpcodes.dup_x:
                case JcOpcodes.getfield_a:
                case JcOpcodes.getfield_b:
                case JcOpcodes.getfield_s:
                case JcOpcodes.getfield_i:
                case JcOpcodes.getfield_a_this:
                case JcOpcodes.getfield_b_this:
                case JcOpcodes.getfield_s_this:
                case JcOpcodes.getfield_i_this:
                case JcOpcodes._goto:
                case JcOpcodes.if_acmpeq:
                case JcOpcodes.if_acmpne:
                case JcOpcodes.if_scmpeq:
                case JcOpcodes.if_scmpne:
                case JcOpcodes.if_scmplt:
                case JcOpcodes.if_scmpge:
                case JcOpcodes.if_scmpgt:
                case JcOpcodes.if_scmple:
                case JcOpcodes.ifeq:
                case JcOpcodes.ifne:
                case JcOpcodes.iflt:
                case JcOpcodes.ifge:
                case JcOpcodes.ifgt:
                case JcOpcodes.ifle:
                case JcOpcodes.ifnonnull:
                case JcOpcodes.ifnull:
                case JcOpcodes.iload:
                case JcOpcodes.istore:
                case JcOpcodes.newarray:
                case JcOpcodes.putfield_a:
                case JcOpcodes.putfield_b:
                case JcOpcodes.putfield_s:
                case JcOpcodes.putfield_i:
                case JcOpcodes.putfield_a_this:
                case JcOpcodes.putfield_b_this:
                case JcOpcodes.putfield_s_this:
                case JcOpcodes.putfield_i_this:
                case JcOpcodes.ret:
                case JcOpcodes.sload:
                case JcOpcodes.sstore:
                case JcOpcodes.swap_x:
                    return new SingleByteOperandOpcode(sn);

                case JcOpcodes.anewarray:
                case JcOpcodes.getfield_a_w:
                case JcOpcodes.getfield_b_w:
                case JcOpcodes.getfield_s_w:
                case JcOpcodes.getfield_i_w:
                case JcOpcodes.getstatic_a:
                case JcOpcodes.getstatic_b:
                case JcOpcodes.getstatic_s:
                case JcOpcodes.getstatic_i:
                case JcOpcodes.goto_w:
                case JcOpcodes.if_acmpeq_w:
                case JcOpcodes.if_acmpne_w:
                case JcOpcodes.if_scmpeq_w:
                case JcOpcodes.if_scmpne_w:
                case JcOpcodes.if_scmplt_w:
                case JcOpcodes.if_scmpge_w:
                case JcOpcodes.if_scmpgt_w:
                case JcOpcodes.if_scmple_w:
                case JcOpcodes.ifeq_w:
                case JcOpcodes.ifne_w:
                case JcOpcodes.iflt_w:
                case JcOpcodes.ifge_w:
                case JcOpcodes.ifgt_w:
                case JcOpcodes.ifle_w:
                case JcOpcodes.ifnonnull_w:
                case JcOpcodes.ifnull_w:
                case JcOpcodes.invokespecial:
                case JcOpcodes.invokestatic:
                case JcOpcodes.invokevirtual:
                case JcOpcodes.jsr:
                case JcOpcodes._new:
                case JcOpcodes.putfield_a_w:
                case JcOpcodes.putfield_b_w:
                case JcOpcodes.putfield_s_w:
                case JcOpcodes.putfield_i_w:
                case JcOpcodes.putstatic_a:
                case JcOpcodes.putstatic_b:
                case JcOpcodes.putstatic_s:
                case JcOpcodes.putstatic_i:
                case JcOpcodes.sipush:
                case JcOpcodes.sspush:
                    return new SingleShortOperandOpcode(sn);

                case JcOpcodes.checkcast:
                case JcOpcodes.iinc_w:
                case JcOpcodes.instanceof:
                case JcOpcodes.sinc_w:
                    return new ByteShortOperandOpcode(sn);

                case JcOpcodes.iinc:
                case JcOpcodes.sinc:
                    return new TwoBytesOperandOpcode(sn);

                case JcOpcodes.iipush:
                    return new UintOperandOpcode(sn);

                case JcOpcodes.invokeinterface:
                    return new InvokeInterfaceOpcode(sn);

                case JcOpcodes.ilookupswitch:
                    return new IlookupSwitchOpcode(sn);

                case JcOpcodes.itableswitch:
                    return new ItableSwitchOpcode(sn);

                case JcOpcodes.slookupswitch:
                    return new SlookupSwitchOpcode(sn);

                case JcOpcodes.stableswitch:
                    return new StableSwitchOpcode(sn);

                default:
                    throw new Exception("Undefined opcode: " + op.ToString("X"));
            };
        }
        #endregion
    }
}
