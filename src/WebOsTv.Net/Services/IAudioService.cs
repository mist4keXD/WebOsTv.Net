using System.Threading.Tasks;

namespace WebOsTv.Net.Services
{
    public interface IAudioService
    {
        Task<AudioService.VolumeDetails> VolumeStatusAsync();
        Task VolumeDownAsync(int by = 1);
        Task VolumeUpAsync(int by = 1);
        Task MuteAsync();
        Task UnmuteAsync();
        Task MuteToggleAsync();
        Task SetVolumeAsync(int volume);
    }
}