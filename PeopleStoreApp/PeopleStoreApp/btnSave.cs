using System;
using System.Threading.Tasks;

namespace PeopleStoreApp
{
    internal class btnSave
    {
        public static Func<object, EventArgs, Task> Clicked { get; internal set; }
    }
}