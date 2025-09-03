namespace WebOsTv.Net.Commands.Audio
{
    public class VolumeStatusCommand : NoPayloadCommandBase
    {
        public override string Uri => "ssap://audio/getStatus";
    }
}
