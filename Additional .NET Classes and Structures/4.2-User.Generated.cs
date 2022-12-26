namespace Additional_.NET_Classes_and_Structures
{
    // Located in User
    internal partial class User
    {
        public partial void PrintUser() // Partial method
        {
            Console.WriteLine($"User with name {Name} is {Id}-id");
        }

        public void ChangeName(string name)
        {
            Name = name;
            Console.WriteLine($"Changed name from user: {Name} is {Id}-id");
        }
    }
}