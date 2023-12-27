using Aurora.Framework.Entities;

namespace Aurora.Business.Contacts.Domain
{
    public class Contact : AuditableEntity
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public int IdentificationTypeId { get; set; }
        public string IdentificationNumber { get; set; }
        public Guid Guid { get; set; }
        public ContactType Type { get; set; }
        public string DisplayName { get; set; }
        public string FullName { get { return GetFullName(); } }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Notes { get; set; }
        public bool IsEditable { get; set; }
        public ContactStatus Status { get; set; }
        // public IdentificationType IdentificationType { get; set; }
        public List<ContactAddress> Addresses { get; set; }
        public List<ContactPhone> Phones { get; set; }

        protected virtual string GetFullName()
        {
            return string.Empty;
        }
    }

    public enum ContactType
    {
        Person,
        Company
    }

    public enum ContactStatus
    {
        Active = 1,
        Inactive = 2,
        Draft = 3
    }
}