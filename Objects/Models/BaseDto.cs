using System.Runtime.Serialization;

namespace BeybladeMatchMakerAPI.Objects.Models
{
    [DataContract]
    public class BaseDto
    {
        [DataMember]
        public string? ID { get; set; }
    }
}