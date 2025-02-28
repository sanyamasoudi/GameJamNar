using System;
using System.Collections;
using System.Collections.Generic;
using EnumCollection;
using UnityEngine;

public class GameMusicManager : MonoBehaviour
{
    [SerializeField] private Sound musicToStop;
    [SerializeField] private Sound musicToStart;
    private void Start()
    {
        AudioManager.Instance.Stop(musicToStop.ToString());
        AudioManager.Instance.Play(musicToStart.ToString());
    }
}
