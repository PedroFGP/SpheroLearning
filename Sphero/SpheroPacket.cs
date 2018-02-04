using System;
using System.Linq;

namespace Sphero
{
    public static class CommandSequencer
    {
        private static byte value = 255;
        public static byte Next
        {
            get
            {
                value = (byte)((value + 1) % 256);
                return value;
            }
        }
    }

    public abstract class SpheroPacket
    {
        protected byte[] data = null;

        public byte[] Data
        {
            get { return data; }
        }

        public abstract String FullName
        {
            get;
        }

        public byte SOP1
        {
            get
            {
                return data[0];
            }
        }

        public byte SOP2
        {
            get
            {
                return data[1];
            }
        }

        public byte Checksum
        {
            get { return data[data.Length - 1]; }
            set { data[data.Length - 1] = value; }
        }

        protected static byte CalculateChecksum(byte[] data)
        {
            if (data == null || data.Length < 4) throw new InvalidOperationException("Cannot calculate a checksum on missing packet data");
            uint sum = 0;
            for (int i = 2; i < data.Length - 1; i++)
            {
                sum += data[i];
            }
            return ((byte)~(sum % 256));
        }

        public string Hex
        {
            get
            {
                return BitConverter.ToString(this.data);
            }
        }

        public override string ToString()
        {
            return BitConverter.ToString(this.data);
        }
    }

    public class SpheroCommandPacket : SpheroPacket
    {
        public byte SequenceNumber
        {
            get
            {
                if (this.data != null && this.data.Length >= 5)
                {
                    return this.data[4];
                }
                return 0x00;
            }
        }

        public override string FullName
        {
            get
            {
                if (this.data[2] == (byte)DeviceID.DID_CORE)
                {
                    return ((CoreCommand)this.data[3]).FullName();
                }
                else if (this.data[2] == (byte)DeviceID.DID_SPHERO)
                {
                    return ((SpheroCommand)this.data[3]).FullName();
                }
                else
                {
                    return "";
                }
            }
        }

        public SpheroCommandPacket(SpheroCommand commandId,
           byte sequenceNumber, params byte[] packetData)
            : base()
        {
            this.data = new byte[7 + (packetData != null ? packetData.Length : 0)];

            this.data[0] = 0xFF;     // SOP1
            this.data[1] = 0xFF;     // SOP2
            this.data[2] = (byte)DeviceID.DID_SPHERO; // Device ID
            this.data[3] = (byte)commandId; // Command ID
            this.data[4] = sequenceNumber;

            if (packetData != null)
            {
                this.data[5] = (byte)(packetData.Length + 1);
                Array.Copy(packetData, 0, this.data, 6, packetData.Length);
            }
            else
            {
                this.data[5] = 0x01;
            }

            this.data[this.data.Length - 1] = CalculateChecksum(this.data);
        }
        public SpheroCommandPacket(CoreCommand commandId,
           byte sequenceNumber, params byte[] packetData)
            : base()
        {
            this.data = new byte[7 + (packetData != null ? packetData.Length : 0)];

            this.data[0] = 0xFF;     // SOP1
            this.data[1] = 0xFF;     // SOP2
            this.data[2] = (byte)DeviceID.DID_CORE; // Device ID
            this.data[3] = (byte)commandId; // Command ID
            this.data[4] = sequenceNumber;

            if (packetData != null)
            {
                this.data[5] = (byte)(packetData.Length + 1);
                Array.Copy(packetData, 0, this.data, 6, packetData.Length);
            }
            else
            {
                this.data[5] = 0x01;
            }

            this.data[this.data.Length - 1] = CalculateChecksum(this.data);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class SpheroResponsePacket : SpheroPacket
    {
        public ResponseCode ResponseCode
        {
            get { return (ResponseCode)data[2]; }
        }

        public override string FullName
        {
            get { return this.ResponseCode.FullName(); }
        }

        public byte SequenceNumber
        {
            get { return data[3]; }
        }

        private SpheroResponsePacket(byte[] data)
        {
            this.data = data;
        }

        public static SpheroResponsePacket Parse(byte[] data)
        {
            // Check packet minimum length
            if (data.Length < 6) { return null; }
            
            // SOP1 SOP2
            if (data[0] != 0xFF || data[1] != 0xFF) { return null; }
            
            // DLEN and overall packet length check
            byte dlen = data[4];
            if (data.Length != 5 + dlen) { return null; }

            // Verify Checksum
            if (CalculateChecksum(data) != data[data.Length - 1]) { return null; }

            // Packet is well formed
            return new SpheroResponsePacket(data);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class SpheroAsyncPacket : SpheroPacket
    {
        public AsyncIDCode IDCode
        {
            get { return (AsyncIDCode)data[2]; }
        }

        public override string FullName
        {
            get { return this.IDCode.FullName(); }
        }

        private SpheroAsyncPacket(byte[] data)
        {
            this.data = data;
        }

        public uint PayloadLength
        {
            get
            {
                return (uint)(((data[3] << 8) | data[4]) - 1);
            }
        }

        public static SpheroAsyncPacket Parse(byte[] data)
        {
            // Check packet minimum length
            if (data.Length < 6) { return null; }

            // SOP1 SOP2
            if (data[0] != 0xFF || data[1] != 0xFE) { return null; }

            // 2 byte DLEN and overall packet length check
            uint dlen = (uint)((data[3] << 8) | data[4]);
            
            if (data.Length != 5 + dlen) { return null; }

            // Verify Checksum
            if (CalculateChecksum(data) != data[data.Length - 1]) { return null; }

            // Packet is well formed
            return new SpheroAsyncPacket(data);
        }

        public override string ToString()
        {
            switch (this.IDCode)
            {
                case AsyncIDCode.OrbBasicPrint:
                    string ascii = System.Text.Encoding.ASCII.GetString(this.data, 5, (int)this.PayloadLength);
                    if (ascii.Last() == '\n')
                    {
                        // Remove \n character from the end of the line. The output window handles it's own terminal characters.
                        ascii = ascii.Substring(0, ascii.Length - 1); 
                    }
                    return ascii;
                case AsyncIDCode.OrbBasicErrorASCII:
                    string asciierr = System.Text.Encoding.ASCII.GetString(this.data, 5, (int)this.PayloadLength);
                    return asciierr;
                default:
                    return base.ToString();
            }
        }
    }
}
