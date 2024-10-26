using System.Runtime.Serialization;

namespace BeybladeMatchMakerAPI.Objects.Models
{
    [DataContract]
    public class BladeDto : BaseDto
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Variant { get; set; }
    }
}