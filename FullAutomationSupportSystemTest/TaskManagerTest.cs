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
        private TaskManager task = null;
        [SetUp]
        public void SetUp()
        {
            task = new TaskManager();
        }
        [Test]
        public void タスクに存在するパスで追加()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            task.Add(data);
            Assert.True(task.Count == 1);
        }
        [Test]
        public void タスクに存在しないパスで追加()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files2";
            task.Add(data);
            Assert.False(task.Count == 0);
        }
        [Test]
        public void タスクをクリア()
        {
            task.Clear();
            Assert.True(task.Count == 0);
        }
        [Test]
        public void タスクの取得()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            task.Add(data);
            Assert.True(task[0].ProjectFolder == data.ProjectFolder);
        }
        [Test]
        public void コマンドの追加()
        {
            var data = new TaskData();
            var command = new CommandData();
            data.ProjectFolder = @"C:\Program Files";
            task.Add(data);
            data.Add(command);
            Assert.True(data.Count == 1);
        }
    }
}
