namespace CapPuccino
{
    public class ClassRef
    {
        private ushort _internal_class_ref;

        public ushort InternalClassRef => _internal_class_ref;
        public byte PackageToken => (byte)(_internal_class_ref >> 8);
        public byte ClassToken => (byte)(_internal_class_ref & 0xff);
    }
}