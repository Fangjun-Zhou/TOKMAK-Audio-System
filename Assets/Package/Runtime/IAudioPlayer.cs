// ReSharper disable once CheckNamespace
namespace AudioSystem.Runtime
{
    /// <summary>
    /// The interface for audio player.
    /// Includes basic operation to play audio.
    /// </summary>
    public interface IAudioPlayer
    {
        /// <summary>
        /// Play the audio from start
        /// </summary>
        void Play();

        /// <summary>
        /// Stop the audio
        /// </summary>
        void Stop();

        /// <summary>
        /// Resume to play the audio from the point of last Stop()
        /// </summary>
        void Resume();

    }
}