using System.Net.Sockets;

namespace Sphero
{
    public struct PacketSentEventArgs
    {
        private SpheroPacket packet;
        public SpheroPacket Packet
        {
            get
            {
                return packet;
            }
        }

        public PacketSentEventArgs(SpheroPacket packet)
        {
            this.packet = packet;
        }
    }

    public delegate void PacketSentHandler(PacketSentEventArgs e);

    public class Sphero
    {
        private NetworkStream stream = null;
        public event PacketSentHandler PacketSent;

        public NetworkStream Stream
        {
            get { return stream; }
        }

        private SpheroListener listener = null;

        public SpheroListener Listener
        {
            get { return listener; }
        }

        public Sphero(NetworkStream connection)
        {
            this.stream = connection;
            this.listener = new SpheroListener(this);
        }

        public void SendPacket(SpheroPacket packet)
        {
            this.stream.Write(packet.Data, 0, packet.Data.Length);
            if (this.PacketSent != null)
            {
                this.PacketSent(new PacketSentEventArgs(packet));
            }
        }

        public void Close()
        {
            this.listener.Close();
            this.stream = null;
        }

    }
}
