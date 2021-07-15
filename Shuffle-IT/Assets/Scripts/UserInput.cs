using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class UserInput : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public string word;
    public GameObject InputField;
    public GameObject Options;

    public Image image;
    public Sprite button;
    public Sprite holdbutton;


    public void UserGuess()
    {
        word = InputField.GetComponent<Text>().text.ToUpper();

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if (word == "BYTE")
            {
                LoadScene("Level1-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            if (word == "VIRUS")
            {
                LoadScene("Level2-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            if (word == "ASCII")
            {
                LoadScene("Level3-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level4")
        {
            if (word == "NIBBLE")
            {
                LoadScene("Level4-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level5")
        {
            if (word == "PYTHON")
            {
                LoadScene("Level5-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level6")
        {
            if (word == "COMPUTER")
            {
                LoadScene("Level6-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level7")
        {
            if (word == "COMPILER")
            {
                LoadScene("Level7-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level8")
        {
            if (word == "SOFTWARE")
            {
                LoadScene("Level8-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level9")
        {
            if (word == "INTERNET")
            {
                LoadScene("Level9-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level10")
        {
            if (word == "ALGORITHM")
            {
                LoadScene("Level10-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level11")
        {
            if (word == "PROCESSOR")
            {
                LoadScene("Level11-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level12")
        {
            if (word == "MOTHERBOARD")
            {
                LoadScene("Level12-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level13")
        {
            if (word == "CONCATENATE")
            {
                LoadScene("Level13-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level14")
        {
            if (word == "DATA STRUCTURE")
            {
                LoadScene("Level14-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level15")
        {
            if (word == "CLOUD COMPUTING")
            {
                LoadScene("Level15-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level16")
        {
            if (word == "WEB DEVELOPMENT")
            {
                LoadScene("Level16-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level17")
        {
            if (word == "OPERATING SYSTEM")
            {
                LoadScene("Level17-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level18")
        {
            if (word == "RANDOM ACCESS MEMORY")
            {
                LoadScene("Level18-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level19")
        {
            if (word == "ARTIFICIAL INTELLIGENCE")
            {
                LoadScene("Level19-SC");
            }
        }
        else if (SceneManager.GetActiveScene().name == "Level20")
        {
            if (word == "OBJECT ORIENTED PROGRAMMING")
            {
                LoadScene("Level20-SC");
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ToOptions()
    {
        Options.SetActive(true);
    }

    public void HomeInOption()
    {
        Options.SetActive(false);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.sprite = holdbutton;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        image.sprite = button;
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Select);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
