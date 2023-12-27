namespace Aurora.Business.Contacts.Domain
{
    public class Company : Contact
    {
        public string TradeName { get; set; }
        public string BusinessName { get; set; }
        public string LegalRepresentative { get; set; }
        public string Logo { get; set; }

        protected override string GetFullName()
        {
            return TradeName;
        }
    }
}