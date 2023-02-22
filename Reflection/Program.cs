using System.Reflection;

namespace Reflection
{
    class Program
    {
        internal static void Main()
        {
            // Reflection in C# is used to retrieve metadata on types at runtime.
            // In other words, you can use reflection to inspect metadata of the types in your program dynamically
            //   -- you can retrieve information on the loaded assemblies and the types defined in them.
            // Reflection in C# is similar to RTTI (Runtime Type Information) of C++.

            Computer computer = new("Machintosh", "Windows", "IntelCoreDuo", 64, 512);
            Type computerType = computer.GetType();
            Console.WriteLine(computerType.FullName);
            var members = computerType.GetMembers();
            foreach(var member in members )
            {
                Console.WriteLine(member.MemberType + " -> " + member);
            }

            //Console.WriteLine("Press Key to Continue...");
            //Console.ReadLine();

            //Console.Clear();

            #region Reflection for Fields and Properties 

            var type = typeof(MyClass);

            ConstructorInfo ctor = type.GetConstructor(new Type[] { });
            var result = ctor?.Invoke(new object[] { });
            // делает то же, что 
            // object result = new MyClass();

            var propertyInfo = type.GetProperty("Property");
            propertyInfo?.SetValue(result, 5);
            var variable1 = (int)type?.GetMethod("Method").Invoke(result, new object[] { 3 });
            // делает то же, что
            // result.Property = 5; var variable1 = result.Method(3);

            var field = type.GetField("Field", BindingFlags.NonPublic | BindingFlags.Instance); 
            field.SetValue(result, true);
            // делает то же, что
            // result.Field = true, несмотря на то, что это поле private

            Console.WriteLine(field);

            #endregion

        }
    }
    class MyClass
    {
        public int Property { get; set; }
        private bool Field;
        public int Method(int argument)
        {
            return Property + argument;
        }
    }

    public record Computer(string Name, string OS, string ProcessorName, int RAM, int DiskSpace)
    {
        /*
         * Ce contine aceasta clasa ----->
            Method ------> System.String get_Name()
            Method ------> Void set_Name(System.String)
            Method ------> System.String get_OS()
            Method ------> Void set_OS(System.String)
            Method ------> System.String get_ProcessorName()
            Method ------> Void set_ProcessorName(System.String)
            Method ------> Int32 get_RAM()
            Method ------> Void set_RAM(Int32)
            Method ------> Int32 get_DiskSpace()
            Method ------> Void set_DiskSpace(Int32)
            Method ------> System.String ToString()
            Method ------> Boolean op_Inequality(Reflection.Computer, Reflection.Computer)
            Method ------> Boolean op_Equality(Reflection.Computer, Reflection.Computer)
            Method ------> Int32 GetHashCode()
            Method ------> Boolean Equals(System.Object)
            Method ------> Boolean Equals(Reflection.Computer)
            Method ------> Reflection.Computer <Clone>$()
            Method ------> Void Deconstruct(System.String ByRef, System.String ByRef, System.String ByRef, Int32 ByRef, Int32 ByRef)
            Method ------> System.Type GetType()
            Constructor -> Void .ctor(System.String, System.String, System.String, Int32, Int32)
            Property ----> System.String Name
            Property ----> System.String OS
            Property ----> System.String ProcessorName
            Property ----> Int32 RAM
            Property ----> Int32 DiskSpace
         */
    };

}