using System;
using task3_4;
class Program
{
    static void Main()
    {
        IPrinter[] arrays = new IPrinter[8];

        arrays[0] = new LineArray<int>();
        arrays[1] = new LineArray<double>();
        arrays[2] = new LineArray<bool>();
        arrays[3] = new LineArray<string>();

        arrays[4] = new MatrixArray<int>();
        arrays[5] = new MatrixArray<double>();
        arrays[6] = new MatrixArray<bool>();
        arrays[7] = new MatrixArray<string>();

        for(int i = 0; i < arrays.Length; i++)
        {
            arrays[i].Print();
        }
    }
}