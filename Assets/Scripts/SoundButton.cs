using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] bool _soundIsOn;
    [SerializeField] Sprite _activeSprite, _inactiveSprite;
    MusicManager _musicManager;
    Image _image;
    void Start()
    {
        _musicManager = FindObjectOfType<MusicManager>();
        _soundIsOn = _musicManager.AudioSettings.SoundIsOn;
        _image = GetComponent<Image>();
        SetSprite();
   
    }

    public void OnSoundToggle()
    {
        _soundIsOn = !_soundIsOn;
        _musicManager.ToggleSoundState();
        SetSprite();
    }

    void SetSprite()
    {
        _image.sprite = _soundIsOn ? _activeSprite : _inactiveSprite;
    }
}
