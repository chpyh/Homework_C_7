//Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.


void InputArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(1, 10);

    }
    Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

}
void ArrayReverse(int[] array, int leftIndex, int rightIndex)
{
   
    if (leftIndex < rightIndex)
    {
        int temporary = array[leftIndex];
        array[leftIndex] = array[rightIndex];
        array[rightIndex] = temporary;
        ArrayReverse(array, leftIndex + 1, rightIndex - 1);
    }

}
int n = new Random().Next(1, 10);
int[] array = new int[n];
InputArray(array);
int index = 0;
ArrayReverse(array, index, array.Length - 1);
Console.WriteLine($"Перевернутый массив: [{string.Join(", ", array)}]");
