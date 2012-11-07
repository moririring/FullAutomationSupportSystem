using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Runtime.Serialization;
namespace FullAutomationSupportSystem
{
    public class TaskManagerTest
    {
        private TaskList gTaskList = null;
        [SetUp]
        public void SetUp()
        {
            gTaskList = new TaskList();
        }
        [Test]
        public void タスクに存在するパスで追加()
        {
            var data = new TaskData();
            data.ProjectPaths[0] = @"C:\Program Files";
            gTaskList.Add(data);
            Assert.True(gTaskList.Count == 1);
        }
        [Test]
        public void タスクに存在しないパスで追加()
        {
            var data = new TaskData();
            data.ProjectPath = @"C:\Program Files2";
            gTaskList.Add(data);
            Assert.False(gTaskList.Count == 0);
        }
        [Test]
        public void タスクをクリア()
        {
            gTaskList.Clear();
            Assert.True(gTaskList.Count == 0);
        }
        [Test]
        public void タスクの取得()
        {
            var data = new TaskData();
            data.ProjectPaths.Add(@"C:\Program Files");
            gTaskList.Add(data);
            Assert.True(gTaskList[0].ProjectPath == data.ProjectPath);
        }
        [Test]
        public void コマンドの追加()
        {
            var task = new TaskData();
            var command = new CommandData();
            task.ProjectPaths.Add(@"C:\Program Files");
            gTaskList.Add(task);
            task.CommandDataList.Add(command);
            Assert.True(task.CommandDataList.Count == 1);
        }
    }
}
