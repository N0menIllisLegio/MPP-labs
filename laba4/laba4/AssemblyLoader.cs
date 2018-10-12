using System;
using System.Reflection;
      
namespace laba4
{
	public static class AssemblyLoader
    {
		public static void Load(string assemblyPath)
		{
			Assembly assembly = Assembly.LoadFrom(assemblyPath);

			Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
				if (type.IsPublic)
				{
					Console.WriteLine(type.FullName);
				}
            }
		}
    }
}
