using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;
using RazorEngine;

namespace FullAutomationSupportSystem
{
    [DataContract]
    public class CommandData
    {
        public CommandData()
        {
            Param1 = "";
            Param2 = "";
        }
        [DataMember(Order = 0)]
        public bool Checked { get; set; }
        [DataMember(Order = 1)]
        public CommandListType Type { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Param1 { get; set; }
        [DataMember(Order = 4)]
        public string Param2 { get; set; }

        public CommandData(XmlReader reader)
        {
            if (reader.ReadToFollowing("Checked"))
            {
                Checked = reader.ReadElementContentAsBoolean();
            }
            if (reader.ReadToFollowing("Type"))
            {
                Type = (CommandListType)Enum.Parse(typeof(CommandListType), reader.ReadElementContentAsString());
            }
            if (reader.ReadToFollowing("Name"))
            {
                Name = reader.ReadElementContentAsString();
            }
            if (reader.ReadToFollowing("Param1"))
            {
                Param1 = reader.ReadElementContentAsString();
            }
            if (reader.ReadToFollowing("Param2"))
            {
                Param2 = reader.ReadElementContentAsString();
            }
        }
    }
    [DataContract]
    public class CommandList : IEnumerable<CommandData>, IList<CommandData>
    {
        [DataMember]
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
            commandDataList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            commandDataList.RemoveAt(index);
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
    public class RunLogHTMLData
    {
        public string TaskName { set; get; }
        public string TaskNameLink { set; get; }
        public string LogTime { set; get; }
        public string LogTimeLink { set; get; }
    };
    public class RunLogHTMLDatas
    {
        public List<RunLogHTMLData> Datas;
    };


    [DataContract]
    public class TaskData : ICloneable
    {
        [CollectionDataContract]
        public class  ProjectFolderClass :List<string> {}

        public TaskData()
        {
            ProjectPaths = new ProjectFolderClass();
            LogNumber = -1;
        }
        [DataMember(Order = 0)]
        public bool Checked { get; set; }
        [DataMember(Order = 1)]
        public string Name { get; set; }
        [DataMember(Order = 2)]
        public string ExportPath { get; set; }
        [DataMember(Order = 3)]
        public string ProjectPath { get; set; }
        public ProjectFolderClass ProjectPaths { get; set; }
        [DataMember(Order = 4)]
        public string LogPath { get; set; }
        [DataMember(Order = 5)]
        public string Repository { get; set; }
        [DataMember(Order = 6)]
        public bool Timer { get; set; }
        [DataMember(Order = 7)]
        public bool Span { get; set; }
        [DataMember(Order = 8)]
        public CommandList CommandDataList = new CommandList();
        [DataMember(Order = 9)]
        public int LogNumber { get; set; }

        public void Load(XmlReader reader)
        {
            if (reader.ReadToFollowing("Checked"))
            {
                Checked = reader.ReadElementContentAsBoolean();
            }
            if (reader.ReadToFollowing("Name"))
            {
                Name = reader.ReadElementContentAsString();
            }
            if (reader.ReadToFollowing("ExportPath"))
            {
                ExportPath = reader.ReadElementContentAsString();
            }
            if (reader.ReadToFollowing("ProjectPath"))
            {
                ProjectPath = reader.ReadElementContentAsString();
            }
            //if (reader.ReadToFollowing("ProjectFolder"))
            //{
            //    ProjectPath.Clear();
            //    while (reader.Read())
            //    {
            //        if (reader.NodeType == XmlNodeType.Text)
            //        {
            //            ProjectPath.Add(reader.ReadString());
            //        }
            //        else if (reader.NodeType == XmlNodeType.EndElement)
            //        {
            //            if (reader.Name == "ProjectFolder")
            //            {
            //                break;
            //            }
            //        }
            //    }
            //}
            if (reader.ReadToFollowing("LogPath"))
            {
                LogPath = reader.ReadElementContentAsString();
            }
            if (reader.ReadToFollowing("Repository"))
            {
                Repository = reader.ReadElementContentAsString();
            }
            if (reader.ReadToFollowing("Timer"))
            {
                Timer = reader.ReadElementContentAsBoolean();
            }
            if (reader.ReadToFollowing("Span"))
            {
                Span = reader.ReadElementContentAsBoolean();
            }
            //if (reader.ReadElementContentAs("LogNumber"))
            {
                //LogNumber = reader.ReadContentAsInt();
            }
        }

        public string LastRunTime { get; set; }

        readonly static public string RunLogHistoryName = "RunLogHistory";
        readonly static public string RunLogNow = "RunLogNow";
        readonly static public string RunLogHTML = "RunLog";
        readonly static public System.Text.Encoding RunLogEncoding = System.Text.Encoding.UTF8;

