using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace P2P_Common
{
    public class PackageBase
    {
        public const int HeadSize = 4;
        public byte[] Body { get; set; }
        public PackageType Type { get; set; }
        public byte[] Data { get; set; }

        public byte[] Head()
        {
            return BitConverter.GetBytes(Body.Length);
        }

        public virtual void Init()
        {
            Body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this));
        }
    }
}
