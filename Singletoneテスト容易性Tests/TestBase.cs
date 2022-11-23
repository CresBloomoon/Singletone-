using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singletoneテスト容易性;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletoneテスト容易性Tests
{
    [TestClass]
    public abstract class TestBase
    {
        [TestInitialize]
        public void TestInitialize()
        {
            SettingA.PowerMode = false;
        }
    }
}
