namespace CapPuccino
{
    public class DescriptorComponent
    {
        byte tag
        ushort size
        byte class_count
        class_descriptor_info classes[class_count]
        type_descriptor_info types
    }
}