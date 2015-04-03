using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ermish.lololol
{
    public static class Core
    {
        /// <summary>
        /// The core method!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> DoStuff<T>(this T item, Action stuffToDo)
        {
            var lolItem = new LolItem<T>(item, stuffToDo);
            return lolItem;
        }
    }
}
