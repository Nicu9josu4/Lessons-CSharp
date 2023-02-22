using Asynchronous_Programming;

internal class AsyncAwait
{

    
    private static void Main()
    {
        AsyncHronic.MainHronic(); 
        //Asynchroniusly.MainAsync();
        //List<Student> students = new();


        //for (int i = 1; i <= 5; i++)
        //{
        //     Task.Run(async () => {students.Add(await AsyncMethod(new Student("Student " + i, i + 24))); }).Wait();
        //}

        //foreach(var student in students)
        //{
        //    Console.WriteLine(student);
        //}

    }

    public static async Task PrintAsync(int n)
    { Console.WriteLine("Iteration {0}", n); await Task.Delay(100); }

    public static async Task<Student> AsyncMethod(Student student) => student;

    internal record class Student(string Name, int Age);
}