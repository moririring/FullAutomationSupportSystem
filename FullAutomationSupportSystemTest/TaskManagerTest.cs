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
        private FASS gFass = null;
        [SetUp]
        public void SetUp()
        {
            gFass = new FASS();
        }
        [Test]
        public void タスクに存在するパスで追加()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            gFass.taskDataList.Add(data);
            Assert.True(gFass.taskDataList.Count == 1);
        }
        [Test]
        public void タスクに存在しないパスで追加()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files2";
            gFass.taskDataList.Add(data);
            Assert.False(gFass.taskDataList.Count == 0);
        }
        [Test]
        public void タスクをクリア()
        {
            gFass.taskDataList.Clear();
            Assert.True(gFass.taskDataList.Count == 0);
        }
        [Test]
        public void タスクの取得()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            gFass.taskDataList.Add(data);
            Assert.True(gFass.taskDataList[0].ProjectFolder == data.ProjectFolder);
        }
        [Test]
        public void コマンドの追加()
        {
            var task = new TaskData();
            var command = new CommandData();
            task.ProjectFolder = @"C:\Program Files";
            gFass.taskDataList.Add(task);
            task.CommandDataList.Add(command);
            Assert.True(task.CommandDataList.Count == 1);
        }
    }
}
