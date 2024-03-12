using System;
using task3_4;

namespace task3_4
{
    internal abstract class BaseArray<T> : IBaseArray
    {
        public BaseArray() { }
        public abstract void Print();
        public abstract void UserFill();
        public abstract void RandomFill();
    }
}