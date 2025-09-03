namespace WebOsTv.Net.Responses.Audio
{

    public class VolumeStatus
    {
        public bool volumeLimitable { get; set; }
        public bool activeStatus { get; set; }
        public int maxVolume { get; set; }
        public bool ossActivate { get; set; }
        public string volumeLimiter { get; set; }
        public string soundOutput { get; set; }
        public int volume { get; set; }
        public string mode { get; set; }
        public bool externalDeviceControl { get; set; }
        public bool muteStatus { get; set; }
        public bool volumeSyncable { get; set; }
        public bool adjustVolume { get; set; }
    }

}
