namespace CapPuccino
{
    public class ClassDescriptorInfo
    {
        private byte _token;
        private byte _access_flags;
        private ClassRef _this_class_ref;
        private byte _interface_count;
        private ushort _field_count;
        private ushort _method_count;
        private ClassRef[] _interfaces;
        field_descriptor_info fields[field_count]
        method_descriptor_info methods[method_count]
    }
}