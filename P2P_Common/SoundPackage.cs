using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public class SoundPackage:PackageBase
    {
        public SoundPackage()
        {
            Type = PackageType.Sound;
            Init();
        }
        public override void Init()
        {
            //TODO:重写Init()
        }
    }
}
