using System;

namespace laba4
{
    class MainClass
    {
        public static void Main()
        {
			ConsoleKeyInfo keyPressed;
			string assemblyPath = "/Users/gadfly/Desktop/BSUIR.3.5/СПП/Выполненные лабы/dlls/FigureBase.dll";
			do
			{
				// assemblyPath = Console.ReadLine();
                AssemblyLoader.Load(assemblyPath);
				Console.WriteLine("Press Esc to exit.");
                keyPressed = Console.ReadKey();
			} while (keyPressed.Key != ConsoleKey.Escape);

        }
    }
}

/*                              
  Реализовать консольную программу на языке C#, которая: 
- принимает в параметре командной строки путь к сборке .NET (EXE- или DLL-файлу);
- загружает указанную сборку в память;

- выводит на экран полные имена всех public-типов данных этой сборки, упорядоченные по пространству имен (namespace) и по имени.
*/