/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма.*/

/*Сначало объявляется два массива: изначальный и вторый такой же длины. Потом метод, 
в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 ), 
если да элемент первого массива заносится в count элемент второго массива. Переменная count чтобы поочередно закидывать из первого массива во второй и чтобы потом не было пробелов. После присвоения увеличивается 
переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.
выводим новый массив на печать*/

void PrintArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}


void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}   

System.Console.WriteLine("Исходный массив: ");
string[] firstArray = new string[] {"257", "45", "hello", "world", "res","456"};
string[] secondArray = new string[firstArray.Length];
PrintArray(firstArray);
SecondArray(firstArray,secondArray);
System.Console.WriteLine("Новый массив: ");
PrintArray(secondArray);
