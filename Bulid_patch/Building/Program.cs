// Decompiled with JetBrains decompiler
// Type: Building.Program
// Assembly: Building, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D09ED730-A35A-425A-B9BF-E953C40C48E5
// Assembly location: E:\С#\repos\IiyaMezer\Geek_CSharp_HW\Building\bin\Debug\Building.exe

using System;

namespace Building
{
  internal class Program
  {
    private static void Task01(int X, int Y)
    {
      char[,] chArray = new char[Y, X];
      int length1 = chArray.GetLength(1);
      int length2 = chArray.GetLength(0);
      int num1 = 0;
      int index1 = 0;
      int num2 = length2;
      int num3 = 0 < length2 ? 1 : -1;
      for (int index2 = 0; index2 < length1; ++index2)
      {
        chArray[index1, index2] = '*';
        Console.Write(string.Format("{0} ", (object) chArray[index1, index2]));
        num1 += num2;
        if (num1 >= length1)
        {
          index1 += num3;
          num1 -= length1;
          Console.WriteLine();
          for (int index3 = 0; index3 < index2 + 1; ++index3)
            Console.Write("  ");
        }
      }
      Console.ReadKey();
    }

    private static void Main(string[] args)
    {
      Console.WriteLine("МАссив:");
      Program.Task01(30,3);
    }
  }
}
