// See https://aka.ms/new-console-template for more information

// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

class Program {
  public static void Main (string[] args) {

    int Prompt(string message)
    {
        System.Console.Write(message); // вывести сообщение
        string? value = System.Console.ReadLine(); // считывает с консоли
        int result = Convert.ToInt32(value); // преобразует строку в целое число
        return result; // возвращает результат
    }

    string PromptEl(string message)
    {
        System.Console.Write(message); // вывести сообщение
        string? value = System.Console.ReadLine(); // считывает с консоли
        return value; // возвращает результат
    }

    string[] InsertArray(int len)
    {
        string[] myArr = new string[len]; // создаёт заготовку массива в соответствии с заданной длиной
        for (int i=0; i < len; i++) 
        {
            myArr[i] = PromptEl($"Введите {i+1}-й элемент массива: "); // предлагает пользователю ввести элемент массива
        }
        return myArr; // возвращает массив
    }

    string[] CheckArray(string[] myArr)
    {
        List<string> newList = new List<string>(); // создаёт безразмерный список
        foreach (string item in myArr) 
        {
            if (item.Length <= 3)
            {
                newList.Add(item); // добавляет элемент массива, если его длина меньше или равна 3
            }
        }

        int count = 0; // создаёт счётчик с 0
        string[] newArr = new string[newList.Count]; // создаёт заготовку массива в соответствии с длиной списка
        foreach (string item in newList) 
        {
            newArr[count] = item; // добавляет элемент из списка
            count += 1; // увеличивает счётчик на 1
        }
        return newArr; // возвращает массив
    }

    int len = Prompt("Введите длину массива: ");

    while (len <= 0) {
        Console.Write("Длина массива должна быть больше 0!\n");
        len = Prompt("Введите длину массива: ");
    }

    string[] myArr = InsertArray(len);

    string body = $"['{string.Join("', '", myArr)}'] → ";
    System.Console.Write(body);

    string[] result = CheckArray(myArr);
    if (result.Length == 0) 
    {
        System.Console.Write("[]");
    }
    else 
    {
        System.Console.Write($"['{string.Join("', '", result)}']");
    }

  }
}
