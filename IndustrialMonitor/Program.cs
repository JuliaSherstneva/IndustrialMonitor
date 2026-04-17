using System;
namespace IndustrialMonitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== СИСТЕМА МОНИТОРИНГА ПРОМЫШЛЕННОГО ОБОРУДОВАНИЯ ===\n");
            // Создаём наблюдаемый объект
            var monitor = new MachineMonitor();
            // Создаём наблюдателей
            var operatorNotifier = new OperatorNotifier();
            var engineerNotifier = new MaintenanceNotifier();
            var logger = new LogObserver();
            // Подписываем наблюдателей
            Console.WriteLine("--- Подключение наблюдателей ---");
            monitor.Attach(operatorNotifier);
            monitor.Attach(engineerNotifier);
            monitor.Attach(logger);

            Console.WriteLine("\n--- Начало мониторинга ---\n");
            // Симуляция работы датчиков (штатный режим)
            Console.WriteLine("=== ЦИКЛ 1: Штатный режим ===");
            monitor.CheckTemperature(75.5);
            monitor.CheckVibration(2.3);
            monitor.CheckLoad(60.0);
            monitor.CheckSpeed(2500);

            Console.WriteLine("\n=== ЦИКЛ 2: Критические отклонения ===");
            monitor.CheckTemperature(105.0);  // Превышение!
            monitor.CheckVibration(6.2);      // Превышение!
            monitor.CheckLoad(90.0);           // Превышение!
            monitor.CheckSpeed(3200);          // Превышение!

            Console.WriteLine("\n=== ЦИКЛ 3: Отключение инженера и новый цикл ===");
            monitor.Detach(engineerNotifier);
            monitor.CheckTemperature(102.0);   // Инженер не получит

            Console.WriteLine("\n=== РАБОТА ЗАВЕРШЕНА ===");
            Console.WriteLine("Лог сохранён в файл: monitoring.log");
        }
    }
}