using System.Runtime.Serialization;

namespace BeybladeMatchMakerAPI.Objects.Models
{
    [DataContract]
    public class PlayerDto : BaseDto
    {
        [DataMember]
        public string Alias { get; set; }
        [DataMember]
        public List<BeybladeDto> Beys { get; set; }
    }
}