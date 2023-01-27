public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I vlog on YouTube about my travels");
    }

    public override void Write()
    {
        Console.WriteLine("I write on my blog");
    }
}