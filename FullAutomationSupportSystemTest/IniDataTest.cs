using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FullAutomationSupportSystem
{
    class IniDataTest
    {
        [Test]
        public void 初期化データ()
        {
            IniData ini = new IniData();
            Assert.True(ini != null);
        }
    }
}
