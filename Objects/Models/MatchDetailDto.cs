using System.Runtime.Serialization;

namespace BeybladeMatchMakerAPI.Objects.Models
{
    [DataContract]
    public class MatchDetailDto : BaseDto
    {
        [DataMember]
        public List<PlayerDto> Player { get; set; }
        [DataMember]
        public int Score { get; set; }

    }
}