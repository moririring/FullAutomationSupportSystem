using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace FullAutomationSupportSystem
{
    [DataContract(Name = "コマンドデータクラス")]
    public class CommandData
    {
        public CommandData()
        {
            Param1 = "";
            Param2 = "";
        }
        [DataMember(Name = "チェック")]
        public bool Checked { get; set; }
        [DataMember(Name = "タイプ")]
        public CommandListType Type { get; set; }
        [DataMember(Name = "名前")]
        public string Name { get; set; }
        [DataMember(Name = "パラメータ1")]
        public string Param1 { get; set; }
        [DataMember(Name = "パラメータ2")]
        public string Param2 { get; set; }
    }
    [DataContract(Name = "コマンドリストクラス")]
    public class CommandList : IEnumerable<CommandData>, IList<CommandData>
    {
        [DataMember(Name = "コマンドデータリスト")]
        private List<CommandData> commandDataList = new List<CommandData>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<CommandData> GetEnumerator()
        {
            foreach (var data in commandDataList)
            {
                yield return data;
            }
        }
        public int IndexOf(CommandData item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, CommandData item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public CommandData this[int index]
        {
            get { return commandDataList[index]; }
            set { commandDataList[index] = value; }
        }

        public void Add(CommandData item)
        {
            commandDataList.Add(item);
        }

        public void Clear()
        {
            commandDataList.Clear();
        }

        public bool Contains(CommandData item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(CommandData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return commandDataList.Count(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(CommandData item)
        {
            throw new NotImplementedException();
        }
    }
    [DataContract(Name = "タスクデータクラス")]
    public class TaskData
    {
        [DataMember(Name = "チェック")]
        public bool Checked { get; set; }
        [DataMember(Name = "名前")]
        public string Name { get; set; }
        [DataMember(Name = "出力フォルダ名")]
        public string ExportFolder { get; set; }
        [DataMember(Name = "プロジェクトフォルダ")]
        public string ProjectFolder { get; set; }
        [DataMember(Name = "ログフォルダ")]
        public string LogFolder { get; set; }
        [DataMember(Name = "リポジトリ")]
        public string Repository { get; set; }
        [DataMember(Name = "タイマー")]
        public bool Timer { get; set; }
        [DataMember(Name = "スパン")]
        public bool Span { get; set; }
        [DataMember(Name = "コマンドデータリスト")]
        public CommandList CommandDataList = new CommandList();

        public DateTime LastRun { get; set; }
    }
    [DataContract(Name = "タスクリストクラス")]
    public class TaskList : IEnumerable<TaskData>, IList<TaskData>, ICloneable
    {
        readonly static public string RunLogHistoryName = "RunLogHistory" ;
        readonly static public string RunLogNow = "RunLogNow";
        readonly static public string RunLogHTML = "RunLog";
        readonly static public Encoding RunLogEncoding = Encoding.UTF8;

        public bool WriteRunLogHTML(bool first, TaskData task)
        {
            var logHTMLFile = Path.Combine(task.LogFolder, RunLogHTML + ".html");
            if (Directory.Exists(Path.GetDirectoryName(logHTMLFile)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(logHTMLFile));
            }
            using (var sw = new StreamWriter(logHTMLFile, false, RunLogEncoding))
            {
                sw.WriteLine("<meta http-equiv='content-type' content='text/html; charset=UTF-8'>");
                sw.WriteLine("<table border='1' cellspacing='0' cellpadding='3'>");
                sw.WriteLine("<thead>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th>タスク名</th>");
                sw.WriteLine("<th>最終更新時間</th>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</thead>");
                sw.WriteLine("<tbody>");
                sw.WriteLine("<tr>");
                var files = Directory.GetFiles(task.LogFolder, "RunLogHistory.txt", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    var folder = Path.GetFileName(Path.GetDirectoryName(file));
                    string logTime = "-";
                    if (folder != task.ExportFolder || first == false)
                    {
                        string line = "";
                        using (StreamReader sr = new StreamReader(file))
                        {
                            sr.ReadLine();
                            line = sr.ReadLine();
                        }
                        logTime = line.Split(',')[0];
                    }
                    string taskName = "";
                    var nowFile = file.Replace("RunLogHistory", "RunLogNow");
                    using (StreamReader sr = new StreamReader(nowFile))
                    {
                        taskName = sr.ReadLine();
                    }

                    sw.WriteLine("<td><a href = '" + task.ExportFolder + "\\RunLogNow.txt'>" + taskName + "</a></td>");
                    sw.WriteLine("<td><a href = '" + task.ExportFolder + "\\RunLogHistory.txt'>" + logTime + "</a></td>");
                }
                sw.WriteLine("</tr>");
                sw.WriteLine("</tbody>");
                sw.WriteLine("</table>");
            }
            return true;
        }
        public bool WriteRunLogNow(bool first, TaskData task, string write)
        {
            var logTxtFile = Path.Combine(task.LogFolder, task.ExportFolder + "\\" + RunLogNow + ".txt");
            if (Directory.Exists(Path.GetDirectoryName(logTxtFile)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(logTxtFile));
            }
            using (var sw = new StreamWriter(logTxtFile, !first, RunLogEncoding))
            {
                sw.WriteLine(write);
            }
            return true;
        }
        public bool WriteRunLogHistory(TaskData task, string write)
        {
            var logCSVFile = Path.Combine(task.LogFolder, task.ExportFolder + "\\" + RunLogHistoryName + ".txt");

            string ReadToEnd = "";
            using (var sr = new StreamReader(logCSVFile))
            {
                sr.ReadLine();
                while (sr.Peek() > -1)
                {
                    ReadToEnd += sr.ReadLine() + Environment.NewLine;
                }
            }
            using (var sw = new StreamWriter(logCSVFile, false, RunLogEncoding))
            {
                sw.WriteLine("開始時間,終了時間,実行時間");
                sw.WriteLine(write);
                sw.WriteLine(ReadToEnd);
            }
            return true;
        }

        [DataMember(Name = "タスクデータリスト")]
        private List<TaskData> taskDataList = new List<TaskData>();
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TaskData> GetEnumerator()
        {
            foreach (TaskData data in taskDataList)
            {
                yield return data;
            }
        }

        public int IndexOf(TaskData item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, TaskData item)
        {
            throw new NotImplementedException();
        }

        public TaskData this[int index]
        {
            get { return taskDataList[index]; }
            set { taskDataList[index] = value; }
        }

        public void Add(TaskData item)
        {
            taskDataList.Add(item);
        }

        public void Clear()
        {
            taskDataList.Clear();
        }

        public bool Contains(TaskData item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(TaskData[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return taskDataList.Count(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(TaskData item)
        {
            return taskDataList.Remove(item);
        }
        public void RemoveAt(int index)
        {
            taskDataList.RemoveAt(index);
        }

        public ExtensionDataObject ExtensionData { get; set; }
        public bool Save(string fileName)
        {
            if (Directory.Exists(Path.GetDirectoryName(fileName)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            }
            bool bSuccess = false;
            using (var ms = new FileStream(fileName, FileMode.Create))
            {
                using (var xw = XmlWriter.Create(ms, new XmlWriterSettings { Indent = true }))
                {
                    var serializer = new DataContractSerializer(typeof(List<TaskData>));
                    serializer.WriteObject(xw, taskDataList);
                    bSuccess = true;
                }
            }
            return bSuccess;
        }
        public bool Load(string fileName)
        {
            if (File.Exists(fileName) == false) return false;
            bool bSuccess = false;
            //読み込むファイルを開く
            using (var fs = new FileStream(fileName, FileMode.Open))
            {
                var serializer = new DataContractSerializer(typeof(List<TaskData>));
                taskDataList = (List<TaskData>)serializer.ReadObject(fs);
                fs.Close();
                bSuccess = true;
            }
            return bSuccess;
        }

        public object Clone()
        {
            var clone = new TaskList();
            using (MemoryStream stream = new MemoryStream())
            {
                var serializer = new DataContractSerializer(typeof(TaskList));
                serializer.WriteObject(stream, this);
                stream.Position = 0;
                clone = (TaskList)serializer.ReadObject(stream);
            }
            return clone;
        }

    }
}
