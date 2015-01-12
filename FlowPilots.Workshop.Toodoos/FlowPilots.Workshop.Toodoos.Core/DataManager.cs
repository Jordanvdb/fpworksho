using System;
using System.Collections.Generic;

namespace FlowPilots.Workshop.Toodoos.Core
{
    public static class DataManager
    {

        static List<Todo> todos;

        public static List<Todo> GetAllTodos()
        {

            if (todos == null)
            {
                todos = new List<Todo>
                {
                    new Todo
                    {
                        Done = false,
                        Name = "Unit test",
                        Description = "Write a unit test for our PCL"
                    },
                    new Todo
                    {
                        Done = false,
                        Name = "iOS app",
                        Description = "Create an iOS application based on the PCL"
                    },
                    new Todo
                    {
                        Done = false,
                        Name = "Android app",
                        Description = "Create an Android application based on the PCL"
                    }
                };
            }
            return todos;
        }
    }
}

