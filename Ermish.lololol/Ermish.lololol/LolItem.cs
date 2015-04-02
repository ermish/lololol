using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ermish.lololol
{
    public class LolItem<T>
    {
        public T Item { get; set; }
        public Action FunctionToRun { get; set; }

        public bool IsFunctionReallyGoingToRun { get; set; }

        public LolItem()
        {

        }

        public LolItem(T item, Action functionToRun)
        {
            Item = item;
            FunctionToRun = functionToRun;
            IsFunctionReallyGoingToRun = true;
        }
    }
}
