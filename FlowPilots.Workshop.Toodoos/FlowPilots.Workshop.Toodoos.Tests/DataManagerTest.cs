using NUnit.Framework;
using System;
using FlowPilots.Workshop.Toodoos.Core;

namespace FlowPilots.Workshop.Toodoos.Tests
{
    [TestFixture()]
    public class DataManagerTest
    {
        [Test()]
        public void TestTodoCount()
        {
            // Arrange
            var dataManager = new DataManager();

            // Act
            var todos = dataManager.GetAllTodos();

            // Assert
            Assert.AreEqual(3, todos.Count);
        }
    }
}

