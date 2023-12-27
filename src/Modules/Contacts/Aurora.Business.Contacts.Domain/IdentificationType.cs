using Aurora.Framework.Entities;

namespace Aurora.Business.Contacts.Domain
{
    public class IdentificationType : EntityBase
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string AlternativeCode { get; set; }
        public string OneLetterCode { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public bool OnlyUseNumbers { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}