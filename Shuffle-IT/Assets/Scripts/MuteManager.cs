using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MuteManager : MonoBehaviour
{
    public Toggle SoundToggle;
    public AudioSource Audio;

    private void Start() 
    {   
        SoundToggle = GetComponent<Toggle>();
        Audio = GetComponent<AudioSource>();
        if (Audio.volume == 0)
        {
            SoundToggle.isOn = false;
        }
    }

    public void ToggleAudioOnValueChange(bool audioIn)
    {
        if (audioIn)
        {
            Audio.Play();
        }
        else
        {
            Audio.Stop();
        }
    }
}
