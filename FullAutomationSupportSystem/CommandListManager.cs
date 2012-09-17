using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace FullAutomationSupportSystem
{
    public enum CommandListType
    {
        Bat,
    }
    public enum CommandListParamType
    {
        OneLine,
        MultiLine,
    }
    public class CommandListData
    {
        public CommandListType Type { get; set; }
        public string Name { get; set; }
        public string CommandListTxt { get; set; }
        public string Param1Txt { get; set; }
        public CommandListParamType Param1Type { get; set; }
        public string Param2Txt { get; set; }
        public CommandListParamType Param2Type { get; set; }
    }

    public class CommandListManager : IEnumerable<CommandListData>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<CommandListData> GetEnumerator()
        {
            foreach (CommandListData data in CommandListDataList)
            {
                yield return data;
            }
        }
        List<CommandListData> CommandListDataList = new List<CommandListData>
        {
             new CommandListData()
             {
                 Type = CommandListType.Bat,
                 Name = "バッチ実行",
                 CommandListTxt = "バッチを実行します", 
                 Param1Txt = "ファイルのフルパスを入力してください",
                 Param1Type = CommandListParamType.OneLine,
                 Param2Txt = "true:pauseする false:pauseしない",
                 Param2Type = CommandListParamType.OneLine
             },
        };
    }
}
