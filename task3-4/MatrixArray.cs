using System;
using task3_4;

namespace task3_4
{
    internal class MatrixArray<T> : BaseArray<T>, IMatrixArray
    {
        public T[,] array;
        public MatrixArray()
        {
            Console.WriteLine("Вы бы хотели заполнить массив самостоятельно?");
            Console.WriteLine("1 - самостоятельно, 2 - случайными значениями");
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

            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько колонок вы бы хотели, чтобы было в массиве?");
            int columns = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = RandomGenerator<T>.RandomValue();
                }
            }
        }

        public override void UserFill()
        {
            Console.WriteLine("Сколько рядов вы бы хотели, чтобы было в массиве?");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько колонок вы бы хотели, чтобы было в массиве?");
            int columns = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = (T)(object)Console.ReadLine();
                }
            }
        }

        public override void Print()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                    Console.Write($"{spaces}{this.array[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public void PrintArrayAndReversedArray()
        {
            this.Print();
            Console.WriteLine();
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = this.array.GetLength(1) - 1; j >= 0; j--)
                    {
                        string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                }
                else
                {
                    for (int j = 0; j < this.array.GetLength(1); j++)
                    {
                        string spaces = new string(' ', 5 - $"{this.array[i, j]}".Length);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}