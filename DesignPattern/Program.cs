using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singletone staff = Singletone.SingleInstance;
            staff.LogMessage("staff");

            Singletone manager = Singletone.SingleInstance;
            manager.LogMessage("manager");
            Console.ReadKey();
        }
    }

    public class Singletone
    {
        static int Counter = 0;
        private static Singletone singleInstance = null;

        private  Singletone()
        {
            Counter++;
            Console.WriteLine("Instance created {0}", Counter);
        }

        public static Singletone SingleInstance
        {
            get
            {
                //test2 check CI
                if(singleInstance == null)
                {
                    singleInstance = new Singletone();
                }

                return singleInstance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
