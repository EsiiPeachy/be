using System.ComponentModel.DataAnnotations.Schema;

namespace BeybladeMatchMakerAPI.Objects.Entities
{
    [Table("BITS")]
    public class BitEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
