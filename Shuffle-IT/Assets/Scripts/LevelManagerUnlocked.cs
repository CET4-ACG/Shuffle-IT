using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerUnlocked : MonoBehaviour {
	public int Level;
	public Image Image;
	private string LevelString;

	void Start() 
	{
		ButtonSettings.releasedLevelStatic = PlayerPrefs.GetInt("Level", 1);

		if (ButtonSettings.releasedLevelStatic >= Level) 
		{
			Levelunlocked();
		} 
		else 
		{
			Levellocked();
		}
	}

	public void LevelSelect(string _level)
	{
		LevelString = _level;
		SceneManager.LoadScene(LevelString);
	}

	void Levellocked()
	{
		GetComponent<Image>().enabled = false;
		Image.enabled = true;
	}

	void Levelunlocked ()
	{
		GetComponent<Image>().enabled = true;
		Image.enabled = false;
	}
}
