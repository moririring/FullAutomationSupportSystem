using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace FullAutomationSupportSystem
{
    [DataContract]
    public class SaveData
    {
        [DataMember]
        public TaskList TaskList { set; get; }
        [DataMember]
        public OptionData OptionData { set; get; }
    }


    [DataContract]
    public class XMLSaveData
    {
        [DataMember]
        public SaveData SaveData = new SaveData();
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
                    var serializer = new DataContractSerializer(typeof(XMLSaveData));
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
                CommandData command = new CommandData();
                bool bTaskData = false;
                bool bCommandData = false;
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "TaskData")
                        {
                            bTaskData = true;
                        }
                        if (reader.Name == "CommandData")
                        {
                            bCommandData = true;
                        }
                        if (bCommandData)
                        {
                            command.XmlReader(reader);
                        }
                        else if (bTaskData)
                        {
                            task.XmlReader(reader);
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.EndElement)
                    {
                        if (reader.Name == "TaskData")
                        {
                            this.SaveData.TaskList.Add((TaskData)task.Clone());
                            //初期化。コンストラクタと同一化するのがベター
                            task.CommandDataList.Clear();
                            bTaskData = false;
                        }
                        if (reader.Name == "CommandData")
                        {
                            task.CommandDataList.Add((CommandData)command.Clone());
                            bCommandData = false;
                        }
                    }
                }
            }
            bSuccess = true;
            return bSuccess;
        }
    }
}
