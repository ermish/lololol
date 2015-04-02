using System;

namespace Ermish.lololol.Example
{
    public class Examples
    {
        public Examples()
        {
        }

        public void Run()
        {
            AwesomeExample();
        }

        public void AwesomeExample()
        {
            var trollingObject = new { };

            trollingObject.DoStuff(() => Console.WriteLine("I did it!")).ForSeriousRealz().ChangedMyMind().NoReally().ItsOppositeDay().Yes().YeeHaa();

            trollingObject.DoStuff(() => Console.WriteLine("I probably won't make it this time...")).Oops().Cancel().Invert().JK().DoWhatISaid();
        }
    }
}