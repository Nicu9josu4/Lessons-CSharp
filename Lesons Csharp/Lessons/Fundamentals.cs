using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesons_Csharp.Lessons
{
    public class Fundamentals
    {
        public void StartLesson()
        {
            Console.WriteLine("1.1 - Program Structure" 
            +"\n - All C# program code is placed in files with the .cs" 
            +"\n - The basic building block of a program is a statement" 
            +"\n       * A statement represents some action, such as an arithmetic operation, a method call, a variable declaration, and a value assignment to it" 
            +"\n       * Every statement in C# ends with a semicolon (;)" 
            +"\n       * Console.WriteLine(\"Hello, World!\");" 
            +"\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1.2 - Variables and constants" 
            +"\n - Variables are used to store data in a program" 
            +"\n - A variable represents a named area of ​​memory that holds a value of a specific type" 
            +"\n       * the name can contain any numbers, letters and underscores, and the first character in the name must be a letter or underscore" 
            +"\n       * The name must not contain punctuation or spaces" 
            +"\n       * name cannot be a C# language keyword" 
            +"\n - Example: <Type> <Variable Name>" 
            +"\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1.3 - Data types" 
            +"\n - The C# language has the following basic data types:" 
            +"\n - bool : stores value true or false (boolean literals). Represented by system type System.Boolean" 
            +"\n     * bool alive = true;"  
            +"\n     * bool isDead = false;"  
            +"\n - byte : stores an integer from 0 to 255 and occupies 1 byte. Represented by system type System.Byte"  
            +"\n     * byte bit1 = 1;"  
            +"\n     * byte bit2 = 102;"  
            +"\n - sbyte : stores an integer from -128 to 127 and occupies 1 byte. Represented by system type System.SByte"  
            +"\n     * sbyte bit1 = -101;"  
            +"\n     * sbyte bit2 = 102;"  
            +"\n - short : stores an integer from -32768 to 32767 and occupies 2 bytes. Represented by system type System.Int16"  
            +"\n     * short n1 = 1;" 
            +"\n     * short n2 = 102;" 
            +"\n - ushort : stores an integer from 0 to 65535 and occupies 2 bytes. Represented by system type System.UInt16"  
            +"\n     * ushort n1 = 1;" 
            +"\n     * ushort n2 = 102;" 
            +"\n - int : stores an integer from -2147483648 to 2147483647 and takes 4 bytes. Represented by the system type System.Int32" 
            +"\n     * int a = 10;" 
            +"\n     * int b = 0b101;  // Binnary form b = 5" 
            +"\n     * int c = 0xFF;   // Hex form c = 255" 
            +"\n - uint : stores an integer from 0 to 4294967295 and takes 4 bytes. Represented by the system type System.UInt32" 
            +"\n     * uint a = 10;" 
            +"\n     * uint b = 0b101;  // Binnary form b = 5" 
            +"\n     * uint c = 0xFF;   // Hex form c = 255" 
            +"\n - long : stores an integer from –9 223 372 036 854 775 808 to 9 223 372 036 854 775 807 and takes 8 bytes. Represented by system type System.Int64" 
            +"\n     * long a = 10;"  
            +"\n     * long b = 0b101;  // Binnary form b = 5" 
            +"\n     * long c = 0xFF;   // Hex form c = 255" 
            +"\n - ulong : stores an integer from 0 to 18 446 744 073 709 551 615 and takes 8 bytes. Represented by system type System.UInt64" 
            +"\n     * ulong a = 10;" 
            +"\n     * ulong b = 0b101;  // Binnary form b = 5" 
            +"\n     * ulong c = 0xFF;   // Hex form c = 255" 
            +"\n - float : stores a floating point number from to and occupies 4 bytes. Represented by system type -3.4*10^38 - 3.4*10^38 System.Single" 
            +"\n - double : stores a floating point number from to and occupies 8 bytes. Represented by system type ± 5.0*10^324±1.7*10^308 System.Double" 
            +"\n - char : stores a single Unicode character and occupies 2 bytes. Represented by the system type System.Char" 
            +"\n - string : stores the Unicode character set. Represented by the system type System.String. " 
            +"\n - object : can store a value of any data type and takes up 4 bytes on a 32-bit platform and 8 bytes on a 64-bit platform. Represented by a system type System.Object" 
            +"\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1.5 - C# arithmetic operations" 
            +"\n - Binary arithmetic operations:" 
            +"\n - \" + \" The operation of adding two numbers: z = 1 + 2 // z = 3" 
            +"\n - \" - \" The operation of subtracting two numbers: z = 2 - 2 // z = 0" 
            +"\n - \" * \" The operation of multiplying two numbers: z = 2 * 2 // z = 4" 
            +"\n - \" / \" The operation of dividing two numbers: z = 2 / 2 // z = 1" 
            +"\n - \" % \" The operation of obtaining the remainder of an integer division of two numbers: z = 12 % 2 // z = 0" 
            +"\n - Unary arithmetic operations:" 
            +"\n - \" ++ \" increment operation: z = 12; ++z // z = 13" 
            +"\n - \" -- \" increment operation: z = 12; --z // z = 11" 
            +"\n - Priority of operations from highest to lowest:" 
            +"\n 1. increment, decrement\r\n 2. Multiplication, division, remainder\r\n 3. Addition, subtraction" 
            +"\n d = c---b*a; is same at d = (c--)-(b*a);" 
            +"\nPress any key to continue...");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
