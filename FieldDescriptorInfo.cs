namespace CapPuccino
{
    public class FieldDescriptorInfo
    {
        private byte _token;
        private byte _access_flags;
        union {
            static_field_ref static_field
            {
                class_ref class
                u1 token
            }
            instance_field
        }
        field_ref
        union
        {
            u2 primitive_type
            u2 reference_type
        }
        type
    }
}