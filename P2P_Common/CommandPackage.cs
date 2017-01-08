using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public class CommandPackage : PackageBase
    {
        public CommandType Command { get; private set; }

        public CommandPackage(params string[] args)
        {
            Type = PackageType.Commond;
            Command = CommandType.TryConncet;
            Data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(args));
            Init();
        }
    }
}
