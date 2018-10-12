using System;

namespace laba6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int[] arr = { 4, 5, 6, 7, 8, 6 };	
			DynamicList<int> dynamicList = new DynamicList<int>(arr);
			Console.WriteLine(dynamicList[0]);
			dynamicList.Add(5);
			dynamicList.Remove(9);

			foreach (var item in dynamicList)
			{
				Console.WriteLine(item);
			}

           

        }
    }
}

/*
 
  Создать на языке C# обобщенный (generic-) класс DynamicList<T>, который:
  
- реализует динамический массив с помощью обычного массива T[];
- имеет свойство Count, показывающее количество элементов; +
- имеет свойство Items для доступа к элементам по индексу; +
- имеет методы Add, Remove, RemoveAt, Clear для соответственно добавления, удаления, удаления по индексу и удаления всех элементов; +

- реализует интерфейс IEnumerable<T>.

Реализовать простейший пример использования класса DynamicList<T> на языке C#.

 */
