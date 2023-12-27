using Aurora.Framework.Entities;

namespace Aurora.Business.Contacts.Domain
{
    public class ContactAddress : AuditableEntity
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public int ContactId { get; set; }
        public string AddressType { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public int CountryDivisionId { get; set; }
        public int CityId { get; set; }
        public string ZipCode { get; set; }
        public string Notes { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public Contact Contact { get; set; }
    }
}