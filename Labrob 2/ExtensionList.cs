using System;
using System.Collections.Generic;
using System.Text;

namespace Labrob_2
{
    static class ExtensionList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        { 
                return list.list;

        }
    }
}
