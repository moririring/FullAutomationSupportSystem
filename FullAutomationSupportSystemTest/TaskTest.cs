using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FullAutomationSupportSystem
{
    public class TaskTest
    {
        [Test]
        public void タスクに存在するパスで追加()
        {
            TaskList task = new TaskList();
            TaskData data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            Assert.True(task.Add(data) == true);
        }
        [Test]
        public void タスクに存在しないパスで追加()
        {
            TaskList task = new TaskList();
            TaskData data = new TaskData();
            data.ProjectFolder = @"C:\Program Files2";
            Assert.False(task.Add(data) == true);
        }
        [Test]
        public void タスクをクリア()
        {
            TaskList task = new TaskList();
            task.Clear();
            Assert.True(task.Count() == 0);
        }
        [Test]
        public void タスクの情報取得()
        {
            TaskList task = new TaskList();
            TaskData data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            task.Add(data);
            Assert.True(task[0].ProjectFolder == data.ProjectFolder);
        }
        [Test]
        public void タスクの情報編集()
        {
            TaskList task = new TaskList();
            TaskData data = new TaskData();
            data.ProjectFolder = @"C:\Program Files";
            task.Add(data);

            TaskData edit = task[0];
            edit.ProjectFolder = @"C:\WINDOWS";
            task.Edit(0, edit);
            Assert.True(task[0].ProjectFolder == @"C:\WINDOWS");
        }

    }
}
