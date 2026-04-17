using System;
using System.Collections.Generic;
namespace IndustrialMonitor
{
    /// <summary>
    /// Интерфейс наблюдаемого объекта (Subject)
    /// </summary>
    public interface IObservable
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }
}