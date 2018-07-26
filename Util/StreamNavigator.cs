using System;
using System.Runtime.InteropServices;

namespace CapPuccino.Util
{
    public class StreamNavigator
    {
        private byte[] _buff;
        private int _off;
        private int _len;

        public StreamNavigator(byte[] buff, int off, int len = -1)
        {
            _buff = buff;
            _off = off;
            _len = len > 0 ? len : _buff.Length - _off;
        }

        public int Position => _off;

        public bool EoB
        {
            get { return _off >= _len; }
        }

        public byte PeakByte()
        {
            return _buff[_off];
        }

        public byte GetByte()
        {
            byte ret = _buff[_off];
            _off++;
            return ret;
        }

        public ushort GetUshort()
        {
            ushort ret = (ushort)((_buff[_off] << 8) | _buff[_off+1]);
            _off+=2;
            return ret;
        }

        public uint GetUint()
        {
            ushort ret = (ushort)((_buff[_off] << 24) | (_buff[_off+1] << 16) | (_buff[_off+2] << 8) | _buff[_off + 3]);
            _off += 4;
            return ret;
        }

        public byte[] GetData(int size)
        {
            //throw new ArgumentException("Not enough data...");
            byte[] data = new byte[size];
            Array.Copy(_buff, _off, data, 0, size);
            _off += size;
            return data;
        }

        public T GetStruct<T>()
        {
            int rawSize = Marshal.SizeOf(typeof(T));
            byte[] rawData = GetData(rawSize);
            IntPtr buffer = Marshal.AllocHGlobal(rawSize);
            Marshal.Copy(rawData, 0, buffer, rawSize);
            T retobj = (T)Marshal.PtrToStructure(buffer, typeof(T));
            Marshal.FreeHGlobal(buffer);
            return retobj;
        }
    }
}
