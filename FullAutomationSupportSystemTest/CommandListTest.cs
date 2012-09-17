using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FullAutomationSupportSystem
{
    class CommandListManagerTest
    {
        [Test]
        public void コマンドリストの最初の名前を取得()
        {
            Assert.True(CommandListManager.GetInstance()[0].Name == "バッチ実行");
        }
        [Test]
        public void コマンドリスト数を取得()
        {
            Assert.True(CommandListManager.GetInstance().Count() == 2);
        }
    }
}
