using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

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
            Assert.True(task.AddTask(data) == true);
        }
        [Test]
        public void タスクに存在しないパスで追加()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files2";
            Assert.False(task.AddTask(data) == true);
        }
        [Test]
        public void タスクをクリア()
        {
            task.ClearTask();
            Assert.True(task.CountTask() == 0);
        }
        [Test]
        public void タスクの取得()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            task.AddTask(data);
            Assert.True(task[0].ProjectFolder == data.ProjectFolder);
        }
        [Test]
        public void タスクの編集()
        {
            var data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            task.AddTask(data);

            TaskData edit = task[0];
            edit.ProjectFolder = @"C:\WINDOWS";
            Assert.True(task.EditTask(0, edit) == true);
        }
        [Test]
        public void コマンドの追加()
        {
            var data = new TaskData();
            var command = new CommandData();
            data.ProjectFolder = @"C:\Program Files";
            task.AddTask(data);

            Assert.True(data.AddCommand(command) == true);
        }
    }
}
