using System;
using System.Threading;

namespace ParallelThreadExamples
{

    class MainClass

    {

    }
    class Program
    {
        private const int Repetitions = 1000;
        public static void DoWork()
        {
            for (int i = 0; i < Repetitions; i++)
            {
                System.Console.WriteLine("b");
            }
        }
        static void Main(string[] args)
        {
            #region 1st thread
            Thread t1 = new Thread(new ThreadStart(DoWork)); ;
            t1.Start();

            #endregion
            #region start new thread without specifying ThreadStart
            Thread t2 = new Thread(DoWork);
            t2.Start();
            #endregion

            #region 3rd thread with linq
            Thread t3 = new Thread(() => { DoWork(); });
            t3.Start();

            #endregion

            for (int i = 0; i < Repetitions; i++)
            {
                System.Console.WriteLine("a");
            }

        }
    }
}
