try
{
    var nullValue = 0;
    var value = 1 / nullValue; // Divide by 0 exception
    Console.WriteLine(value);
}
catch (Exception ex)
{
    Console.WriteLine("Catching a exception:" + ex.Message);
}

try
{
    var stringValue = "Hello World";

    Console.WriteLine(stringValue + " in try block");
}
catch (Exception ex)
{
    Console.WriteLine("Catching a exception:" + ex.Message);
}
finally
{
    Console.WriteLine("You have execute try-catch succesfuly");
    throw new Exception("Shota tu abarzel");
}