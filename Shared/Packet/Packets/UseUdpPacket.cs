using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace Shared.Packet.Packets;

[Packet(PacketType.UseUdp)]
public struct UseUdpPacket : IPacket
{
    public bool UseUdp;

    public short Size => 0x04;

    public void Serialize(Span<byte> data)
    {
        MemoryMarshal.Write(data, ref UseUdp);
    }

    public void Deserialize(ReadOnlySpan<byte> data)
    {
        UseUdp = MemoryMarshal.Read<bool>(data);
    }
}