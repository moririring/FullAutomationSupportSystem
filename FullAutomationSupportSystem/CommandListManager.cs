using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.IO;

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
                 Param1Txt = "バッチファイルを選んでください",
                 Param1Type = CommandListParamType.File,
                 Param2Txt = "引数があれば入力してください",
                 Param2Type = CommandListParamType.OneLine,
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
        delegate string CommandListRun(string param1, string param2);
        public string Run(CommandListType idx, string param1, string param2)
        {
            CommandListRun run = null;
            if (idx == CommandListType.Bat)
            {
                run = BatRun;
            }
            if (idx == CommandListType.File)
            {
                run = FileRun;
            }
            return run(param1, param2);
        }
        static public string BatRun(string param1, string param2)
        {
            var fileName = param1;
            if (File.Exists(fileName) == false) return "ファイルが存在しない";
            //止まらないバッチを作る
            var stream = "";
            using (StreamReader sr = new StreamReader(param1))
            {
                while (sr.EndOfStream == false)
                {
                    string line = sr.ReadLine();
                    //pauseはスルー
                    if (line.Trim().ToLower() != "pause")
                    {
                        stream += line + Environment.NewLine;
                    }
                }
                sr.Close();
            }
            //かぶらないファイル名を作る
            int co = 0;
            while (true)
            {
                var sameName = Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName) + co++ + Path.GetExtension(fileName));
                if (File.Exists(sameName) == false)
                {
                    fileName = sameName;
                    break;
                }
            }
            //空っぽファイル
            if (stream == "") return "ファイルの中身が空";
            File.WriteAllText(fileName, stream);
            var process = Process.Start(fileName, param2);
            process.WaitForExit();
            File.Delete(fileName);
            return "成功";
        }
        static public string FileRun(string param1, string param2)
        {
            var fileName = param1;
            if (File.Exists(fileName) == false) return "ファイルが存在しない";
            var process = Process.Start(fileName, param2);
            process.WaitForExit();
            return "成功";
        }
    }
}
