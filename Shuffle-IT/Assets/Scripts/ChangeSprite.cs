using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public SpriteRenderer rend;
    public Sprite[] SpriteArray;

    void Start() 
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = SpriteArray[0];

        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;
        Fading();
    }

    void Update() 
    {
        if (rend.sprite == SpriteArray[0])
        {
            ChangeImage();
            if (rend.sprite == SpriteArray[1])
            {
                ChangeImage();
                if (rend.sprite == SpriteArray[2])
                {
                    ChangeImage();
                    if (rend.sprite == SpriteArray[3])
                    {
                        ChangeImage();
                    }
                }
            }
        }
    }

    public void ChangeImage()
    {
        if (rend.sprite == SpriteArray[0])
        {
            rend.sprite = SpriteArray[1];
        }
        else if (rend.sprite == SpriteArray[1])
        {
            rend.sprite = SpriteArray[2];
        }
        else if (rend.sprite == SpriteArray[2])
        {
            rend.sprite = SpriteArray[3];
        }
        else if (rend.sprite == SpriteArray[3])
        {
            rend.sprite = SpriteArray[0];
        }    
    }

    IEnumerator FadeIn()
    {
        for ( float f = 0.05f; f <= 1; f += 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds (0.03f);
        }
    }

    public void Fading()
    {
        StartCoroutine("FadeIn");
    }

}

