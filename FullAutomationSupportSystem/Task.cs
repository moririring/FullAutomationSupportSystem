using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FullAutomationSupportSystemTest
{
    public class TaskData
    {
        public string Name { get; set; }
        public string OutputFolder { get; set; }
        public string ProjectFolder { get; set; }
        public string LogFolder { get; set; }
        public string Repository { get; set; }
    }

    public class Task
    {
        private List<TaskData> TaskDataList = new List<TaskData>();

        public bool Add(TaskData data)
        {
            if (Directory.Exists(data.ProjectFolder) == false)
            {
                return false;
            }
            TaskDataList.Add(data);
            return true;
        }

        public void Clear()
        {
            TaskDataList.Clear();
        }

        public int Count()
        {
            return TaskDataList.Count;
        }

        public TaskData this[int i]
        {
            get { return TaskDataList[i]; }
        }
    }

}
