// написать программу которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше либо равна 3 символа

void PrintArray(string[] array)
{
  for(int i = 0; i < array.Length; i++)
  {System.Console.Write(array[i] + ", ");}
}

string[] FillNewArray(string[] array)         // основной метод который проходит по массиву и добавляет нужные строки в новый массив.
{
  int index = 0;
  int counter = 0;

  for(int i = 0; i < array.Length; i++)       // узнаем длинну будущего массива для строк с длинной меньше или равно 3 символа.
  {
    if (array[i].Length <= 3)
    {
      counter++;
    }
  }

  string[] result = new string[counter];      // создаем результирующий массив

  for(int i = 0; i < array.Length; i++)       // заполняем новый массив подходящими по условию строками
  {
    if(array[i].Length <= 3)
    {
      result[index] = array[i];
      index++; 
    }
  }
  return result;
}

string[] array = {"hello", "-2", "world", ":-)", "dfe", "23", "dfdsfdsf", "346"};           // создаем массив строк

PrintArray(FillNewArray(array));   