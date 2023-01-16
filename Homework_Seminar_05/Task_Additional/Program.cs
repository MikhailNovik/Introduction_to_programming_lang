/*
Дополнительная необязательная задача 37 из семинара.
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArray(int[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
}

int GetLengthNewArray(int[] oldArray)
{
    int lengthOldArray = oldArray.Length;
    int lengthNewArray = (lengthOldArray + 1) / 2;
    
    /*
    if (lengthOldArray % 2 == 0)
    {
        lengthNewArray = lengthOldArray / 2;                       
    }    
    else
    {
        lengthNewArray = (lengthOldArray / 2) + 1;
    }
    */
    
    return lengthNewArray;
}

int[] GetArrayProductPairSum(int[] oldArray, int lengthNewArr)
{
    int[] newArray = CreateArray(lengthNewArr);
    int length = oldArray.Length;  

    for (int i = 0; i < length / 2; i++)
    {
        int product = (oldArray[i] * oldArray[length - i - 1]);
        newArray[i] = product;
    }

    if (length % 2 != 0)
    {
        newArray[length / 2] = oldArray[length / 2];
    }
    
    return newArray;
}

string PrintArray(int[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);

    return outputSrt; 
}

Console.Write("Введите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(count);
FillArray(arr, 0, 99);
Console.WriteLine(PrintArray(arr));
int lengthNewArr = GetLengthNewArray(arr);
int[] newArr = GetArrayProductPairSum(arr, lengthNewArr);
Console.WriteLine(PrintArray(newArr));
