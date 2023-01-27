public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, string cellphone) : base(firstName, lastName, cellphone)
    {
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my friends.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I promote with Google AdWords");
    }
}