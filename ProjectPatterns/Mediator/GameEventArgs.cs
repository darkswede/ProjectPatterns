using System;

namespace ProjectPatterns.Mediator
{
    public abstract class GameEventArgs : EventArgs
    {
        public abstract void Print();
    }
}