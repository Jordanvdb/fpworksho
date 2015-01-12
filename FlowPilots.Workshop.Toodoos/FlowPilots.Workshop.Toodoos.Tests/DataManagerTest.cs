using NUnit.Framework;
using System;
using FlowPilots.Workshop.Toodoos.Core;
using System.Linq;

namespace FlowPilots.Workshop.Toodoos.Tests
{
    [TestFixture()]
    public class DataManagerTest
    {
        [Test()]
        public void TestTodoCount()
        {
            // Arrange

            // Act
            var todos = DataManager.GetAllTodos();

            // Assert
            Assert.AreEqual(3, todos.Count);
        }
    
        [Test()]
        public void TestFirstTodo()
        {
            // Arrange

            // Act
            var firstTodoName = DataManager.GetAllTodos().First().Name;

           // Assert
            Assert.AreEqual("Unit test", firstTodoName);
        }
    }
}

