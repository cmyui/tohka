using tohka.osu;

namespace tohka.osu
{
    public interface bSerializable
    {
        void ReadFromStream(SerializationReader sr);
        void WriteToStream(SerializationWriter sw);
    }

    public interface iSerializable
    {
        void WriteToStreamIrc(SerializationWriter sw);
    }
}
