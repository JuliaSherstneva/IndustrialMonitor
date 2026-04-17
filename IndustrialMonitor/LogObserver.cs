using System;
using System.IO;
namespace IndustrialMonitor
{
    public class LogObserver : IObserver
    {
        private readonly string _logFilePath = "monitoring.log";

        public void Update(string message)
        {
            string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
            Console.WriteLine($"[ЛОГ] Записано событие в файл");
        }
    }
}