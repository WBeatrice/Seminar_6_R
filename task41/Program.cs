/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int[] ReadArray()
{
    string arrayAsString = Console.ReadLine(); 
    string[] numbersAsString = arrayAsString.Split(", "); 

    int[] array = new int[numbersAsString.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(numbersAsString[i]);
    }
    return array;
}

void Check(int[] array)
{
    int count = 0;
    for(int i= 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($"Numbers greater than 0 entered by the user is: {count}"); 
}

Console.WriteLine("Enter an array separated by commas (Example: 1,2,3):"); 
int[] array = ReadArray();
Check(array);

