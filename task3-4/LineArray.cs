using System;
using task3_4;

namespace task3_4
{
    sealed class LineArray<T> : BaseArray<T>, ILineArray
    {
        public T[] array;
        public LineArray()
        {
            Console.WriteLine("Вы бы хотели заполнить массив самостоятельно?");
            Console.WriteLine("1 - самостоятельно, 2 - случайными числами");
            int answer = int.Parse(Console.ReadLine());
            bool IsUserInput = answer == 1;

            if (IsUserInput)
            {
                this.UserFill();
            }
            else
            {
                this.RandomFill();
            }
        }

        public override void RandomFill()
        {
            Console.WriteLine("Сколько элементов вы бы хотели, чтобы было в массиве?");
            int count = int.Parse(Console.ReadLine());

            array = new T[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = RandomGenerator<T>.RandomValue();
            }
        }

        public override void UserFill()
        {
            Console.WriteLine("Сколько элементов вы бы хотели, чтобы было в массиве?");
            int count = int.Parse(Console.ReadLine());

            array = new T[count];
            for (int i = 0; i <= count; i++)
            {
                array[i] = (T)(object) Console.ReadLine();
            }
        }

        public override void Print()
        {
            Console.Write("[");
            for (int i = 0; i < this.array.Length; i++)
            {
                Console.Write($" {this.array[i]} ");
            }
            Console.Write("]\n");
        }
    }
}