public class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog on YouTube about books.");
    }

    public override void Write()
    {
        Console.WriteLine("I write books.");
    }
}