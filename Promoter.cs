public abstract class Promoter
{
    private string _lastName;
    
    private string _cellphone;
    public Promoter(string firstName, string lastName, string cellphone)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        _cellphone = cellphone;
    }
        public void Promote()
        {
            this.ShareWithInnerCircle();
            this.UsePaidAds();
        }

        protected abstract void ShareWithInnerCircle();
        protected abstract void UsePaidAds();

         private string _firstName;

    public string MyBusinessCard
    {
        get
        {
            return string.Format("{0} {1} {2}", this._firstName, this._lastName,this._cellphone);
        }
    }
}