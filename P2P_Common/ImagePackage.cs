using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public class ImagePackage : PackageBase
    {
        public ImagePackage(byte[] image)
        {
            Type = PackageType.Image;
            Data = image;
            Init();
        }
    }
}
