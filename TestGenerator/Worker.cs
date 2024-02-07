using System.Reflection;

namespace TestGenerator
{
    public class Worker
	{
		public Worker()
		{
		}

        public void GetAllClassesAndMethodsOfAssembly(string assemblyName)
        {
           var assem1 = Assembly.Load(AssemblyName.GetAssemblyName(assemblyName));
           //Get List of Class Name

           var types = assem1.GetTypes();

            foreach (var tc in types)
            {

                if (tc.IsAbstract)
                {
                    Console.Write("Abstract Class : " + tc.Name);
                }
                else if (tc.IsPublic)
                {
                    Console.Write("Public Class : " + tc.Name);
                }
                else if (tc.IsSealed)
                {
                    Console.Write("Sealed Class : " + tc.Name);
                }

                //Get List of Method Names of Class
                var methodName = tc.GetMethods();
                foreach (var method in methodName)
                {
                    if (method.ReflectedType.IsPublic)
                    {
                        Console.Write("Public Method : " + method.Name.ToString());
                    }
                    else
                    {
                        Console.Write("Non-Public Method : " + method.Name.ToString());
                    }
                }
            }
        }
    }
}