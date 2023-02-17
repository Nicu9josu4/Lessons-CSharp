using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Dynamic
{
    class Program
    {
        internal static void Main()
        {
            //dynamic obj = 1;
            //Console.WriteLine(obj);
            //obj += 4;
            //Console.WriteLine(obj);
            //obj = "554dagth";
            //Console.WriteLine(obj);
            //obj += 4;
            //Console.WriteLine(obj);


            dynamic person = new System.Dynamic.ExpandoObject();
            person.Name = "Mister";
            person.Price = 50332;

            person.ToString = (Action)(() => { Console.WriteLine($"{person.Name} - {person.Price}"); });
            person.ToString();

            //Type myType = person.GetType();
            //var members = myType.GetMembers();

            //foreach ( var member in members )
            //{
            //    Console.WriteLine(member);
            //}

            ScriptEngine engine = Python.CreateEngine(); // Este folosit spre exemplu daca nu dorim sa modificam in programul principal,
                                                         // dar sa adaugam un scenariu al unei jocuri video
            engine.ExecuteFile("script.py");
            engine.Execute("print('Hello')");


            //Console.WriteLine(Count(10, "78"));

            //static dynamic Count(int a, string b)
            //{
            //    return a + Convert.ToInt32(b); 
            //}
        }
    }
}