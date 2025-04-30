using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array: ");
        int n =Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        Console.WriteLine(" Input {n} elements in the array: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"element - {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Step 3: Count how many times each number appears
        Dictionary<int, int> count = new Dictionary<int, int>();
        foreach (int num in array)
        {
            if (count.ContainsKey(num))
            {
                count[num]++;
            }
            else
            {
                count[num] = 1;
            }
        }

        // Step 4: Print numbers that appear only once
        Console.WriteLine("The unique elements found in the array are:");
        foreach (var item in count)
        {
            if (item.Value == 1)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
        