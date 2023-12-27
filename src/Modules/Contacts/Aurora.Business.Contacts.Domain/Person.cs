namespace Aurora.Business.Contacts.Domain
{
    public class Person : Contact
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }

        protected override string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}