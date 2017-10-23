using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System;


namespace ToDoList.Tests
{
    [TestClass]
    public class TaskListTests : IDisposable
    {
        public void Dispose()
        {
            // Task.DeleteAll();
        }
        public TaskListTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=todo_test;";
        }

        [TestMethod]
        public void GetAll_DatabaseEmptyAtFirst_0()
        {
          //Arrange, Act
          int result = Task.GetAll().Count;

          //Assert
          Assert.AreEqual(0, result);
        }
    }
}
