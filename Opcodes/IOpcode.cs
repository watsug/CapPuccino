namespace CapPuccino.Opcodes
{
    public interface IOpcode
    {
        int Position { get; }
        JcOpcodes Opcode { get; }
    }
}