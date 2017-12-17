using System;
using System.Threading;
using Kurukuru;

namespace KurukuuuPipe
{
    class Program
    {
        static void Spin(string line)
        {
            Spinner.Start(line, spinner =>
            {
                spinner.Text = "Stage 2... ";
                Thread.Sleep(200);
                spinner.Fail("Something went wrong!");
            });
        }
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                Spin(line);
            }
        }
    }
}
