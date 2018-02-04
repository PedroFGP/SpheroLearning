using System;
using System.Collections.Generic;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Net.Sockets;

namespace Sphero
{
    public enum FindResult { Success, Failure }
    public enum ConnectResult { Success, Failure}
    public delegate void FindCallbackHandler(FindResult result);
    public delegate void ConnectCallbackHandler(ConnectResult result);

    public class SpheroConnector
    {
        private DataQueue readQueue = new DataQueue();
        private List<byte[]> packets = new List<byte[]>();

        private Sphero sphero = null;

        public Sphero Sphero
        {
            get { return sphero; }
        }
        private BluetoothDeviceInfo deviceInfo = null;
        private BluetoothClient client = null;

        public bool DeviceFound
        {
            get
            {
                return deviceInfo != null;
            }
        }

        public void FindAsync(FindCallbackHandler callback)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(FindWork), callback);
        }

        private void FindWork(Object state)
        {
            Find();
            FindCallbackHandler callback = state as FindCallbackHandler;
            if (callback != null)
            {
                callback.Invoke(this.DeviceFound ? FindResult.Success : FindResult.Failure);
            }
        }

        public void Find()
        {
            client = new BluetoothClient();
            BluetoothDeviceInfo[] peers = client.DiscoverDevices();
            int deviceIndex = -1;
            for (int i = 0; i < peers.Length; i++)
            {
                if (peers[i].DeviceName.Contains("Sphero"))
                {
                    deviceIndex = i;
                    break;
                }
            }

            if (deviceIndex == -1) return;

            deviceInfo = peers[deviceIndex];
        }

        public void ConnectAsync(ConnectCallbackHandler callback)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(ConnectWork), callback);
        }

        private void ConnectWork(Object state)
        {
            Connect(5);
            ConnectCallbackHandler callback = state as ConnectCallbackHandler;
            if (callback != null)
            {
                callback.Invoke(this.sphero != null ? ConnectResult.Success : ConnectResult.Failure);
            }
        }

        public void Connect(int retries)
        {
            Guid serviceClass = BluetoothService.SerialPort;

            var ep = new BluetoothEndPoint(deviceInfo.DeviceAddress, serviceClass);
            NetworkStream strm = null;

            do
            {
                try
                {
                    client.Connect(ep);
                    strm = client.GetStream() as NetworkStream;
                }
                catch (SocketException)
                {
                    // A socket exception indicates the connection has failed, retry a specified number of times
                }
                catch
                {
                    this.sphero = null;
                    return;
                }
            }
            while (retries-- > 0 && strm == null);

            // If strm is null, we have run out of retries
            if (strm == null)
            {
                this.sphero = null;
                return;
            }

            this.sphero = new Sphero(strm);
        }

        public void Close()
        {
            if (sphero != null)
            {
                sphero.Close();
            }

            if (client != null && client.Connected)
            {
                client.Close();
            }

            this.deviceInfo = null;
            this.sphero = null;
        }
    }
} 
