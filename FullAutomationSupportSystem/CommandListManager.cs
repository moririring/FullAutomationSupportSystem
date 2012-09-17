using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace FullAutomationSupportSystem
{
    public enum CommandListType
    {
        Bat,
        File,
    }
    public enum CommandListParamType
    {
        Null,
        OneLine,
        MultiLine,
        File,
        TrueFalse,
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
        private static CommandListManager singleton = new CommandListManager();
        private CommandListManager()
        {
        }
        public static CommandListManager GetInstance()
        {
            return singleton;
        }

        private List<CommandListData> CommandListDataList = new List<CommandListData>
        {
             new CommandListData()
             {
                 Type = CommandListType.Bat,
                 Name = "バッチ実行",
                 CommandListTxt = "バッチを実行します", 
                 Param1Txt = "バッチファイルのフルパスを入力してください",
                 Param1Type = CommandListParamType.File,
                 Param2Txt = "true : pauseを無視する\r\nfalse : pauseを無視しない",
                 Param2Type = CommandListParamType.TrueFalse,
             },
             new CommandListData()
             {
                 Type = CommandListType.File,
                 Name = "ファイル実行",
                 CommandListTxt = "ファイルを実行します", 
                 Param1Txt = "ファイルのフルパスを入力してください",
                 Param1Type = CommandListParamType.OneLine,
                 Param2Txt = "",
                 Param2Type = CommandListParamType.Null,
                 
             },
        };
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
        public CommandListData this[int idx]
        {
            get { return CommandListDataList[idx]; }
        }

        //実行処理（これだとデリケード使う意味なし）
        delegate void CommandListRun(string param1, string param2);
        public void Run(CommandListType idx, string param1, string param2)
        {
            CommandListRun run = null;
            if (idx == CommandListType.Bat)
            {
                run = BatRun;
            }
            run(param1, param2);
        }
        static public void BatRun(string param1, string param2)
        {
            if (param2 == "true")
            {
            }
            Process.Start(param1);
        }
    }
}
