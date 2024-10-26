using System.Runtime.Serialization;

namespace BeybladeMatchMakerAPI.Objects.Models
{
    [DataContract]
    public class BeybladeDto : BaseDto
    {
        [DataMember]
        public string Blade { get; set; }

        [DataMember]
        public string Ratchet { get; set; }

        [DataMember]
        public string Bit { get; set; }
    }
}