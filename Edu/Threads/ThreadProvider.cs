using System;
using System.Threading;
using System.Threading.Tasks;

namespace Edu.Threads
{
	public static class ThreadProvider
	{
		private static int CupIndex = 0;
		private static object SyncObj = new object();
        // lock (SyncObj) {  } the same as Monitor.Enter(SyncObj, ref isLocked); if(isLocked) Monitor.Exit(SyncObj)
		private static Mutex mutex = new Mutex();
        // mutex.WaitOne(); mutex.ReleaseMutex();
		private static Semaphore semaphore = new Semaphore(1, 1); 
        // special case semaphore.WaitOne(); semaphore.Release();

		public static void RunThreads()
		{
			var firstThread = new Thread(MakeCoffe);
			firstThread.IsBackground = true;
			var secondThread = new Thread(MakeTea);
			secondThread.IsBackground = false;

			firstThread.Start(new DrinkRequest { Count = 5, HasSugar = true });
			secondThread.Start(new DrinkRequest { Count = 2, HasSugar = false });

			firstThread.Join();
			secondThread.Join();
		}

        public static void RunThreadsSimpleWay()
        {
            new Thread(() =>
            {
                MakeCoffe(new DrinkRequest { Count = 5, HasSugar = true });
            }).Start();
            new Thread(() => {
                MakeTea(new DrinkRequest { Count = 2, HasSugar = false });
            }).Start();
        }

        public static void RunThreadsSimpliestWay()
        {
            Parallel.Invoke(
                () => {
                    MakeCoffe(new DrinkRequest { Count = 5, HasSugar = true });
                },
                () => {
                    MakeTea(new DrinkRequest { Count = 2, HasSugar = false });
                });
        }

        static void MakeCoffe(object request)
        {
            var drinkRequest = (DrinkRequest)request;

            for (var index = 0; index < drinkRequest.Count; index++)
            {
                semaphore.WaitOne();

                CupIndex += 1;
                Task.Delay(2000);

                if (drinkRequest.HasSugar)
                {
                    Console.WriteLine($"{CupIndex} Thread1: Coffe with sugar is ready");
                }
                else
                {
                    Console.WriteLine($"{CupIndex} Thread1: Coffe without sugar is ready");
                }

                semaphore.Release();
            }
        }

        static void MakeTea(object request)
        {
            var drinkRequest = (DrinkRequest)request;

            for (var index = 0; index < drinkRequest.Count; index++)
            {
                semaphore.WaitOne();

                CupIndex += 1;
                Task.Delay(1000);

                if (drinkRequest.HasSugar)
                {
                    Console.WriteLine($"{CupIndex} Thread2: Tea with sugar is ready");
                }
                else
                {
                    Console.WriteLine($"{CupIndex} Thread2: Tea without sugar is ready");
                }

                semaphore.Release();
            }
        }

    }

    public class DrinkRequest
    {
        public int Count { get; set; }
        public bool HasSugar { get; set; }
    }
}
