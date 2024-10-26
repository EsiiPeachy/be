using System.ComponentModel.DataAnnotations.Schema;

namespace BeybladeMatchMakerAPI.Objects.Entities
{
    [Table("BLADES")]
    public class BladeEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Variant { get; set; }
    }
}
