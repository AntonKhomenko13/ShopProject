using System;

public class ProtsunTest
{
	public ProtsunTest()
	{
        Console.WriteLine("Write a size of array");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        int temp;
        Random rnd = new Random();
        for (int i = 0; i < length; i++)
        {
            arr[i] = rnd.Next() % 100;
        }
        for (var i = 1; i < length; i++)
        {
            for (var j = 0; j < length - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        for (int i = 0; i < length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}
