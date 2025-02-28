using EnumCollection;
using UnityEngine;

public class SoundManager : MonoBehaviour
{ 
    AudioManager _audioManager;

    public void AudioHandler()
    {
        var musicKey = PlayerPrefKeys.Music.ToString();
        var soundKey = PlayerPrefKeys.Sound.ToString();
        if (!PlayerPrefs.HasKey(musicKey))
        {
            _audioManager.UnmuteMusic();
        }

        if (!PlayerPrefs.HasKey(soundKey))
        {
            _audioManager.UnmuteSound();
        }

        if (PlayerPrefs.GetInt(musicKey) == 0)
        {
            _audioManager.MuteMusic();
        }

        if (PlayerPrefs.GetInt(musicKey) == 1)
        {
            _audioManager.UnmuteMusic();
        }


        if (PlayerPrefs.GetInt(soundKey) == 0)
        {
            _audioManager.MuteSound();
        }

        if (PlayerPrefs.GetInt(soundKey) == 1)
        {
            _audioManager.UnmuteSound();
        }
    }

    public void Initialize()
    {
        
    }
}