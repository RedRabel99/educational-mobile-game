using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SoundSystem/Audio Componnent", fileName = "AC_")]
public class AudioComponent : ScriptableObject
{
    [SerializeField] public AudioClip[] AudioClips;


    [SerializeField]
    public bool MusicIsOn;
    [SerializeField]
    public bool SoundIsOn;
}
