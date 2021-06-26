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
    public GameObject Stages;

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
    }

    public void ToStages()
    {
        Stages.SetActive(true);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        image.sprite = holdbutton;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        image.sprite = button;
    }

    public void QuitButton()
    {
        Application.Quit();
        PlayerPrefs.DeleteAll();
    }
}
