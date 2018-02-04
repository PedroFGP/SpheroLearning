using System;
using System.IO;
using System.Net.Sockets;

namespace Sphero
{
    public struct PacketReceivedEventArgs
    {
        private SpheroPacket packet;
        public SpheroPacket Packet
        {
            get
            {
                return packet;
            }
        }

        public PacketReceivedEventArgs(SpheroPacket packet)
        {
            this.packet = packet;
        }
    }

    public delegate void PacketReceivedHandler(PacketReceivedEventArgs e);

    public class SpheroListener
    {
        private byte[] readBuffer = new byte[1024];
        private DataQueue unconstructedData = new DataQueue();

        public event PacketReceivedHandler PacketReceived;

        public SpheroListener(Sphero sphero)
        {
            if (sphero == null || sphero.Stream == null)
            {
                throw new InvalidOperationException("Cannot attach listener to invalid sphero object");
            }
            
            NetworkStream strm = sphero.Stream;

            if (strm.CanRead)
            {
                strm.BeginRead(readBuffer, 0, 1024, ReadCallback, strm);
            }
        }

        public void ReadCallback(IAsyncResult result)
        {
            if (this.cancelled)
            {
                // Return without reinitialising the async task
                return;
            }

            Stream strm = result.AsyncState as NetworkStream;
            if (strm != null)
            {
                int bytesRead = strm.EndRead(result);
                for (int i = 0; i < bytesRead; i++)
                {
                    unconstructedData.Enqueue(readBuffer[i]);
                }

                foreach (var packet in PacketReader.ReadPackets(unconstructedData))
                {
                    if (PacketReceived != null)
                    {
                        PacketReceived(new PacketReceivedEventArgs(packet));
                    }
                }

                strm.BeginRead(readBuffer, 0, 1024, ReadCallback, strm);
            }
        }

        private bool cancelled = false;

        public void Close()
        {
            this.cancelled = true;
            this.readBuffer = null;
            this.unconstructedData = null;
        }
    }
}
