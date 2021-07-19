using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class MuteManagerMusic : MonoBehaviour
{
	Toggle Sounds;

	void Start() 
	{
		Sounds = GetComponent<Toggle>();
		if (AudioListener.volume == 0)
		{
			Sounds.isOn = false;
		}
	}

	public void ToggleAudioOnValueChange(bool audioIn)
	{
		if (audioIn)
		{
			AudioListener.volume = 1;
		}
		else
		{
			AudioListener.volume = 0;
		}
		PlayerPrefs.Save();
	}
}
