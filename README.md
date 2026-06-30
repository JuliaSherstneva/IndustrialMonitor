using System;

namespace TaskPrototype
{
    // ====== 1. Базовый абстрактный класс Task ======
    public abstract class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }

        public Task(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
        }

        public abstract Task Clone();

        public override string ToString()
        {
            return $"{GetType().Name,-15} | {Title,-25} | До: {DueDate.ToShortDateString()}";
        }
    }

    // ====== 2. Простая задача ======
    public class SimpleTask : Task
    {
        public SimpleTask(string title, string description, DateTime dueDate)
            : base(title, description, dueDate) { }

        public override Task Clone()
        {
            return new SimpleTask(this.Title, this.Description, this.DueDate);
        }
    }

    // ====== 3. Подзадача ======
    public class Subtask : Task
    {
        public Task ParentTask { get; set; }

        public Subtask(string title, string description, DateTime dueDate, Task parent)
            : base(title, description, dueDate)
        {
            ParentTask = parent;
        }

        public override Task Clone()
        {
            Task parentClone = ParentTask != null ? ParentTask.Clone() : null;
            return new Subtask(this.Title, this.Description, this.DueDate, parentClone);
        }
    }

    // ====== 4. Повторяющаяся задача ======
    public class RecurringTask : Task
    {
        public int RepeatIntervalDays { get; set; }
        public DateTime LastExecuted { get; set; }

        public RecurringTask(string title, string description, DateTime dueDate, int interval)
            : base(title, description, dueDate)
        {
            RepeatIntervalDays = interval;
            LastExecuted = DateTime.Now;
        }

        public override Task Clone()
        {
            RecurringTask clone = new RecurringTask(this.Title, this.Description, this.DueDate, this.RepeatIntervalDays);
            clone.LastExecuted = this.LastExecuted;
            return clone;
        }
    }

    // ====== 5. Главная программа ======
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ПАТТЕРН PROTOTYPE =====\n");

            // Создаем оригиналы
            SimpleTask simple = new SimpleTask("Купить продукты", "Молоко, хлеб, яйца", DateTime.Now.AddDays(1));
            Subtask subtask = new Subtask("Написать отчет", "Глава 1", DateTime.Now.AddDays(2), simple);
            RecurringTask recurring = new RecurringTask("Поливка цветов", "Каждые 3 дня", DateTime.Now.AddDays(3), 3);

            // Клонируем
            SimpleTask simpleClone = (SimpleTask)simple.Clone();
            Subtask subtaskClone = (Subtask)subtask.Clone();
            RecurringTask recurringClone = (RecurringTask)recurring.Clone();

            // Изменяем клоны
            simpleClone.Title = "[КЛОН] Купить продукты";
            subtaskClone.Title = "[КЛОН] Написать отчет";
            recurringClone.Title = "[КЛОН] Поливка цветов";

            // Вывод
            Console.WriteLine("ОРИГИНАЛЫ:");
            Console.WriteLine(simple);
            Console.WriteLine(subtask);
            Console.WriteLine(recurring);

            Console.WriteLine("\nКЛОНЫ:");
            Console.WriteLine(simpleClone);
            Console.WriteLine(subtaskClone);
            Console.WriteLine(recurringClone);

            // Проверка глубокого клонирования
            Console.WriteLine("\n--- Проверка Subtask ---");
            Console.WriteLine($"Оригинал ParentTask: {(subtask.ParentTask != null ? subtask.ParentTask.Title : "null")}");
            Console.WriteLine($"Клон ParentTask:     {(subtaskClone.ParentTask != null ? subtaskClone.ParentTask.Title : "null")}");
            Console.WriteLine($"Объекты разные:      {subtask.ParentTask != subtaskClone.ParentTask}");

            Console.WriteLine("\nНажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
