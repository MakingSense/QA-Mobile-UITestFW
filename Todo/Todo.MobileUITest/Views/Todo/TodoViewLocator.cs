﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Todo.MobileUITest.Views.Todo
{
    public class TodoViewLocator
    {
        public Func<AppQuery, AppQuery> AddButton { get; set; }
        public Func<AppQuery, AppQuery> TasksList { get; set; }
        public Func<AppQuery, AppQuery> TaskName { get; set; }


        public TodoViewLocator CreateInstance(Platform platform)
        {
            if (platform == Platform.Android)
            {

                AddButton = c => c.Id("NoResourceEntry-0");
                TasksList = c => c.Id("NoResourceEntry-3");
                TaskName = c => c.Id("TodoItemName");
            }
            else
            {
                AddButton = c => c.Id("AddButton");
                TasksList = c => c.Id("TodoList");
                TaskName = c => c.Id("TodoItemName");
            }
            return this;
        }
    }
}
