namespace IndustrialMonitor
{
    /// <summary>
    /// Интерфейс наблюдателя (Observer)
    /// </summary>
    public interface IObserver
    {
        void Update(string message);
    }
}