        public void SetLastRun()
        {
            LastRunTime = "-";
            var file = Path.Combine(LogPath, ExportPath + "\\RunLogHistory.txt");
            if (File.Exists(file))
            {
                string line = "";
                using (StreamReader sr = new StreamReader(file))
                {
                    sr.ReadLine();
                    line = sr.ReadLine();
                }
                if (line != "" && line.Split(',').Length != 0)
                {
                    LastRunTime = line.Split(',')[0];
                }
            }
        }
        public bool WriteRunLogHTML(bool first)
        {
            var logHTMLFile = Path.Combine(LogPath, RunLogHTML + ".html");
            if (Directory.Exists(Path.GetDirectoryName(logHTMLFile)) == false)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(logHTMLFile));
            }
            var runLogDatas = new List<RunLogHTMLData>();
            var files = Directory.GetFiles(LogPath, "RunLogHistory.txt", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var folder = Path.GetFileName(Path.GetDirectoryName(file));
                string logTime = "-";
                if (folder != ExportPath || first == false)
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
                RunLogHTMLData data = new RunLogHTMLData();
                data.TaskNameLink = folder + "\\RunLogNow.txt";
                data.TaskName = taskName;
                data.LogTime = logTime;
                data.LogTimeLink = folder + "\\RunLogHistory.txt";
                runLogDatas.Add(data);
            }
            var template = File.ReadAllText("RunLog.cshtml");
            var result = Razor.Parse(template, new RunLogHTMLDatas(){ Datas = runLogDatas });
            using (var sw = new StreamWriter(logHTMLFile, false, RunLogEncoding))
            {
                sw.Write(result);
            }
            return true;
        }
        public bool WriteRunLogNow(bool first, string write)
        {
            var logTxtFile = Path.Combine(LogPath, ExportPath + "\\" + RunLogNow + ".txt");
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
        public bool WriteRunLogHistory(string write)
        {
            var logCSVFile = Path.Combine(LogPath, ExportPath + "\\" + RunLogHistoryName + ".txt");
            string ReadToEnd = "";
            if (File.Exists(logCSVFile) == true)
            {
                using (var sr = new StreamReader(logCSVFile))
                {
                    sr.ReadLine();
                    while (sr.Peek() > -1)
                    {
                        ReadToEnd += sr.ReadLine() + Environment.NewLine;
                    }
                }
            }
            using (var sw = new StreamWriter(logCSVFile, false, RunLogEncoding))
            {
                sw.WriteLine("開始時間,終了時間,実行時間");
                sw.WriteLine(write);
                if(ReadToEnd != "")
                {
                    sw.WriteLine(ReadToEnd);
                }
            }
            return true;
        }
        public object Clone()
        {
            var clone = new TaskData();
            using (MemoryStream stream = new MemoryStream())
            {
                var serializer = new DataContractSerializer(typeof(TaskData));
                serializer.WriteObject(stream, this);
                stream.Position = 0;
                clone = (TaskData)serializer.ReadObject(stream);
            }
            return clone;
        }
    }
    [DataContract]
    public class TaskList : IEnumerable<TaskData>, IList<TaskData>, ICloneable
    {
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
                    var serializer = new DataContractSerializer(typeof(TaskList));
                    serializer.WriteObject(xw, this);
                    bSuccess = true;
                }
            }
            return bSuccess;
        }
        public bool Load(string fileName)
        {
            if (File.Exists(fileName) == false) return false;
            bool bSuccess = false;

            XmlReaderSettings settings = new XmlReaderSettings();
            using (var reader = XmlReader.Create(fileName, settings))
            {
                TaskData task = new TaskData();
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "TaskData")
                        {
                            task.Load(reader);
                        }
                        if (reader.Name == "CommandData")
                        {
                            CommandData command = new CommandData(reader);
                            task.CommandDataList.Add(command);
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        if (reader.Name == "TaskData")
                        {
                            taskDataList.Add((TaskData)task.Clone());
                            //初期化。コンストラクタと同一化するのがベター
                            task.CommandDataList.Clear();
                        }
                    }
                }
            }
            bSuccess = true;
            //読み込むファイルを開く
            //using (var fs = new FileStream(fileName, FileMode.Open))
            //{
            //    var serializer = new DataContractSerializer(typeof(List<TaskData>));
            //    //taskDataList = (List<TaskData>)serializer.ReadObject(fs);
            //    fs.Close();
            //    bSuccess = true;
            //}
            return bSuccess;
        }


        [DataMember]
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
            taskDataList.Insert(index,item);
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
