using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2P_Common
{
    public class TextPackage :PackageBase
    {
        public string Text { get; private set; }

        public TextPackage(string text)
        {
            Type = PackageType.Text;
            Data = Encoding.UTF8.GetBytes(text);
            Init();
        }
    }
}
