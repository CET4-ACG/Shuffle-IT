using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UserInput : MonoBehaviour
{
    public string word;
    public GameObject InputField;
    public GameObject StageComplete;

    public void UserGuess()
    {
        word = InputField.GetComponent<Text>().text.ToUpper();

        if (word == "BYTE")
        {
            StageComplete.SetActive(true);
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
