using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ermish.lololol
{
    public static class LolItemExtensions
    {
        #region True

        /// <summary>
        /// Yes! I would in fact like to run the method!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> Yes<T>(this LolItem<T> item)
        {
            item.IsFunctionReallyGoingToRun = true;
            return item;
        }

        /// <summary>
        /// No, Really! I would like to run the method!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> NoReally<T>(this LolItem<T> item)
        {
            return item.Yes();
        }

        /// <summary>
        /// For Serious Realz! I want to run the method!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> ForSeriousRealz<T>(this LolItem<T> item)
        {
            return item.Yes();
        }

        #endregion


        #region False

        /// <summary>
        /// I was wrong. Cancel whatever I was doing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> Cancel<T>(this LolItem<T> item)
        {
            item.IsFunctionReallyGoingToRun = false;
            return item;
        }

        /// <summary>
        /// Wow, that was dumb...can you please undo what I just did? 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> Oops<T>(this LolItem<T> item)
        {
            return item.Cancel();
        }

        /// <summary>
        /// Please stop....
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> Stop<T>(this LolItem<T> item)
        {
            return item.Cancel();
        }

        #endregion


        #region Invert

        /// <summary>
        /// Wow, that was dumb...can you please undo what I just did? 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> Invert<T>(this LolItem<T> item)
        {
            item.IsFunctionReallyGoingToRun = !item.IsFunctionReallyGoingToRun;
            return item;
        }

        /// <summary>
        /// Just Kidding! I didn't REALLY want to do what I said I wanted to do.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> JustKidding<T>(this LolItem<T> item)
        {
            return item.Invert();
        }

        /// <summary>
        /// Just Kidding! I didn't REALLY want to do what I said I wanted to do.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> JK<T>(this LolItem<T> item)
        {
            return item.Invert();
        }

        /// <summary>
        /// Wow, that was dumb...can you please undo what I just did? 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> ItsOppositeDay<T>(this LolItem<T> item)
        {
            return item.Invert();
        }

        /// <summary>
        /// I don't even know what I'm doing anymore. Just do opposite of whatever I asked.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static LolItem<T> ChangedMyMind<T>(this LolItem<T> item)
        {
            return item.Invert();
        }

        #endregion

        #region Run

        /// <summary>
        /// Please run the original thing I asked to do.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static object Run<T>(this LolItem<T> item)
        {
            object result = new { };

            if (item.IsFunctionReallyGoingToRun)
            {
                result = item.FunctionToRun.DynamicInvoke();
            }
            
            return result;
        }

        /// <summary>
        /// Please just do it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static object DoWhatISaid<T>(this LolItem<T> item)
        {
            return item.Run();
        }

        /// <summary>
        /// Go! Run the method!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static object Go<T>(this LolItem<T> item)
        {
            return item.Run();
        }

        /// <summary>
        /// Yeeeeehaaaaaaa!!!!
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static object YeeHaa<T>(this LolItem<T> item)
        {
            return item.Run();
        }

        #endregion
    }
}
