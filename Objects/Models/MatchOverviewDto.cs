using System.Runtime.Serialization;

namespace BeybladeMatchMakerAPI.Objects.Models
{
    [DataContract]
    public class MatchOverviewDto : BaseDto
    {
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public List<MatchDetailDto> Detail { get; set; }
    }
}