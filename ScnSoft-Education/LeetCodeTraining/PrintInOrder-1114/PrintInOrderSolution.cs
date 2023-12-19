using System.Threading;

namespace LeetCodeTraining.PrintInOrder
{
    //https://leetcode.com/problems/print-in-order/
    public class Foo
    {

        private ManualResetEvent firstEvent = new ManualResetEvent(false);
        private ManualResetEvent secondEvent = new ManualResetEvent(false);

        public Foo()
        {

        }

        public void First(Action printFirst)
        {
            printFirst();
            firstEvent.Set();
        }

        public void Second(Action printSecond)
        {
            firstEvent.WaitOne();
            printSecond();
            secondEvent.Set();
        }

        public void Third(Action printThird)
        {
            secondEvent.WaitOne();
            printThird();
        }
    }
}