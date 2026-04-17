using System;
namespace IndustrialMonitor
{
    public class OperatorNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[УВЕДОМЛЕНИЕ ОПЕРАТОРУ] {DateTime.Now:HH:mm:ss} - {message}");
        }
    }
}