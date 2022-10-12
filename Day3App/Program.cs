using EventsDelegates;
using Exceptions;

namespace Day3App
{
    internal class Program
    {
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Notifier notifier = new Notifier(5, "Neata");
            notifier.Notify += Notifier_Notify;
            notifier.Notify += Notifier_Notify2;

            Console.WriteLine("Hello, World!");
            Console.CancelKeyPress += Console_CancelKeyPress;

            int? a = 4;
            ExceptionManagement.Execute(a);

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"O exceptie unexpcted a fost prinsa: {e.ExceptionObject}");
        }

        private static void Notifier_Notify(object? sender, NotifierEventArgs eventArgs)
        {
            Console.Beep(1000, 200);
        }

        private static void Notifier_Notify2(object? sender, NotifierEventArgs eventArgs)
        {
            Console.WriteLine(eventArgs.Message);
        }

        private static void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("S-a terminat app");
        }
    }
}