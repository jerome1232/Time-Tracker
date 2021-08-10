using System;
using Gtk;
using System.Threading;

namespace Time_Tracker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting up");
            Task test_task = new Task();
            Console.WriteLine("Cumulative: {0:g}", test_task.GetTime());
            test_task.StartTimer();
            Thread.Sleep(800);
            test_task.StopTimer();
            Console.WriteLine("New Cumulative: {0:g}", test_task.GetTime());
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            Application.Run();

        }
    }
}
