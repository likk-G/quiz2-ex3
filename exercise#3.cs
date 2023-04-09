// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;
using System.Globalization;

int[] arr = { 3, 5, 5, 5, 2, 2, 1, 7, 7, 7, 7, 8, 8, 2, 2, 2 };
int max = 1, tmpMax, value = arr[0];
for (int i = 0; i < arr.Length - 1; i++)
{
    tmpMax = 1;
    if (arr[i] == arr[i + 1])
    {
        while (i < arr.Length - 1 && arr[i + 1] == arr[i])
        {
            tmpMax++;
            i++;
        }
    }
    if (tmpMax > max)
    {
        max = tmpMax;
        value = arr[i];
    }
}

Console.WriteLine($"Maximum length: {max}, value: {value}");
