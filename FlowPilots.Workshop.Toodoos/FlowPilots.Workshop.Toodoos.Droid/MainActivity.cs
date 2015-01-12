using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FlowPilots.Workshop.Toodoos.Core;
using System.Linq;
using System.Collections.Generic;

namespace FlowPilots.Workshop.Toodoos.Droid
{
    [Activity(Label = "FlowPilots.Workshop.Toodoos.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity
    {
        string[] todos;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            todos = DataManager.GetAllTodos().Select(todo => todo.Name ).ToArray();
            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, todos);

        }
    }
}


