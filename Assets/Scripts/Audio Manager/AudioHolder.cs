﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public enum AudioType
{
    Music,
    Sound
}
[CreateAssetMenu (fileName = "Audio Manager")]
public class AudioHolder : ScriptableObject
{
    [Space(50)]
    public List<AudioData> AudioDatas = new List<AudioData>();

}

[System.Serializable]
public class AudioData
{
    public string name;

    public AudioType audioType;
    public AudioClip clip;
    [Range(0, 1)] public float volume = 1;
    [Range(-3, 3)] public float pitch = 1;
    public bool mute;
    public bool loop;
    [HideInInspector]
    public AudioSource source;
}