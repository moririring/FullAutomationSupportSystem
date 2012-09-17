using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;

namespace FullAutomationSupportSystem
{
    public class CommandData
    {
        public bool Checked { get; set; }
        public CommandListType Type { get; set; }
        public string Name { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
    }

    public class TaskData : IEnumerable<CommandData>, IList<CommandData>
    {
        public bool Checked { get; set; }
        public string Name { get; set; }
        public string ProjectFolder { get; set; }
        public string LogFolder { get; set; }
        public string Repository { get; set; }
        public bool Timer { get; set; }
        public bool Interval { get; set; }

        private List<CommandData> CommandDataList = new List<CommandData>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<CommandData> GetEnumerator()
        {
            foreach (var data in CommandDataList)
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
            get { return CommandDataList[index]; }
            set { CommandDataList[index] = value; }
        }

        public void Add(CommandData item)
        {
            CommandDataList.Add(item);
        }

        public void Clear()
        {
            CommandDataList.Clear();
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
            get { return CommandDataList.Count(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(CommandData item)
        {
            throw new NotImplementedException();
        }
#if zero
        //objと自分自身が等価のときはtrueを返す
        public override bool Equals(System.Object obj)
        {
            if ((object)obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            TaskData c = (TaskData)obj;
            return base.Equals(obj);
        }

        public bool Equals(TaskData p)
        {
            foreach (var data in p)
            {
                //this.Add(data);
            }

            return base.Equals((TaskData)p);
        }
#endif
    }

    [DataContract]
    public class TaskManager : IEnumerable<TaskData>, IList<TaskData>
    {
        [DataMember]
        private List<TaskData> TaskDataList = new List<TaskData>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerator<TaskData> GetEnumerator()
        {
            foreach (TaskData data in TaskDataList)
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

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public TaskData this[int index]
        {
            get { return TaskDataList[index]; }
            set { TaskDataList[index] = value; } 
        }

        public void Add(TaskData item)
        {
            TaskDataList.Add(item);
        }

        public void Clear()
        {
            TaskDataList.Clear();
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
            get { return TaskDataList.Count(); }
        }

        public bool IsReadOnly
        {
            get { throw new NotImplementedException(); }
        }

        public bool Remove(TaskData item)
        {
            throw new NotImplementedException();
        }
  
    }

}
