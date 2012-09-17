using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FullAutomationSupportSystem
{
    public class CommandData
    {
        public bool Checked { get; set; }
        public string Name { get; set; }
        public string Param1 { get; set; }
        public string Param2 { get; set; }
    }

    public class TaskData
    {
        public bool Checked { get; set; }
        public string Name { get; set; }
        public string ProjectFolder { get; set; }
        public string LogFolder { get; set; }
        public string Repository { get; set; }

        public bool Timer { get; set; }
        public bool Interval { get; set; }

        private List<CommandData> CommandDataList = new List<CommandData>();

        public bool AddCommand(CommandData data)
        {
            CommandDataList.Add(data);
            return true;
        }
        public void ClearCommand()
        {
            CommandDataList.Clear();
        }
        public int CountCommand()
        {
            return CommandDataList.Count;
        }
        public CommandData this[int i]
        {
            get { return CommandDataList[i]; }
        }
        public void EditCommand(int idx, CommandData edit)
        {
            CommandDataList[idx] = edit;
        }

    }

    public class TaskManager
    {
        private List<TaskData> TaskDataList = new List<TaskData>();

        private bool CheckTaskData(TaskData data)
        {
            if (Directory.Exists(data.ProjectFolder) == false)
            {
                return false;
            }
            return true;
        }

        public bool AddTask(TaskData data)
        {
            if (CheckTaskData(data) == false)
            {
                return false;
            }
            TaskDataList.Add(data);
            return true;
        }
        public void ClearTask()
        {
            TaskDataList.Clear();
        }
        public int CountTask()
        {
            return TaskDataList.Count;
        }
        public TaskData this[int i]
        {
            get { return TaskDataList[i]; }
        }
        public bool EditTask(int idx, TaskData edit)
        {
            if (CheckTaskData(edit) == false)
            {
                return false;
            }
            TaskDataList[idx] = edit;
            return true;
        }
    }

}
