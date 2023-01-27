// See https://aka.ms/new-console-template for more information
List<Promoter> promoters = new List<Promoter>() {new XSClubPromoter("John","Smith","0745642449"), new XSClubPromoter("Sam","Brown","0756523199"), new OmniaClubPromoter("Peter","Trupe","0722456298")};
foreach(var person in promoters)
{
    person.Promote();    
}

List<Writer> writers = new List<Writer>() {new BookWriter("Mary","Smith"), new BookWriter("Sally","Bean"), new BlogWriter("Oliver","Sandem")};
foreach(var person in writers)
{
    person.Write();    
}

List<IBodyBuilder> bodyBuilders = new List<IBodyBuilder>() {new XSClubPromoter("Tom","Peterson", "0796321452"), new XSClubPromoter("Robert","Nemo", "0799543266")};
foreach(var person in bodyBuilders)
{
    person.WorkOut();    
}

List<IVlogger> vloggers = new List<IVlogger>() {new BlogWriter("Kent","Bucklet"), new XSClubPromoter("Robert","Nemo", "0799543266")};
foreach(var person in vloggers)
{
    person.Vlog();    
}