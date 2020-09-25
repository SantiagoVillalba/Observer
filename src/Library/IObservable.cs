using System;
using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    {
        List<IObserver> observers{get;}
        void Notify();
        void Suscribe();
        void Unsuscribe();

    }
}