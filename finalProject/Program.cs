﻿// написать программу которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа

void PrintArray(string[] array)
{
  for(int i = 0; i < array.Length; i++)
  {System.Console.Write(array[i] + ", ");}
}

int FindNewArrayLength(string[] array)           // узнаем длинну будущего массива для строк с длинной меньше или равно 3 символа.
{
  int counter = 0;

  for(int i = 0; i < array.Length; i++)
  { if (array[i].Length <= 3)
    {counter++;}
  }
  return counter;
}

