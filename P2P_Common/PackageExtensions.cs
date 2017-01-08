using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public static class PackageExtensions
    {
        public static void SendPackage(this Socket socket, PackageBase package)
        {
            socket.SendAll(package.Head());
            socket.SendAll(package.Body);
        }

        private static void SendAll(this Socket socket, byte[] buffer)
        {
            long total = buffer.LongLength;
            while (total > 0)
            {
                int current = socket.Send(buffer);
                total -= current;
            }
        }

        public static PackageBase ReceivePackage(this Socket socket)
        {
            int head = BitConverter.ToInt32(socket.ReceiveAll(PackageBase.HeadSize), 0);
            //TODO:测试反序列化是否丢失数据
            return JsonConvert.DeserializeObject<PackageBase>(Encoding.UTF8.GetString(socket.ReceiveAll(head)));
        }

        public static byte[] ReceiveAll(this Socket socket, int total)
        {
            byte[] buffer = new byte[total];
            int offset = 0;
            int current = 0;
            while (total > 0)
            {
                current = socket.Receive(buffer, offset, total, SocketFlags.None);
                total -= current;
                offset += current;
            }
            return buffer;
        }
    }
}