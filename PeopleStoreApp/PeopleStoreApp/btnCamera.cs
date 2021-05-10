using System;
using System.Threading.Tasks;

namespace PeopleStoreApp
{
    internal class btnCamera
    {
        public static Func<object, EventArgs, Task> Clicked { get; internal set; }
    }
}