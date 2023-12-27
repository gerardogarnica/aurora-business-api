using Aurora.Framework.Entities;

namespace Aurora.Business.Contacts.Domain
{
    public class ContactPhone : AuditableEntity
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public int ContactId { get; set; }
        public string CountryCode { get; set; }
        public string PhoneType { get; set; }
        public string Number { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public Contact Contact { get; set; }
    }
}