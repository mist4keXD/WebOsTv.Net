namespace WebOsTv.Net.Responses.Audio
{

    public class VolumeStatusResponse : ResponseBase
    {
        public bool returnValue { get; set; }
        public VolumeStatus volumeStatus { get; set; }
        public string callerId { get; set; }
        public bool mute { get; set; }
        public int volume { get; set; }

    }
}
