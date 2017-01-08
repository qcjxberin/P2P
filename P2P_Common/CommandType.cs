using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public enum CommandType
    {
        //线程对象
        StartAssist,
        StopAssist,
        StartP2P,
        StopP2P,
        //过程动作
        ReportIPAndPort,
        TryConncet,
        StopConncet
    }
}
