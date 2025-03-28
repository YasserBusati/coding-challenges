using System.Reflection;

namespace CodingChallenges;
public class ProblemRunner
{
    private static readonly string NamespacePrefix = "CodingChallenges";

    public static void Run(string problemName)
    {
        try
        {

            string fullClassName = $"{NamespacePrefix}.{problemName}";


            Type problemType = Assembly.GetExecutingAssembly().GetType(fullClassName);

            if (problemType == null)
            {
                Console.WriteLine($"Error: Problem '{problemName}' not found.");
                return;
            }


            MethodInfo runMethod = problemType.GetMethod("Run");

            if (runMethod == null)
            {
                Console.WriteLine($"Error: The problem '{problemName}' does not have a 'Run' method.");
                return;
            }


            object problemInstance = Activator.CreateInstance(problemType);


            runMethod.Invoke(problemInstance, null);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}