using System;
namespace IndustrialMonitor
{
    public class MaintenanceNotifier : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[ЗАЯВКА ИНЖЕНЕРУ] {DateTime.Now:HH:mm:ss} - {message}");
        }
    }
}