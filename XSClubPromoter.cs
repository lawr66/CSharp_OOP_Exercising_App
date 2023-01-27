public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
{
    public XSClubPromoter(string firstName, string lastName, string cellphone) : base(firstName, lastName, cellphone)
    {
    }

    public void Vlog()
    {
        Console.WriteLine("I vlog about gym tips.");
    }

    public void WorkOut()
    {
        Console.WriteLine("I work out daily.");
    }

    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my Instagram followers.");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I promote with FaceBook Ads");
    }
}