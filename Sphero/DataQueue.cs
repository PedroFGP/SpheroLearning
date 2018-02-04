using System.Collections.Generic;

namespace Sphero
{
    public class DataQueue : List<byte>
    {
        public void Enqueue(byte value)
        {
            this.Add(value);
        }

        public byte Dequeue()
        {
            byte val = this[0];
            this.RemoveAt(0);
            return val;
        }

        public byte Peek()
        {
            return this[0];
        }

        public bool ReadToSOP1()
        {
            int sopIndex = this.IndexOf(0xFF);
            if (sopIndex < 0)
                return false;
            else if (sopIndex == 0)
            {
                return true;
            }
            else
            {
                this.RemoveRange(0, sopIndex - 1);
                return true;
            }
        }
    }

}
