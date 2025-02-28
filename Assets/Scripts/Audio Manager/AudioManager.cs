using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private List<AudioData> _sounds;

    [SerializeField] private AudioHolder audioHolder;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _sounds = new List<AudioData>(audioHolder.AudioDatas);
        foreach (var s in _sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();

            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.mute = s.mute;
            s.source.playOnAwake = false;
        }
    }

    private void Start()
    {
        UnmuteSound();
        UnmuteMusic();
        PlayStartSounds();
    }

    public void PlayStartSounds()
    {
        Play("Theme");
        //Play("Breathe");
        //Play("Spaceship");
    }
    public void Play(string name)
    {
        var s = _sounds.Find(sound => sound.name == name);
        if (s == null)
            return;

        s.source.Play();
    }
    public void Stop(string name)
    {
        var s = _sounds.Find(sound => sound.name == name);
        if (s == null)
            return;

        s.source.Stop();
    }
    public bool IsPlaying(string name)
    {
        var s = _sounds.Find(sound => sound.name == name);
        return s != null && s.source.isPlaying;
    }
    public void MuteSound()
    {
        var s = _sounds.Where(sound => sound.audioType == AudioType.Sound).ToList();
        if (s.Count == 0)
        {
            return;
        }

        foreach (var audioData in s)
        {
            audioData.source.mute = true;
            audioData.mute = true;
        }
    }

    public void UnmuteSound()
    {
        var s = _sounds.Where(sound => sound.audioType == AudioType.Sound).ToList();
        if (s.Count == 0)
        {
            return;
        }

        foreach (var audioData in s)
        {
            audioData.source.mute = false;
            audioData.mute = false;
        }
    }

    public void MuteMusic()
    {
        var s = _sounds.Find(sound => sound.audioType == AudioType.Music);
        if (s == null)
            return;
        s.source.mute = true;
        s.mute = true;
    }

    public void UnmuteMusic()
    {
        var s = _sounds.Find(sound => sound.audioType == AudioType.Music);
        if (s == null)
            return;
        s.source.mute = false;
        s.mute = false;
    }

    public void MuteSpecificTrack(string name)
    {
        var s = _sounds.Find(sound => sound.name == name);
        if (s == null)
            return;
        s.source.mute = true;
        s.mute = true;
    }
    public void UnmuteSpecificTrack(string name)
    {
        var s = _sounds.Find(sound => sound.name == name);
        if (s == null)
            return;
        s.source.mute = false;
        s.mute = false;
    }
}