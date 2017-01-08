using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public class VideoPackage : PackageBase
    {
        public VideoPackage(Stream video)
        {
            Type = PackageType.Video;
            Init();
        }

        public override void Init()
        {
            //TODO:重写Init()
        }
    }
}
