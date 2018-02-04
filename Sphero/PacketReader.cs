using System.Collections.Generic;

namespace Sphero
{
    class PacketReader
    {
        public static IEnumerable<SpheroPacket> ReadPackets(DataQueue queue)
        {
            List<SpheroPacket> packets = new List<SpheroPacket>();
            // If any data exists at the beginning of the queue that isn't 0xFF, it should be discarded
            while (queue.ReadToSOP1())
            {
                if (queue.Count < 2)
                {
                    // No SOP2, wait for further data
                    return packets;
                }

                //SOP1 SOP2 MRSP SEQ DLEN <data> CHK
                // Examine packet for viable structure
                byte SOP2 = queue[1];

                if (SOP2 == 0xFF)
                {
                    // Synchronous Packet
                    if (queue.Count < 5)
                    {
                        // No Data length value, wait for further data
                        return packets;
                    }

                    byte dlen = queue[4];

                    int expectedPacketLength = 5 + dlen;

                    if (expectedPacketLength <= queue.Count)
                    {
                        byte[] data = queue.GetRange(0, expectedPacketLength).ToArray();
                        queue.RemoveRange(0, expectedPacketLength);
                        SpheroResponsePacket reconstructedPacket = SpheroResponsePacket.Parse(data);
                        
                        if (reconstructedPacket != null)
                        {
                            packets.Add(reconstructedPacket);
                        }
                    }
                    else
                    {
                        // Incomplete message. Leave and wait for further data
                        return packets;
                    }
                }
                else if (SOP2 == 0xFE)
                {
                    // Asynchronous Packet
                    //SOP1 SOP2 IDCODE DLEN-MSB DLEN-LSB <data> CHK
                    if (queue.Count < 5)
                    {
                        // No Data length value, wait for further data
                        return packets;
                    }

                    byte dlenmsb = queue[3];
                    byte dlenlsb = queue[4];
                    
                    uint dlen = (uint)((dlenmsb << 8) | dlenlsb);

                    int expectedPacketLength = (int)(5 + dlen);

                    if (expectedPacketLength <= queue.Count)
                    {
                        byte[] data = queue.GetRange(0, expectedPacketLength).ToArray();
                        queue.RemoveRange(0, expectedPacketLength);
                        SpheroAsyncPacket reconstructedPacket = SpheroAsyncPacket.Parse(data);

                        if (reconstructedPacket != null)
                        {
                            packets.Add(reconstructedPacket);
                        }
                    }
                    else
                    {
                        // Incomplete message. Leave and wait for further data
                        return packets;
                    }
                }

            }

            return packets;
        }
    }
}
