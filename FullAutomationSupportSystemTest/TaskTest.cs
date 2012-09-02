using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FullAutomationSupportSystemTest
{
    public class TaskTest
    {
        [Test]
        public void タスクに存在するパスで追加()
        {
            Task task = new Task();
            TaskData data = new TaskData();
            data.ProjectFolder = @"M:\program\vsht\vsht\VSHackathon20120428\T3";
            Assert.True(task.Add(data) == true);
        }
        [Test]
        public void タスクに存在しないパスで追加()
        {
            Task task = new Task();
            TaskData data = new TaskData();
            data.ProjectFolder = @"M:\program\vsht\vsht\VSHackathon20120428\T33";
            Assert.False(task.Add(data) == true);
        }
        [Test]
        public void タスクをクリア()
        {
            Task task = new Task();
            task.Clear();
            Assert.True(task.Count() == 0);
        }
        [Test]
        public void タスクの情報取得()
        {
            Task task = new Task();
            TaskData data = new TaskData();
            data.ProjectFolder = @"M:\program\vsht\vsht\VSHackathon20120428\T3";
            task.Add(data);
            Assert.True(task[0].ProjectFolder == data.ProjectFolder);
        }

    }
}
