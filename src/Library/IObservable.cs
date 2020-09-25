using System;
using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    {
        List<IObserver> Observers{get;}
        void Notify();
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);

    }
}