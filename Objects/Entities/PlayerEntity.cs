using System.ComponentModel.DataAnnotations.Schema;

namespace BeybladeMatchMakerAPI.Objects.Entities
{
    [Table("PLAYERS")]
    public class PlayerEntity : BaseEntity
    {
        public string Alias { get; set; }
        
    }
}
