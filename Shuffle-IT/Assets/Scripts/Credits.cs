using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Image credit;
    
    void Start()
    {
        credit = GetComponent<Image>();
        Color c = credit.material.color;
        c.a = 0f;
        credit.material.color = c;
        Fade();
    }

    IEnumerator FadingIn()
    {
        for ( float f = 0f; f <= 1; f += 0.2f)
        {
            Color c = credit.material.color;
            c.a = f;
            credit.material.color = c;
            yield return new WaitForSeconds (0.3f);
        }
    }

    public void Fade()
    {
        StartCoroutine("FadingIn");
    }

    public void Reset() 
    {
        SceneManager.LoadScene("Credits");
        PlayerPrefs.DeleteAll();
    }
}
