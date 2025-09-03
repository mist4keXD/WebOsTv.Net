using System.Threading.Tasks;
using WebOsTv.Net.Commands.Audio;
using WebOsTv.Net.Responses.Audio;

namespace WebOsTv.Net.Services
{
    public class AudioService : IAudioService
    {
        private readonly IClient _client;

        internal AudioService(IClient client)
        {
            _client = client;
        }

        public async Task<VolumeDetails> VolumeStatusAsync()
        {
            var response = await _client.SendCommandAsync<VolumeStatusResponse>(new VolumeStatusCommand());

            return new VolumeDetails
            {
                Volume = response.volume,
                Muted = response.mute
            };
        }

        public async Task VolumeDownAsync(int by = 1)
        {
            if (by == 1)
            {
                await _client.SendCommandAsync<VolumeDownResponse>(new VolumeDownCommand());
            }
            else
            {
                var volume = await VolumeStatusAsync();
                await SetVolumeAsync(volume.Volume - by);
            }
        }

        public async Task VolumeUpAsync(int by = 1)
        {
            if (by == 1)
            {
                await _client.SendCommandAsync<VolumeUpResponse>(new VolumeUpCommand());
            }
            else
            {
                var volume = await VolumeStatusAsync();
                await SetVolumeAsync(volume.Volume + by);
            }
        }

        public async Task MuteAsync()
        {
            await _client.SendCommandAsync<VolumeMuteResponse>(new VolumeMuteCommand {Mute = true});
        }

        public async Task UnmuteAsync()
        {
            await _client.SendCommandAsync<VolumeMuteResponse>(new VolumeMuteCommand {Mute = false});
        }

        public async Task MuteToggleAsync()
        {
            var volume = await VolumeStatusAsync();
            await _client.SendCommandAsync<VolumeMuteResponse>(new VolumeMuteCommand { Mute = !volume.Muted });
        }

        public async Task SetVolumeAsync(int volume)
        {
            await _client.SendCommandAsync<VolumeSetResponse>(new VolumeSetCommand {Volume = volume});
        }

        public class VolumeDetails
        {
            public int Volume { get; set; }
            public bool Muted { get; set; }
        }
    }
}