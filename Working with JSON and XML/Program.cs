using System.Text.Json;

class JsonAndXML
{
    internal static void Main()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            // AllowTrailingCommas: устанавливает, надо ли добавлять после последнего элемента в json запятую.Если равно true, запятая добавляется
            // DefaultIgnoreCondition: устанавливает, будут ли сериализоваться / десериализоваться в json свойства со значениями по умолчанию
            // IgnoreReadOnlyProperties: аналогично устанавливает, будут ли сериализоваться свойства, предназначенные только для чтения
            // WriteIndented: устанавливает, будут ли добавляться в json пробелы(условно говоря, для красоты). Если равно true устанавливаются дополнительные пробелы
        };
        User user1 = new()
        {
            Name = "Test",
            Password= "password",
            Age= 30,
            Balance= 3000,
        };
        string json = JsonSerializer.Serialize(user1, options);
        Console.WriteLine(json);
        User user2 = JsonSerializer.Deserialize<User>(json);
        Console.WriteLine( "User Name is " + user2.Name);
    }

}
class User
{
    public string? Name { get; set; }
    public string? Password { get; set; }
    public int Age { get; set; }
    public int Balance { get; set; }
}