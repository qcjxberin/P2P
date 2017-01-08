using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P2P_Common;
using Newtonsoft.Json;
using System.Text;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CommandPackage package = new CommandPackage("192.168.0.200","6765");
            
            PackageBase a = JsonConvert.DeserializeObject<PackageBase>(Encoding.UTF8.GetString(package.Body));
            switch (a.Type)
            {
                case PackageType.Commond:
                    package = a as CommandPackage;
                    break;
                case PackageType.Text:
                    break;
                case PackageType.Image:
                    break;
                case PackageType.Video:
                    break;
                case PackageType.Sound:
                    break;
                default:
                    break;
            }
        }
    }
}
